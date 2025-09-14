using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using NuGet;
using ReSharperPlugin.Swift.Language.Parser.Lexer.Tokens.Errors;
using ReSharperPlugin.Swift.Language.Parser.Lexer.Tokens.Operators.UserDefinedOperators;

namespace ReSharperPlugin.Swift.Language.Parser.Lexer;

public partial class SwiftLexer
{
    public const char Plus = '+';

    public const char Dash = '-';
    
    internal static readonly FrozenSet<char> OperatorHeads = FillOperatorHeads();

    internal static readonly FrozenSet<char> OperatorCharacters = FillOperatorCharacters();

    internal static readonly FrozenSet<char> DotOperatorCharacters = FillDotOperatorCharacters();

    private void LexOperator()
    {
        LexOperator(SwiftLexerExtensions.IsOperatorCharacter);
    }

    private void LexOperator(Func<char, bool> operatorCheck)
    {
        if (PreviousTokenType is null || TokenStart == 0) // The operator is the first token in the file
        {
            LexStartingPostfixOperator(operatorCheck);
            return;
        }

        char previousChar = Buffer[TokenStart];

        TokenStart = TokenEnd;
        while (TokenEnd < EOFPos && operatorCheck(Buffer[TokenEnd]))
        {
            TokenEnd++;
        }

        if (previousChar.IsOperatorLeadingWhitespace())
        {
            LexPostfixOrInfixOperator();
            return;
        }

        string @operator = GetCurrentText();
        if (TokenEnd == EOFPos || Buffer[TokenEnd].IsOperatorFollowerWhitespace())
        {
            // There's just something behind us and nothing else so 
            // this is a prefix operator
            TokenType = new PrefixOperatorToken(@operator);
            return;
        }

        if (Buffer[TokenEnd] == Dot)
        {
            TokenType = new PrefixOperatorToken(@operator);
            NextDotOperatorShouldBePostfix = true;
            return;
        }

        TokenType = new InfixOperatorToken(@operator);
    }

    private void LexStartingPostfixOperator(Func<char, bool> operatorCheck)
    {
        TokenStart = TokenEnd;
        while (TokenEnd < EOFPos && operatorCheck(Buffer[TokenEnd]))
        {
            TokenEnd++;
        }

        string @operator = GetCurrentText();
        if (TokenEnd == EOFPos)
        {
            TokenType = new UnmatchedOperatorToken(@operator,
                UnmatchedOperatorToken.ErrorCase.UnmatchedOperatorOnlyEmpty);
            return;
        }

        if (Buffer[TokenEnd].IsOperatorFollowerWhitespace())
        {
            TokenType = new PostfixOperatorToken(@operator);
            return;
        }

        TokenType = Buffer[TokenEnd].IsOperatorFollowerUnexpectedWhitespace()
            ? new UnmatchedOperatorToken(@operator, UnmatchedOperatorToken.ErrorCase.UnmatchedStartingPostfixOperator)
            : new UnmatchedOperatorToken(@operator, UnmatchedOperatorToken.ErrorCase.UnmatchedStartingPostfixOperatorWhitespaceUnexpected);
    }

    private void LexPostfixOrInfixOperator()
    {
        string @operator = GetCurrentText();

        if (TokenEnd == EOFPos)
        {
            TokenType = new UnmatchedOperatorToken(@operator,
                UnmatchedOperatorToken.ErrorCase.UnmatchedPostfixOrInfixOperatorEof);
            return;
        }

        if (Buffer[TokenEnd].IsOperatorFollowerWhitespace())
        {
            TokenType = new InfixOperatorToken(@operator);
            return;
        }

        TokenType = new PostfixOperatorToken(@operator);
    }

    private void LexDotOperator()
    {
        if (!NextDotOperatorShouldBePostfix)
        {
            LexOperator(SwiftLexerExtensions.IsDotOperatorCharacter);
            return;
        }

        TokenStart = TokenEnd;
        while (TokenEnd < EOFPos && Buffer[TokenEnd].IsDotOperatorCharacter())
        {
            TokenEnd++;
        }

        string @operator = GetCurrentText();
        if (TokenEnd == EOFPos)
        {
            TokenType = new UnmatchedOperatorToken(@operator,
                UnmatchedOperatorToken.ErrorCase.UnmatchedForciblyPostfixDotOperatorEof);
            return;
        }

        if (Buffer[TokenEnd].IsOperatorFollowerWhitespace())
        {
            TokenType = Buffer[TokenEnd].IsOperatorFollowerUnexpectedWhitespace()
                    ? new UnmatchedOperatorToken(@operator, UnmatchedOperatorToken.ErrorCase.UnmatchedForciblyPostfixDotOperatorWhitespaceUnexpected)
                    : new UnmatchedOperatorToken(@operator, UnmatchedOperatorToken.ErrorCase.UnmatchedForciblyPostfixDotOperatorWhitespace);
            return;
        }

        TokenType = new PostfixOperatorToken(@operator);
        NextDotOperatorShouldBePostfix = false;
    }

    private static FrozenSet<char> FillOperatorHeads()
    {
        HashSet<char> operatorHeads = [];

        operatorHeads.AddRange(['/', '=', Dash, Plus, '!', '*', '%', '<', '>', '&', '|', '^', '~', '?']);

        operatorHeads.AddUnicodeRange('\u00A1', '\u00A8', inclusive: true);
        operatorHeads.AddRange(['\u00A9', '\u00AB']);
        operatorHeads.AddRange(['\u00AC', '\u00AE']);
        operatorHeads.AddUnicodeRange('\u00B0', '\u00B1', inclusive: true);
        operatorHeads.AddRange(['\u00B6', '\u00BB', '\u00BF', '\u00D7', '\u00F7']);
        operatorHeads.AddUnicodeRange('\u2016', '\u2017', inclusive: true);
        operatorHeads.AddUnicodeRange('\u2020', '\u2027', inclusive: true);
        operatorHeads.AddUnicodeRange('\u2030', '\u203E', inclusive: true);
        operatorHeads.AddUnicodeRange('\u2041', '\u2053', inclusive: true);
        operatorHeads.AddUnicodeRange('\u2055', '\u205E', inclusive: true);
        operatorHeads.AddUnicodeRange('\u2190', '\u23FF', inclusive: true);
        operatorHeads.AddUnicodeRange('\u2500', '\u2775', inclusive: true);
        operatorHeads.AddUnicodeRange('\u2794', '\u2BFF', inclusive: true);
        operatorHeads.AddUnicodeRange('\u2E00', '\u2E7F', inclusive: true);
        operatorHeads.AddUnicodeRange('\u3001', '\u3003', inclusive: true);
        operatorHeads.AddUnicodeRange('\u3008', '\u3020', inclusive: true);
        operatorHeads.Add('\u3030');

        return operatorHeads.ToFrozenSet();
    }

    private static FrozenSet<char> FillOperatorCharacters()
    {
        HashSet<char> operatorCharacters = new(OperatorHeads);

        operatorCharacters.AddUnicodeRange('\u0300', '\u036F', inclusive: true);
        operatorCharacters.AddUnicodeRange('\u1DC0', '\u1DFF', inclusive: true);
        operatorCharacters.AddUnicodeRange('\u20D0', '\u20FF', inclusive: true);
        operatorCharacters.AddUnicodeRange('\uFE00', '\uFE0F', inclusive: true);
        operatorCharacters.AddUnicodeRange('\uFE20', '\uFE2F', inclusive: true);
        // TODO: add support for the upper surrogate range
        // operatorCharacters.AddUnicodeRange('\U000E0100', '\U000E01EF', inclusive: true);

        return operatorCharacters.ToFrozenSet();
    }

    private static FrozenSet<char> FillDotOperatorCharacters()
    {
        HashSet<char> dotOperatorCharacters = new(OperatorCharacters);
        dotOperatorCharacters.Add(Dot);
        return dotOperatorCharacters.ToFrozenSet();
    }
}

internal static partial class SwiftLexerExtensions
{
    public static bool IsOperatorHead(this char c)
    {
        return SwiftLexer.OperatorHeads.Contains(c);
    }

    public static bool IsOperatorCharacter(this char c)
    {
        return SwiftLexer.OperatorCharacters.Contains(c);
    }

    public static bool IsDotOperatorCharacter(this char c)
    {
        return SwiftLexer.DotOperatorCharacters.Contains(c);
    }

    public static bool IsOperatorUniversalUnexpectedWhitespace(this char c)
    {
        const char comma = ',';
        const char colon = ':';
        const char semicolon = ';';

        return c is comma or colon or semicolon;
    }

    public static bool IsOperatorLeadingUnexpectedWhitespace(this char c)
    {
        const char leftParenthesis = '(';
        const char leftBracket = '[';
        const char leftBrace = '{';

        return c.IsOperatorUniversalUnexpectedWhitespace() || c is leftParenthesis or leftBracket or leftBrace;
    }

    public static bool IsOperatorLeadingWhitespace(this char c)
    {
        return c.IsWhitespace() || c.IsOperatorLeadingUnexpectedWhitespace();
    }

    public static bool IsOperatorFollowerUnexpectedWhitespace(this char c)
    {
        const char rightParenthesis = ')';
        const char rightBracket = ']';
        const char rightBrace = '}';

        return c is rightParenthesis or rightBracket or rightBrace;
    }

    public static bool IsOperatorFollowerWhitespace(this char c)
    {
        return c.IsWhitespace() || c.IsOperatorFollowerUnexpectedWhitespace();
    }
}