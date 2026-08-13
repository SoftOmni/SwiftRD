using System;
using SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens;
using SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Errors;
using SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Literals;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer;

public partial class SwiftLexer
{
    public const char DoubleQuote = '"';

    public const char Backslash = '\\';

    public const char SingleQuote = '\'';

    public const char OpenParenthesis = '(';

    public const char ClosingParenthesis = ')';

    public const char OpenCurlyBrace = '{';

    public const char ClosingCurlyBrace = '}';

    // ReSharper disable once CognitiveComplexity
    private void LexStringLiteralStart()
    {
        TokenStart = TokenEnd;
        int numberOfHashtags = 0;
        while (TokenEnd < EOFPos && Buffer[TokenEnd] == Hashtag)
        {
            numberOfHashtags++;
            TokenEnd++;
        }

        if (TokenEnd == EOFPos)
        {
            TokenType = SwiftTokens.UnmatchedHashtagToken;

            BackingUnmatchedHashtagToken backingUnmatchedHashtagToken = new(GetCurrentText(),
                BackingUnmatchedHashtagToken.ErrorCase.UnmatchedHashtagEof);
            BackPutBackingToken(backingUnmatchedHashtagToken);

            return;
        }

        if (Buffer[TokenEnd] != DoubleQuote)
        {
            if (numberOfHashtags > 1)
            {
                TokenType = SwiftTokens.UnmatchedHashtagToken;

                BackingUnmatchedHashtagToken backingUnmatchedHashtagToken = new(GetCurrentText(),
                    BackingUnmatchedHashtagToken.ErrorCase.UnmatchedHashtagLiteralString);
                BackPutBackingToken(backingUnmatchedHashtagToken);
            }
            else
            {
                LexReservedKeyword();
            }

            return;
        }

        // We have a string literal start quote
        TokenEnd++;
        if (TokenEnd == EOFPos)
        {
            TokenType = SwiftTokens.ErroneousStringLiteralToken;

            BackingErroneousStringLiteralToken backingErroneousStringLiteralToken = numberOfHashtags > 1
                ? new BackingErroneousStringLiteralToken(BackingErroneousStringLiteralToken.ErrorCase
                    .UnclosedStringLiteralWithHashtagsEof, string.Empty, GetCurrentText())
                : new BackingErroneousStringLiteralToken(
                    BackingErroneousStringLiteralToken.ErrorCase.UnclosedStringLiteralEof,
                    string.Empty, GetCurrentText());
            BackPutBackingToken(backingErroneousStringLiteralToken);

            return;
        }

        if (Buffer[TokenEnd] != DoubleQuote)
        {
            // This is the start of a string literal
            TokenType = numberOfHashtags > 1
                ? SwiftTokens.SurroundedStringLiteralStartToken
                : SwiftTokens.StringLiteralStartToken;

            StringLiteralsTypesStacks.Push((SwiftTokens.StringLiteralStartIndex, TokenStart, TokenEnd));
            return;
        }

        // We have two double quotes. We need to check if it's a multi-line string literal or not.

        TokenEnd++;
        if (TokenEnd == EOFPos || Buffer[TokenEnd] != DoubleQuote)
        {
            TokenEnd--; // We go back to the first double quote

            TokenType = numberOfHashtags > 1
                ? SwiftTokens.SurroundedStringLiteralStartToken
                : SwiftTokens.StringLiteralStartToken;

            StringLiteralsTypesStacks.Push((SwiftTokens.StringLiteralStartIndex, TokenStart, TokenEnd));
            return;
        }

        LexStringLiteralStartThreeHashtags(numberOfHashtags);
    }

    // ReSharper disable once CognitiveComplexity
    private void LexStringLiteralStartThreeHashtags(int numberOfHashtags)
    {
        // We have three double quotes
        TokenEnd++;
        if (TokenEnd == EOFPos || Buffer[TokenEnd] != DoubleQuote)
        {
            if (SwiftLexerSettings.ThreeQuotesSettings.IsMultiLineStart())
            {
                TokenType = numberOfHashtags > 1
                    ? SwiftTokens.SurroundedMultiLineStringLiteralStartToken
                    : SwiftTokens.MultiLineStringLiteralStartToken;

                ThreeQuotesSettingInEffect = SwiftLexerSettings.ThreeQuotesSettings;
                StringLiteralsTypesStacks.Push((numberOfHashtags > 1
                    ? SwiftTokens.SurroundedMultiLineStringLiteralStartIndex
                    : SwiftTokens.MultiLineStringLiteralStartIndex, TokenStart, TokenEnd));

                MultilineStringLiteralTypesStacks.Push(StringLiteralsTypesStacks.Peek());
                IsInStringLiteral = numberOfHashtags > 1
                    ? StringLiteralPosition.InSurroundedMultiLineStringLiteral
                    : StringLiteralPosition.InMultiLineStringLiteral;
                return;
            }

            TokenEnd -= 2;

            TokenType = numberOfHashtags > 1
                ? SwiftTokens.SurroundedStringLiteralStartToken
                : SwiftTokens.StringLiteralStartToken;

            ThreeQuotesSettingInEffect = SwiftLexerSettings.ThreeQuotesSettings;
            StringLiteralsTypesStacks.Push((numberOfHashtags > 1
                ? SwiftTokens.SurroundedStringLiteralStartIndex
                : SwiftTokens.StringLiteralStartIndex, TokenStart, TokenEnd));

            IsInStringLiteral = numberOfHashtags > 1
                ? StringLiteralPosition.InSurroundedSimpleStringLiteral
                : StringLiteralPosition.InSimpleStringLiteral;
            return;
        }

        // We have four double quotes
        TokenEnd++;
        if (TokenEnd == EOFPos || Buffer[TokenEnd] != DoubleQuote)
        {
            if (SwiftLexerSettings.FourQuotesSettings is SwiftLexerSettings.FourQuotesSetting.DoubleSimpleStringLiteral)
            {
                TokenEnd -= 3;
                TokenType = numberOfHashtags > 1
                    ? SwiftTokens.SurroundedStringLiteralStartToken
                    : SwiftTokens.StringLiteralStartToken;

                StringLiteralsTypesStacks.Push((numberOfHashtags > 1
                    ? SwiftTokens.SurroundedStringLiteralStartIndex
                    : SwiftTokens.StringLiteralStartIndex, TokenStart, TokenEnd));

                IsInStringLiteral = numberOfHashtags > 1
                    ? StringLiteralPosition.InSurroundedSimpleStringLiteral
                    : StringLiteralPosition.InSimpleStringLiteral;
                return;
            }

            TokenEnd -= 1;
            TokenType = numberOfHashtags > 1
                ? SwiftTokens.SurroundedMultiLineStringLiteralStartToken
                : SwiftTokens.MultiLineStringLiteralStartToken;

            FourQuotesSettingInEffect = SwiftLexerSettings.FourQuotesSettings;
            StringLiteralsTypesStacks.Push((numberOfHashtags > 1
                ? SwiftTokens.SurroundedMultiLineStringLiteralStartIndex
                : SwiftTokens.MultiLineStringLiteralStartIndex, TokenStart, TokenEnd));

            MultilineStringLiteralTypesStacks.Push(StringLiteralsTypesStacks.Peek());
            IsInStringLiteral = numberOfHashtags > 1
                ? StringLiteralPosition.InSurroundedMultiLineStringLiteral
                : StringLiteralPosition.InMultiLineStringLiteral;
            return;
        }

        // We have five double quotes
        TokenEnd++;
        if (TokenEnd == EOFPos || Buffer[TokenEnd] != DoubleQuote)
        {
            if (SwiftLexerSettings.FiveQuotesSettings is SwiftLexerSettings.FiveQuotesSetting
                    .DoubleSimpleStringLiteralAndStringLiteralStart ||
                SwiftLexerSettings.FiveQuotesSettings.IsSimpleLiteralStart())
            {
                TokenEnd -= 4;
                TokenType = numberOfHashtags > 1
                    ? SwiftTokens.SurroundedStringLiteralStartToken
                    : SwiftTokens.StringLiteralStartToken;

                FiveQuotesSettingInEffect = SwiftLexerSettings.FiveQuotesSettings;
                StringLiteralsTypesStacks.Push((numberOfHashtags > 1
                    ? SwiftTokens.SurroundedStringLiteralStartIndex
                    : SwiftTokens.StringLiteralStartIndex, TokenStart, TokenEnd));

                IsInStringLiteral = numberOfHashtags > 1
                    ? StringLiteralPosition.InSurroundedSimpleStringLiteral
                    : StringLiteralPosition.InSimpleStringLiteral;
                return;
            }

            TokenEnd -= 2;
            TokenType = numberOfHashtags > 1
                ? SwiftTokens.SurroundedMultiLineStringLiteralStartToken
                : SwiftTokens.MultiLineStringLiteralStartToken;

            FiveQuotesSettingInEffect = SwiftLexerSettings.FiveQuotesSettings;
            StringLiteralsTypesStacks.Push((numberOfHashtags > 1
                ? SwiftTokens.SurroundedMultiLineStringLiteralStartIndex
                : SwiftTokens.MultiLineStringLiteralStartIndex, TokenStart, TokenEnd));

            MultilineStringLiteralTypesStacks.Push(StringLiteralsTypesStacks.Peek());
            IsInStringLiteral = numberOfHashtags > 1
                ? StringLiteralPosition.InSurroundedMultiLineStringLiteral
                : StringLiteralPosition.InMultiLineStringLiteral;
            return;
        }

        TokenEnd -= 3;

        TokenType = numberOfHashtags > 1
            ? SwiftTokens.SurroundedStringLiteralStartToken
            : SwiftTokens.StringLiteralStartToken;
        ThreeQuotesSettingInEffect = null;

        StringLiteralsTypesStacks.Push((SwiftTokens.SurroundedMultiLineStringLiteralStartIndex, TokenStart, TokenEnd));
        IsInStringLiteral = numberOfHashtags > 1
            ? StringLiteralPosition.InSurroundedMultiLineStringLiteral
            : StringLiteralPosition.InMultiLineStringLiteral;
    }

    private void LexContinuationOfThreeQuotesSystem()
    {
        if (ThreeQuotesSettingInEffect is 
            SwiftLexerSettings.ThreeQuotesSetting.SimpleStringAndStartOfOtherSimpleStringLineIfNoPair or 
            SwiftLexerSettings.ThreeQuotesSetting.SimpleStringAndStartOfOtherSimpleStringImmediateIfNoPair)
        {
            TokenStart = TokenEnd;
            TokenEnd++;

            if (TokenStart >= EOFPos)
            {
                return;
            }

            if (Buffer[TokenStart] !=
                DoubleQuote) // What we expect otherwise the buffer has changed but this itself should not happen
            {
                LexStringLiteralContent();
                return;
            }

            ThreeQuotesSettingInEffect = null;

            LexStringLiteralEnd();
            return;
        }

        IsInMultilinePairSearch.Push(TokenEnd);
        if (ThreeQuotesSettingInEffect is SwiftLexerSettings.ThreeQuotesSetting
                .MultilineStringLiteralStartToEndImmediateIfNoPair)
        {
            ThreeQuotesSettingInEffect = null;

            Advance(); // We are at the end so we return to regular lexing
            return;
        }

        if (ThreeQuotesSettingInEffect is SwiftLexerSettings.ThreeQuotesSetting.MultilineStringLiteralStartToEndOfFileIfNoPair)
        {
            ThreeQuotesSettingInEffect = null;
            LexMultiLineStringLiteralContent();
            return;
        }

        ThreeQuotesSettingInEffect = null;
        TokenStart = TokenEnd;
        MultilineStringLiteralTypesStacks.Push(StringLiteralsTypesStacks.Peek());

        LexStringLiteralContent(true);
    }

    // ReSharper disable once CognitiveComplexity
    private void LexContinuationOfFourQuotesSystem()
    {
        if (FourQuotesSettingInEffect is SwiftLexerSettings.FourQuotesSetting.DoubleSimpleStringLiteral)
        {
            TokenStart = TokenEnd;
            TokenEnd++;

            if (TokenStart >= EOFPos)
            {
                return;
            }

            if (Buffer[TokenStart] !=
                DoubleQuote) // We don't expect this.
                             // If this is true, the buffer has changed
                             // but this itself should not happen
            {
                LexStringLiteralContent();
                return;
            }

            FourQuotesSettingInEffect = null;

            LexStringLiteralEnd();
            return;
        }

        TokenStart = TokenEnd;

        if (TokenEnd >= EOFPos)
        {
            return;
        }

        if (Buffer[TokenEnd] != DoubleQuote) // We thought it was going to be a simple string literal
        {
            if (SwiftLexerSettings.ThreeQuotesSettings.IsMultiLineStart())
            {
                LexContinuationOfThreeQuotesSystem();
            }

            if (StringLiteralsTypesStacks.Count > 0 && StringLiteralsTypesStacks.Peek().token is
                SwiftTokens.SurroundedMultiLineStringLiteralStartIndex)
            {
                LexSurroundedMultiLineStringLiteralContent();
            }
            else
            {
                LexMultiLineStringLiteralContent();
            }

            return;
        }

        TokenEnd++;
        if (FourQuotesSettingInEffect is SwiftLexerSettings.FourQuotesSetting
                .MultilineStringLiteralStartAndStartOfOtherSimpleStringImmediateIfNoPair)
        {
            FourQuotesSettingInEffect = null;

            TokenType = SwiftTokens.StringLiteralStartToken;

            StringLiteralsTypesStacks.Push((TokenType.Index, TokenStart, TokenEnd));
            IsInSimplePairSearch.Push(TokenEnd - 1);

            return;
        }

        if (FourQuotesSettingInEffect is SwiftLexerSettings.FourQuotesSetting
                .MultilineStringLiteralStartToEndIfNoPair)
        {
            IsInMultilinePairSearch.Push(TokenEnd - 4);

            LexMultiLineStringLiteralContent();
            return;
        }

        FourQuotesSettingInEffect = null;
        MultilineStringLiteralTypesStacks.Push(StringLiteralsTypesStacks.Peek());

        LexStringLiteralContent(true);
    }

    // ReSharper disable once CognitiveComplexity
    private void LexContinuationOfFiveQuotesSystem()
    {
        if (Buffer[TokenEnd] != DoubleQuote)
        {
            if (PreviousTokenType is SurroundedStringLiteralStartToken)
            {
                LexSurroundedStringLiteralContent();
            }
            else
            {
                LexStringLiteralContent();
            }

            return;
        }

        if (!SwiftLexerSettings.FiveQuotesSettings.IsMultiLineStart())
        {
            TokenStart = TokenEnd;
            TokenEnd++;

            TokenType = PreviousTokenType is SurroundedStringLiteralStartToken
                ? SwiftTokens.SurroundedStringLiteralEndToken
                : SwiftTokens.StringLiteralEndToken;

            StringLiteralsTypesStacks.Pop();
            IsInStringLiteral = StringLiteralPosition.OutOfStringLiteral;

            if (TokenEnd + 2 < Buffer[TokenEnd] || Buffer[TokenEnd] != DoubleQuote)
            {
                FiveQuotesSettingInEffect = null;
                return;
            }

            ThreeQuotesSettingInEffect = FiveQuotesSettingInEffect switch
            {
                SwiftLexerSettings.FiveQuotesSetting.DoubleSimpleStringLiteralAndStringLiteralStart => null,
                SwiftLexerSettings.FiveQuotesSetting.SimpleStringMultilineStringLiteralStartImmediateIfNoPair
                    => SwiftLexerSettings.ThreeQuotesSetting.MultilineStringLiteralStartToEndImmediateIfNoPair,
                SwiftLexerSettings.FiveQuotesSetting.SimpleStringMultilineStringLiteralStartLineIfNoPair
                    => SwiftLexerSettings.ThreeQuotesSetting.MultilineStringLiteralStartToEndLineIfNoPair,
                SwiftLexerSettings.FiveQuotesSetting.SimpleStringMultilineStringLiteralStartToEndIfNoPair
                    => SwiftLexerSettings.ThreeQuotesSetting.MultilineStringLiteralStartToEndOfFileIfNoPair,
                _ => throw new ArgumentException("It should be impossible to reach this point")
            };

            FiveQuotesSettingInEffect = null;
            return;
        }

        TokenEnd++;
        MultilineStringLiteralTypesStacks.Push(StringLiteralsTypesStacks.Peek());
        IsInMultilinePairSearch.Push(TokenEnd - 4);
        if (FiveQuotesSettingInEffect is SwiftLexerSettings.FiveQuotesSetting.MultilineStringLiteralStartToEndIfNoPair)
        {
            FiveQuotesSettingInEffect = null;
            IsInStringLiteral = StringLiteralPosition.OutOfStringLiteral;
            Advance();
            return;
        }

        if (FiveQuotesSettingInEffect is SwiftLexerSettings.FiveQuotesSetting
                .MultilineStringLiteralStartLineIfNoPair)
        {
            FiveQuotesSettingInEffect = null;
            if (PreviousTokenType is SurroundedMultiLineStringLiteralStartToken)
            {
                LexSurroundedStringLiteralContent(true);
                IsInStringLiteral = StringLiteralPosition.OutOfStringLiteral;
                return;
            }

            LexStringLiteralContent(true);
            if (TokenEnd < EOFPos && Buffer[TokenEnd] == Backslash)
            {
                IsInStringLiteral = StringLiteralPosition.InMultiLineStringLiteral;
            }
            else
            {
                IsInStringLiteral = StringLiteralPosition.OutOfStringLiteral;
            }

            return;
        }

        if (PreviousTokenType is SurroundedMultiLineStringLiteralStartToken)
        {
            LexSurroundedMultiLineStringLiteralContent();
        }
        else
        {
            LexMultiLineStringLiteralContent();
        }
    }

    private void LexStringLiteralContent(bool isPartOfMultiLineActually = false)
    {
        TokenStart = TokenEnd;
        while (TokenEnd < EOFPos && Buffer[TokenEnd] != Backslash && Buffer[TokenEnd] != DoubleQuote
               && Buffer[TokenEnd].IsNewLine())
        {
            TokenEnd++;
        }

        TokenType = isPartOfMultiLineActually
            ? SwiftTokens.MultiLineStringLiteralContentToken
            : SwiftTokens.StringLiteralContentToken;
    }

    private void LexSurroundedStringLiteralContent(bool isPartOfMultiLineActually = false)
    {
        TokenStart = TokenEnd;
        while (TokenEnd < EOFPos && Buffer[TokenEnd] != DoubleQuote && Buffer[TokenEnd].IsNewLine())
        {
            TokenEnd++;
        }

        TokenType = isPartOfMultiLineActually
            ? SwiftTokens.SurroundedStringLiteralContentToken
            : SwiftTokens.SurroundedMultiLineStringLiteralContentToken;
    }

    private void LexMultiLineStringLiteralContent()
    {
        TokenStart = TokenEnd;
        while (TokenEnd + 2 < EOFPos && Buffer[TokenEnd] != Backslash && Buffer[TokenEnd] != DoubleQuote &&
               Buffer[TokenEnd + 1] != DoubleQuote
               && Buffer[TokenEnd + 2] != DoubleQuote)
        {
            while (TokenEnd < EOFPos && Buffer[TokenEnd] != Backslash && Buffer[TokenEnd] != DoubleQuote)
            {
                TokenEnd++;
            }
        }
    }

    private void LexSurroundedMultiLineStringLiteralContent()
    {
        TokenStart = TokenEnd;
        while (TokenEnd + 2 < EOFPos && Buffer[TokenEnd] != DoubleQuote && Buffer[TokenEnd + 1] != DoubleQuote
               && Buffer[TokenEnd + 2] != DoubleQuote)
        {
            while (TokenEnd < EOFPos && Buffer[TokenEnd] != DoubleQuote)
            {
                TokenEnd++;
            }
        }
    }

    private void LexStringLiteralEnd()
    { }

    private void LexEscape()
    {
        TokenStart = TokenEnd++;
        while (TokenEnd < EOFPos && Buffer[TokenEnd] == Hashtag)
        {
            TokenEnd++;
        }

        if (TokenEnd == EOFPos)
        {
            TokenType = SwiftTokens.UnmatchedEscapeSequenceToken;

            BackingUnmatchedEscapeSequenceToken backingUnmatchedEscapeSequenceToken =
                new(string.Empty,
                    TokenStart == TokenEnd + 1
                        ? BackingUnmatchedEscapeSequenceToken.ErrorCase.UnmatchedEscapeSequenceEofImmediate
                        : BackingUnmatchedEscapeSequenceToken.ErrorCase.UnmatchedEscapeSequenceEofAfterHashtags);
            BackPutBackingToken(backingUnmatchedEscapeSequenceToken);
            return;
        }

        char followupCharacter = Buffer[TokenEnd];
        if (followupCharacter is '0' or Backslash or 't' or 'n' or 'r' or DoubleQuote or SingleQuote)
        {
            TokenEnd++;
            TokenType = SwiftTokens.StringEscapeSequenceToken;
            return;
        }

        if (followupCharacter.IsWhitespace())
        {
            LexEscapedNewLine();
            return;
        }

        if (followupCharacter is OpenParenthesis)
        {
            LexInterpolationStart();
            return;
        }

        if (followupCharacter is 'u')
        {
            LexUnicodeEscape();
            return;
        }

        TokenType = SwiftTokens.UnmatchedEscapeSequenceToken;
        BackingUnmatchedEscapeSequenceToken backingTokenEnd = new(string.Empty,
            TokenStart + 1 < EOFPos && Buffer[TokenStart] is Hashtag
                ? BackingUnmatchedEscapeSequenceToken.ErrorCase.UnmatchedEscapeSequenceBadCharImmediate
                : BackingUnmatchedEscapeSequenceToken.ErrorCase.UnmatchedEscapeSequenceBadCharAfterHashtags);
        BackPutBackingToken(backingTokenEnd);
    }

    private void LexEscapedNewLine()
    {
        int backupTokenEnd = TokenEnd;
        while (TokenEnd < EOFPos && Buffer[TokenEnd].IsWhitespace())
        {
            TokenEnd++;
        }

        if (TokenEnd != EOFPos && Buffer[TokenEnd].IsNewLine())
            return;

        TokenType = SwiftTokens.UnmatchedEscapeSequenceToken;

        BackingUnmatchedEscapeSequenceToken backingToken;
        if (TokenEnd == EOFPos)
        {
            backingToken = new BackingUnmatchedEscapeSequenceToken(string.Empty,
                BackingUnmatchedEscapeSequenceToken.ErrorCase.UnmatchedEscapeSequenceWsNoNewLineEof);
        }
        else if (Buffer[TokenEnd] is OpenParenthesis)
        {
            backingToken = new BackingUnmatchedEscapeSequenceToken(string.Empty,
                BackingUnmatchedEscapeSequenceToken.ErrorCase
                    .UnmatchedEscapeSequenceWsNoNewLineInterpolationChar);
        }
        else if (Buffer[TokenEnd] is '0' or Backslash or 't' or 'n' or 'r' or '"' or '\'' or 'u')
        {
            backingToken = new BackingUnmatchedEscapeSequenceToken(string.Empty,
                BackingUnmatchedEscapeSequenceToken.ErrorCase.UnmatchedEscapeSequenceWsNoNewLineEscapeChar);
        }
        else
        {
            backingToken = new BackingUnmatchedEscapeSequenceToken(string.Empty,
                BackingUnmatchedEscapeSequenceToken.ErrorCase.UnmatchedEscapeSequenceWsNoNewLineBadChar);
        }

        BackPutBackingToken(backingToken);
        TokenEnd = backupTokenEnd;
    }

    private void LexUnicodeEscape()
    {
        TokenEnd++;
        if (TokenEnd == EOFPos || Buffer[TokenEnd] != OpenCurlyBrace)
        {
            TokenType = SwiftTokens.UnmatchedEscapeSequenceToken;

            BackingUnmatchedEscapeSequenceToken.ErrorCase errorCase;
            if (TokenEnd == EOFPos)
            {
                errorCase = BackingUnmatchedEscapeSequenceToken.ErrorCase.UnmatchedUnicodeEscapeSequenceEofImmediate;
            }
            else if (Buffer[TokenEnd] == OpenParenthesis)
            {
                errorCase = BackingUnmatchedEscapeSequenceToken.ErrorCase
                    .UnmatchedUnicodeEscapeSequenceInterpolationCharImmediate;
            }
            else
            {
                errorCase = BackingUnmatchedEscapeSequenceToken.ErrorCase
                    .UnmatchedUnicodeEscapeSequenceBadCharImmediate;
            }

            BackingUnmatchedEscapeSequenceToken backingToken = new(string.Empty, errorCase);
            BackPutBackingToken(backingToken);
            return;
        }

        TokenEnd++;
        if (TokenEnd == EOFPos || !Buffer[TokenEnd].IsHexadecimalLiteralCharacter())
        {
            TokenType = SwiftTokens.UnmatchedEscapeSequenceToken;

            BackingUnmatchedEscapeSequenceToken backingToken = new(string.Empty, TokenEnd == EOFPos
                ? BackingUnmatchedEscapeSequenceToken.ErrorCase.UnmatchedUnicodeEscapeSequenceEofAfterOpeningBrace
                : BackingUnmatchedEscapeSequenceToken.ErrorCase.UnmatchedUnicodeEscapeSequenceBadCharAfterOpeningBrace);
            BackPutBackingToken(backingToken);
            return;
        }

        LexUnicodeEscapeCore();
    }

    private void LexUnicodeEscapeCore()
    {
        while (TokenEnd < EOFPos && Buffer[TokenEnd].IsHexadecimalLiteralCharacter())
        {
            TokenEnd++;
        }

        if (TokenEnd == EOFPos)
        {
            TokenType = SwiftTokens.UnmatchedEscapeSequenceToken;
            BackingUnmatchedEscapeSequenceToken backingToken = new(string.Empty,
                BackingUnmatchedEscapeSequenceToken.ErrorCase.UnmatchedUnicodeEscapeSequenceNoClosingBraceEof);

            BackPutBackingToken(backingToken);
            return;
        }

        if (Buffer[TokenEnd] == ClosingCurlyBrace)
        {
            TokenType = SwiftTokens.StringEscapeSequenceToken;
            return;
        }

        if (Buffer[TokenEnd].IsNewLine())
        {
            TokenType = SwiftTokens.UnmatchedEscapeSequenceToken;
            BackingUnmatchedEscapeSequenceToken backingToken = new(string.Empty,
                IsInStringLiteral is StringLiteralPosition.InMultiLineStringLiteral
                    or StringLiteralPosition.InSurroundedMultiLineStringLiteral
                    ? BackingUnmatchedEscapeSequenceToken.ErrorCase
                        .UnmatchedUnicodeEscapeSequenceNoClosingBraceNewLineMultiLine
                    : BackingUnmatchedEscapeSequenceToken.ErrorCase
                        .UnmatchedUnicodeEscapeSequenceNoClosingBraceNewLine);

            BackPutBackingToken(backingToken);
            return;
        }

        if (SwiftLexerSettings.UnicodeSequenceInterruptionSettings is SwiftLexerSettings.UnicodeSequenceInterruption
                .Continue)
        {
            LexUnicodeEscapeCore();
            if (ReferenceEquals(TokenType, SwiftTokens.UnmatchedEscapeSequenceToken)) return;
        }

        TokenType = SwiftTokens.UnmatchedEscapeSequenceToken;
        BackingUnmatchedEscapeSequenceToken backingTokenInString = new
        (string.Empty,
            BackingUnmatchedEscapeSequenceToken.ErrorCase.UnmatchedUnicodeEscapeSequenceNoClosingBraceBadChar);
        BackPutBackingToken(backingTokenInString);
    }

    private void LexInterpolationStart()
    {
        TokenType = SwiftTokens.StringInterpolationStartToken;
        IsInStringLiteral = StringLiteralPosition.OutOfStringLiteral;
    }

    private void LexInterpolationEnd()
    {
        TokenType = SwiftTokens.StringInterpolationEndToken;
        
    }
}
