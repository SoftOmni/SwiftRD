using System;
using System.Collections.Generic;
using JetBrains.ReSharper.Psi.Parsing;
using JetBrains.Text;
using JetBrains.Util;
using ReSharperPlugin.Swift.Language.Parser.Lexer.Tokens;
using ReSharperPlugin.Swift.Language.Parser.Lexer.Tokens.Errors;
using ReSharperPlugin.Swift.Language.Parser.Lexer.Tokens.WhitespaceAndComments;

namespace ReSharperPlugin.Swift.Language.Parser.Lexer;

public partial class SwiftLexer : IIncrementalLexer
{
    public SwiftLexer(IBuffer buffer)
        : this(buffer, buffer.Length)
    { }

    public SwiftLexer(IBuffer buffer, int eofPos)
    {
        Buffer = buffer;
        CurrentPosition = 0;

        TokenType = null;
        TokenStart = 0;
        TokenEnd = 0;

        EOFPos = eofPos;
    }

    public void Start()
    {
        Start(0, Buffer.Length, 0);
    }

    // ReSharper disable once CognitiveComplexity
    public void Advance()
    {
        if (TokenEnd == EOFPos)
        {
            PreviousTokenType = TokenType;
            TokenType = SwiftTokens.EndOfFileToken;
            TokenStart = EOFPos;
            TokenEnd = EOFPos;
        }

        PreviousTokenType = TokenType;
        if (IsInBlockComment)
        {
            AdvanceMultLineComment();
            AdvanceTokenTape();
            return;
        }

        if (ThreeQuotesSettingInEffect is not null)
        {
            bool advanceTokenTape = LexContinuationOfThreeQuotesSystem();
            if (advanceTokenTape)
            {
                AdvanceTokenTape();
            }
            return;
        }
        
        if (FourQuotesSettingInEffect is not null)
        {
            bool advanceTokenTape = LexContinuationOfFourQuotesSystem();
            if (advanceTokenTape)
            {
                AdvanceTokenTape();
            }
            return;
        }
        
        if (FiveQuotesSettingInEffect is not null)
        {
            bool advanceTokenTape = LexContinuationOfFiveQuotesSystem();
            if (advanceTokenTape)
            {
                AdvanceTokenTape();
            }
            return;
        }

        char firstChar = Buffer[TokenEnd];

        if (firstChar == Dot)
        {
            LexDot();
            AdvanceTokenTape();
            return;
        }

        if (IsInStringLiteral is StringLiteralPosition.InSimpleStringLiteral
            or StringLiteralPosition.InMultiLineStringLiteral
           && firstChar == Backslash)
        {
            LexEscape();
            AdvanceTokenTape();
            return;
        }

        NextDotOperatorShouldBePostfix = false;

        switch (firstChar)
        {
            case '\u0009': // \t (tab)
            case '\u0020': // \u0020 (space)
                LexWhitespace();
                AdvanceTokenTape();
                return;
            case '\u000A': // \n (line feed)
            case '\u000D': // \r (carriage return)
                LexLineBreak();
                AdvanceTokenTape();
                return;
            case '/': // / (forward slash)
                LexSlash();
                AdvanceTokenTape();
                return;
            case '=': // = (equal)
            case '+': // + (plus)
            case '*': // * (star)
            case '%': // % (modulo)
            case '<': // < (less than)
            case '>': // > (greater than)
            case '&': // & (and)
            case '|': // | (or)
            case '^': // ^ (xor)
            case '~': // ~ (bitwise not)
                LexOperator();
                AdvanceTokenTape();
                return;
            case '#': // # (hash)
            case '"': // " (double quote)
                LexStringLiteralStart();
                AdvanceTokenTape();
                return;
            case '-': // - (dash)
                LexDash();
                AdvanceTokenTape();
                return;
            case '?':
                LexQuestionMark();
                AdvanceTokenTape();
                return;
            case '!':
                LexExclamationMark();
                AdvanceTokenTape();
                return;
        }

        if (firstChar.IsOperatorHead())
        {
            LexOperator();
            AdvanceTokenTape();
            return;
        }

        if (firstChar.IsIdentifierHead())
        {
            LexIdentifierOrKeyword();
            AdvanceTokenTape();
            return;
        }

        // This means this is an invalid char
        LexInvalidToken();
    }

    public void Start(int startOffset, int endOffset, uint state)
    {
        throw new NotImplementedException();
    }

    public object CurrentPosition { get; set; }

    public TokenNodeType? TokenType { get; private set; }

    private TokenNodeType? PreviousTokenType { get; set; }

    public int TokenStart { get; private set; }

    public int TokenEnd { get; private set; }

    public IBuffer Buffer { get; private set; }

    public int CommentLevel { get; private set; }

    public Stack<(int token, int tokenStart, int tokenEnd)> StringLiteralsTypesStacks { get; private set; } = new();

    public Stack<(int token, int tokenStart, int tokenEnd)> MultilineStringLiteralTypesStacks { get; private set; } = new();

    public Stack<int> IsInMultilinePairSearch { get; private set; } = new();
    
    public Stack<int> IsInSimplePairSearch { get; private set; } = new();

    public Stack<int> IsInInterpolation { get; private set; } = new();

    public StringLiteralPosition IsInStringLiteral { get; private set; } = StringLiteralPosition.OutOfStringLiteral;

    public SwiftLexerSettings.ThreeQuotesSetting? ThreeQuotesSettingInEffect { get; private set; } = null;

    public SwiftLexerSettings.FourQuotesSetting? FourQuotesSettingInEffect { get; private set; } = null;

    public SwiftLexerSettings.FiveQuotesSetting? FiveQuotesSettingInEffect { get; private set; } = null;

    public bool NextDotOperatorShouldBePostfix { get; private set; } = false;

    public uint LexerStateEx { get; private set; }

    public int EOFPos { get; private set; }

    public int LexemIndent { get; }

    private List<(int start, int end, TokenNodeType tokenNodeType)> _tokens = new();
    
    public int TokenCount => _tokens.Count;
    
    public (int start, int end, TokenNodeType tokenNodeType) this[int index]
    {
        get => _tokens[index];
        internal set => _tokens[index] = value;
    }

    public bool IsInBlockComment => CommentLevel > 0;

    private void LexSlash()
    {
        TokenStart = TokenEnd;

        TokenEnd++;
        if (TokenEnd == EOFPos || Buffer[TokenEnd] is not '/' and not '*')
        {
            // This means we have a single '/' character so this is not a comment but an operator
            TokenEnd--;
            LexOperator();
            return;
        }


        if (Buffer[TokenEnd] == '/')
        {
            TokenEnd++;
            LexSingleLineComment();
            return;
        }

        TokenEnd++;
        TokenType = new BlockCommentStartToken();
        LexerStateEx = 1;
        CommentLevel++;
    }

    private void LexInvalidToken()
    {
        char invalidChar = Buffer[TokenEnd];
        TokenStart = TokenEnd;
        TokenEnd++;

        TokenType = new InvalidToken(invalidChar);
    }

    private string GetCurrentText()
    {
        return Buffer.GetText(new TextRange(TokenStart, TokenEnd));
    }

    private void AdvanceTokenTape()
    {
        TokenType ??= SwiftTokens.EmptyToken;

        _tokens.Add((TokenStart, TokenEnd, TokenType));
    }

    public enum StringLiteralPosition
    {
        OutOfStringLiteral,
        InSimpleStringLiteral,
        InSurroundedSimpleStringLiteral,
        InMultiLineStringLiteral,
        InSurroundedMultiLineStringLiteral,
    }
}

internal static partial class SwiftLexerExtensions
{
    public static void AddUnicodeRange(this HashSet<char> set, char start, char end, bool inclusive = false)
    {
        for (char c = start; c < end; c++)
        {
            set.Add(c);
        }

        if (inclusive)
        {
            set.Add(end);
        }
    }
}