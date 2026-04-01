using System;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Errors;

public class UnmatchedEscapeSequenceToken() : ErroneousToken(SwiftTokens.UnmatchedEscapeSequenceId, SwiftTokens.UnmatchedEscapeSequenceIndex);

public class BackingUnmatchedEscapeSequenceToken(string value, BackingUnmatchedEscapeSequenceToken.ErrorCase errorCase)
    : BackingErroneousToken(value, errorCase.ToMessage(), SwiftTokens.UnmatchedEscapeSequenceIndex)
{
    public const string UnmatchedEscapeSequenceEofError = "The escape sequences requires a character or interpolation " +
                                                           "but the end of the file was reached";

    public const string UnmatchedEscapeSequenceWsNoNewLineEofError =
        "An escape sequence supports escaping a new line after some whitespace." +
        "The end of the file was reached.";

    public const string UnmatchedEscapeSequenceWsNoNewLineBadCharError =
        "An escape sequence supports escaping a new line after some whitespace." +
        "The character that followed is not a new line and is thus invalid.\n" +
        "It is not a valid escape character nor a valid string interpolation character.";
    
    public const string UnmatchedEscapeSequenceWsNoNewLineInterpolationCharError =
        "An escape sequence supports escaping a new line after some whitespace." +
        "The character that followed is not a new line and is thus invalid.\n" +
        "It is a valid interpolation character but such characters must follow the backslash " +
        "immediately with no whitespace";
    
    public const string UnmatchedEscapeSequenceWsNoNewLineEscapeCharError =
        "An escape sequence supports escaping a new line after some whitespace." +
        "The character that followed is not a new line and is thus invalid.\n" +
        "It is a valid simple escape character but such characters must follow the backslash " +
        "after possibly '#' symbols but with no whitespace";

    public const string UnmatchedEscapeSequenceBadCharacterImmediateError =
        "An escape sequence started with a backslash but was immediately followed by an invalid character. " +
        "Escape sequences must begin with a valid escape character or interpolation marker. " +
        "A new line immediately following an optional sequence of whitespace immediately following the backslash is allowed.";

    public const string UnmatchedEscapeSequenceBadCharacterAfterHashtagsError =
        "An escape sequence that started with one or more '#' symbols was followed by an invalid character. " +
        "After '#' symbols, only valid escape characters or interpolation markers are permitted, and no other characters are allowed. " +
        "A new line immediately following an optional sequence of whitespace immediately following the backslash is allowed.";

    public const string UnmatchedUnicodeEscapeSequenceEofImmediateError =
        "A unicode escape sequence started but after the opening \\u, no open curly brace was present.\n" +
        "The file ended.";

    public const string UnmatchedUnicodeEscapeSequenceInterpolationCharImmediateError =
        "A unicode escape sequence started but after the opening \\u, no open curly brace was present.\n" +
        "An interpolation start character ('(') was present however which isn't valid but you may have wanted to write \\( instead.";

    public const string UnmatchedUnicodeEscapeSequenceBadCharImmediateError =
        "A unicode escape sequence started but after the opening \\u, no open curly brace was present.\n" +
        "Another character was present.";

    public const string UnmatchedUnicodeEscapeSequenceEofAfterOpeningBraceError =
        "A unicode escape sequence started but after the opening \\u{, no hexadecimal digits where present.\n" +
        "The file ended.";

    public const string UnmatchedUnicodeEscapeSequenceBadCharAfterOpeningBraceError =
        "A unicode escape sequence started but after the opening \\u{, no hexadecimal digits where present.\n" +
        "Another character was present. It must be a hexadecimal digit, between 1 and 8.";

    public const string UnmatchedUnicodeEscapeSequenceNoClosingBraceEofError =
        "While in a unicode escape sequence, the end of the file was reached without the sequence being closed";
    
    public const string UnmatchedUnicodeEscapeSequenceNoClosingBraceNewLineError =
        "While in a unicode escape sequence, the end of the line was reached without the sequence being closed";
    
    public const string UnmatchedUnicodeEscapeSequenceNoClosingBraceNewLineMultiLineError =
        "While in a unicode escape sequence, the end of the line was reached without the sequence being closed.\n" +
        "Note that for unicode escapes in multiline strings, the unicode escape must entierely on the same line.";
    
    public const string UnmatchedUnicodeEscapeSequenceNoClosingBraceBadChar =
        "While in a unicode escape sequence, a non hexadecimal character was come accross without the sequence being closed";
    
    public enum ErrorCase
    {
        UnmatchedEscapeSequenceEofImmediate,
        UnmatchedEscapeSequenceEofAfterHashtags,
        UnmatchedEscapeSequenceWsNoNewLineEof,
        UnmatchedEscapeSequenceWsNoNewLineBadChar,
        UnmatchedEscapeSequenceWsNoNewLineInterpolationChar,
        UnmatchedEscapeSequenceWsNoNewLineEscapeChar,
        UnmatchedEscapeSequenceBadCharImmediate,
        UnmatchedEscapeSequenceBadCharAfterHashtags,
        UnmatchedUnicodeEscapeSequenceEofImmediate,
        UnmatchedUnicodeEscapeSequenceInterpolationCharImmediate,
        UnmatchedUnicodeEscapeSequenceBadCharImmediate,
        UnmatchedUnicodeEscapeSequenceEofAfterOpeningBrace,
        UnmatchedUnicodeEscapeSequenceBadCharAfterOpeningBrace,
        UnmatchedUnicodeEscapeSequenceNoClosingBraceEof,
        UnmatchedUnicodeEscapeSequenceNoClosingBraceNewLine,
        UnmatchedUnicodeEscapeSequenceNoClosingBraceNewLineMultiLine,
        UnmatchedUnicodeEscapeSequenceNoClosingBraceBadChar,
    }

    public ErrorCase Problem { get; } = errorCase;
}

public static class UnmatchedEscapeSequenceTokenProblemExtensions
{
    public static string ToMessage(this BackingUnmatchedEscapeSequenceToken.ErrorCase errorCase)
    {
        return errorCase switch
        {
            BackingUnmatchedEscapeSequenceToken.ErrorCase.UnmatchedEscapeSequenceEofImmediate => BackingUnmatchedEscapeSequenceToken.UnmatchedEscapeSequenceEofError,
            BackingUnmatchedEscapeSequenceToken.ErrorCase.UnmatchedEscapeSequenceEofAfterHashtags => BackingUnmatchedEscapeSequenceToken.UnmatchedEscapeSequenceEofError,
            BackingUnmatchedEscapeSequenceToken.ErrorCase.UnmatchedEscapeSequenceWsNoNewLineEof => BackingUnmatchedEscapeSequenceToken.UnmatchedEscapeSequenceWsNoNewLineEofError,
            BackingUnmatchedEscapeSequenceToken.ErrorCase.UnmatchedEscapeSequenceWsNoNewLineBadChar => BackingUnmatchedEscapeSequenceToken.UnmatchedEscapeSequenceWsNoNewLineBadCharError,
            BackingUnmatchedEscapeSequenceToken.ErrorCase.UnmatchedEscapeSequenceWsNoNewLineInterpolationChar => BackingUnmatchedEscapeSequenceToken.UnmatchedEscapeSequenceWsNoNewLineInterpolationCharError,
            BackingUnmatchedEscapeSequenceToken.ErrorCase.UnmatchedEscapeSequenceWsNoNewLineEscapeChar => BackingUnmatchedEscapeSequenceToken.UnmatchedEscapeSequenceWsNoNewLineEscapeCharError,
            BackingUnmatchedEscapeSequenceToken.ErrorCase.UnmatchedEscapeSequenceBadCharImmediate => BackingUnmatchedEscapeSequenceToken.UnmatchedEscapeSequenceBadCharacterImmediateError,
            BackingUnmatchedEscapeSequenceToken.ErrorCase.UnmatchedEscapeSequenceBadCharAfterHashtags => BackingUnmatchedEscapeSequenceToken.UnmatchedEscapeSequenceBadCharacterAfterHashtagsError,
            BackingUnmatchedEscapeSequenceToken.ErrorCase.UnmatchedUnicodeEscapeSequenceEofImmediate => BackingUnmatchedEscapeSequenceToken.UnmatchedUnicodeEscapeSequenceEofImmediateError,
            BackingUnmatchedEscapeSequenceToken.ErrorCase.UnmatchedUnicodeEscapeSequenceInterpolationCharImmediate => BackingUnmatchedEscapeSequenceToken.UnmatchedUnicodeEscapeSequenceInterpolationCharImmediateError,
            BackingUnmatchedEscapeSequenceToken.ErrorCase.UnmatchedUnicodeEscapeSequenceBadCharImmediate => BackingUnmatchedEscapeSequenceToken.UnmatchedUnicodeEscapeSequenceBadCharImmediateError,
            BackingUnmatchedEscapeSequenceToken.ErrorCase.UnmatchedUnicodeEscapeSequenceEofAfterOpeningBrace => BackingUnmatchedEscapeSequenceToken.UnmatchedUnicodeEscapeSequenceEofAfterOpeningBraceError,
            BackingUnmatchedEscapeSequenceToken.ErrorCase.UnmatchedUnicodeEscapeSequenceBadCharAfterOpeningBrace => BackingUnmatchedEscapeSequenceToken.UnmatchedUnicodeEscapeSequenceBadCharAfterOpeningBraceError,
            BackingUnmatchedEscapeSequenceToken.ErrorCase.UnmatchedUnicodeEscapeSequenceNoClosingBraceEof => BackingUnmatchedEscapeSequenceToken.UnmatchedUnicodeEscapeSequenceNoClosingBraceEofError,
            BackingUnmatchedEscapeSequenceToken.ErrorCase.UnmatchedUnicodeEscapeSequenceNoClosingBraceNewLine => BackingUnmatchedEscapeSequenceToken.UnmatchedUnicodeEscapeSequenceNoClosingBraceNewLineError,
            BackingUnmatchedEscapeSequenceToken.ErrorCase.UnmatchedUnicodeEscapeSequenceNoClosingBraceNewLineMultiLine => BackingUnmatchedEscapeSequenceToken.UnmatchedUnicodeEscapeSequenceNoClosingBraceNewLineMultiLineError,
            BackingUnmatchedEscapeSequenceToken.ErrorCase.UnmatchedUnicodeEscapeSequenceNoClosingBraceBadChar => BackingUnmatchedEscapeSequenceToken.UnmatchedUnicodeEscapeSequenceNoClosingBraceBadChar,
            _ => throw new ArgumentOutOfRangeException(nameof(errorCase), errorCase, null)
        };
    }
}