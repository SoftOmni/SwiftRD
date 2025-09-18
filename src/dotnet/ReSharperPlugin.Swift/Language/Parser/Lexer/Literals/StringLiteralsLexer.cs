using System;
using ReSharperPlugin.Swift.Language.Parser.Lexer.Tokens;
using ReSharperPlugin.Swift.Language.Parser.Lexer.Tokens.Errors;
using ReSharperPlugin.Swift.Language.Parser.Lexer.Tokens.Literals;

namespace ReSharperPlugin.Swift.Language.Parser.Lexer;

public partial class SwiftLexer
{
    public const char DoubleQuote = '"';

    public const char Backslash = '\\';

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
            TokenType = SwiftTokens.ErroneousStringLiteralToken;

            BackingErroneousStringLiteralToken backingErroneousStringLiteralToken = numberOfHashtags > 1
                ? new BackingErroneousStringLiteralToken(BackingErroneousStringLiteralToken.ErrorCase
                    .UnclosedStringLiteralWithHashtags, string.Empty, GetCurrentText())
                : new BackingErroneousStringLiteralToken(
                    BackingErroneousStringLiteralToken.ErrorCase.UnclosedStringLiteral,
                    string.Empty, GetCurrentText());
            BackPutBackingToken(backingErroneousStringLiteralToken);
            return;
        }

        // We have two double quotes. We need to check if it's a multi-line string literal or not.

        TokenEnd++;
        if (TokenEnd == EOFPos || Buffer[TokenEnd] != DoubleQuote)
        {
            TokenEnd--; // We go back to the first double quote
            TokenEnd--;

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
        if (TokenEnd == EOFPos || Buffer[TokenEnd] == DoubleQuote)
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
        if (TokenEnd == EOFPos || Buffer[TokenEnd] == DoubleQuote)
        {
            if (SwiftLexerSettings.FiveQuotesStrings is SwiftLexerSettings.FiveQuotesSetting
                    .DoubleSimpleStringLiteralAndStringLiteralStart ||
                SwiftLexerSettings.FiveQuotesStrings.IsSimpleLiteralStart())
            {
                TokenEnd -= 4;
                TokenType = numberOfHashtags > 1
                    ? SwiftTokens.SurroundedStringLiteralStartToken
                    : SwiftTokens.StringLiteralStartToken;

                FiveQuotesSettingInEffect = SwiftLexerSettings.FiveQuotesStrings;
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

            FiveQuotesSettingInEffect = SwiftLexerSettings.FiveQuotesStrings;
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

    private bool LexContinuationOfThreeQuotesSystem()
    {
        if (ThreeQuotesSettingInEffect is SwiftLexerSettings.ThreeQuotesSetting
                .SimpleStringAndStartOfOtherSimpleStringLineIfNoPair or SwiftLexerSettings.ThreeQuotesSetting
                .SimpleStringAndStartOfOtherSimpleStringImmediateIfNoPair)
        {
            TokenStart = TokenEnd;
            TokenEnd++;

            if (TokenStart >= EOFPos)
            {
                return false;
            }

            if (Buffer[TokenStart] !=
                DoubleQuote) // What we expect otherwise the buffer has changed but this itself should not happen
            {
                LexStringLiteralContent();
                return true;
            }

            ThreeQuotesSettingInEffect = null;

            LexStringLiteralEnd();
            return true;
        }

        IsInMultilinePairSearch.Push(TokenEnd);
        if (ThreeQuotesSettingInEffect is SwiftLexerSettings.ThreeQuotesSetting
                .MultilineStringLiteralStartToEndImmediateIfNoPair)
        {
            ThreeQuotesSettingInEffect = null;

            Advance(); // We are at the end so we return to regular lexing
            return false;
        }

        if (ThreeQuotesSettingInEffect is SwiftLexerSettings.ThreeQuotesSetting.MultilineStringLiteralStart)
        {
            ThreeQuotesSettingInEffect = null;
            LexMultiLineStringLiteralContent();
            return true;
        }

        ThreeQuotesSettingInEffect = null;
        TokenStart = TokenEnd;
        MultilineStringLiteralTypesStacks.Push(StringLiteralsTypesStacks.Peek());

        LexStringLiteralContent(true);
        return true;
    }

    private bool LexContinuationOfFourQuotesSystem()
    {
        if (FourQuotesSettingInEffect is SwiftLexerSettings.FourQuotesSetting.DoubleSimpleStringLiteral)
        {
            TokenStart = TokenEnd;
            TokenEnd++;

            if (TokenStart >= EOFPos)
            {
                return false;
            }

            if (Buffer[TokenStart] !=
                DoubleQuote) // What we expect otherwise the buffer has changed but this itself should not happen
            {
                LexStringLiteralContent();
                return true;
            }

            FourQuotesSettingInEffect = null;

            LexStringLiteralEnd();
            return true;
        }

        TokenStart = TokenEnd;

        if (TokenEnd >= EOFPos)
        {
            return false;
        }

        if (Buffer[TokenEnd] != DoubleQuote) // We thought it was going to be a simple string literal
        {
            if (SwiftLexerSettings.ThreeQuotesSettings.IsMultiLineStart())
            {
                return LexContinuationOfThreeQuotesSystem();
            }

            if (StringLiteralsTypesStacks.Count > 0 && StringLiteralsTypesStacks.Peek().token ==
                SwiftTokens.SurroundedMultiLineStringLiteralStartIndex)
            {
                LexSurroundedMultiLineStringLiteralContent();
            }
            else
            {
                LexMultiLineStringLiteralContent();
            }

            return true;
        }

        TokenEnd++;
        if (FourQuotesSettingInEffect is SwiftLexerSettings.FourQuotesSetting
                .MultilineStringLiteralStartAndStartOfOtherSimpleStringImmediateIfNoPair)
        {
            FourQuotesSettingInEffect = null;

            TokenType = SwiftTokens.StringLiteralStartToken;

            StringLiteralsTypesStacks.Push((TokenType.Index, TokenStart, TokenEnd));
            IsInSimplePairSearch.Push(TokenEnd - 1);

            return false;
        }

        if (FourQuotesSettingInEffect is SwiftLexerSettings.FourQuotesSetting
                .MultilineStringLiteralStartToEndIfNoPair)
        {
            IsInMultilinePairSearch.Push(TokenEnd - 4);

            LexMultiLineStringLiteralContent();
            return true;
        }

        FourQuotesSettingInEffect = null;
        MultilineStringLiteralTypesStacks.Push(StringLiteralsTypesStacks.Peek());

        LexStringLiteralContent(true);
        return true;
    }

    private bool LexContinuationOfFiveQuotesSystem()
    {
        throw new NotImplementedException();
    }

    private void LexStringLiteralContent(bool isPartOfMultiLineActually = false)
    {
        TokenStart = TokenEnd;
        while (TokenEnd < EOFPos && Buffer[TokenEnd] != Backslash && Buffer[TokenEnd] != DoubleQuote
               && Buffer[TokenEnd].IsNewLine())
        {
            TokenEnd++;
        }

        string content = GetCurrentText();
        BackingStringLiteralContent backingToken;
        if (!isPartOfMultiLineActually)
        {
            TokenType = SwiftTokens.StringLiteralContentToken;
            backingToken = new BackingStringLiteralContent(content, content);
        }
        else
        {
            TokenType = SwiftTokens.MultiLineStringLiteralContentToken;
            backingToken = new MultiLineStringLiteralContentBackingLiteralToken(content, content, 0);
        }

        BackPutBackingToken(backingToken);
    }

    private void LexSurroundedStringLiteralContent()
    {
        TokenStart = TokenEnd;
        while (TokenEnd < EOFPos && Buffer[TokenEnd] != DoubleQuote && Buffer[TokenEnd].IsNewLine())
        {
            TokenEnd++;
        }

        string content = GetCurrentText();
        TokenType = SwiftTokens.SurroundedStringLiteralContentToken;
        BackingStringLiteralContent backingStringLiteralContent = new(content, content);
        
        BackPutBackingToken(backingStringLiteralContent);
    }

    private string LexMultiLineStringLiteralContent()
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

        string content = GetCurrentText();
        return ProcessMultiStringLiteral(content, TokenEnd == EOFPos || Buffer[TokenEnd] == Backslash);
    }

    private string LexSurroundedMultiLineStringLiteralContent()
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

        string content = GetCurrentText();
        return ProcessMultiStringLiteral(content);
    }

    private string ProcessMultiStringLiteral(string content, bool isStoppedByEscape = false)
    {
        if (!isStoppedByEscape)
        {
            return content;
        }

        return "";
    }

    private void LexStringLiteralEnd()
    { }

    private void LexEscape()
    { }

    private void LexInterpolationStart()
    { }

    private void LexInterpolationEnd()
    { }
}