using System;

namespace ReSharperPlugin.Swift.Language.Parser.Lexer.Tokens.Errors;

public class UnmatchedHashtagToken() : ErroneousToken(SwiftTokens.UnmatchedHashtagId, SwiftTokens.UnmatchedHashtagIndex);

public class BackingUnmatchedHashtagToken(string value, BackingUnmatchedHashtagToken.ErrorCase errorCase)
    : BackingErroneousToken(value, errorCase.ToMessage(), SwiftTokens.UnmatchedHashtagIndex)
{
    public const string UnexpectedHashtagEofError = "The hashtag requires a reserved keyword starting " +
                                                    "with # or a string literal but the end of the file " +
                                                    "was reached.";

    public const string UnmatchedHashtagNonKeywordAndStringLiteralError =
        "The hashtag requires a reserved keyword starting " +
        "with # or a string literal but the following character sequence " +
        "was neither a reserved keyword nor a string literal.";

    public const string UnmatchedEndingStringLiteralHashtagError =
        "You did not include one hashtag right before the string literal's opening quote. " +
        "You must include the same number of hashtags as you included before the string literal's opening quote.";

    public const string UnmatchedEndingStringLiteralHashtagsError =
        "You did not include the same number of hashtags as you included before the string literal's opening quote. " +
        "You must include the same number of hashtags as you included before the string literal's opening quote.";

    public const string UnmatchedHashtagReservedKeywordError =
        "The hashtag does not have a string literal following it.\n" +
        "Therefore it must be a reserved keyword starting with #.\n" +
        "The following character sequence was neither a reserved keyword nor a string literal.";

    public const string UnmatchedHashtagLiteralStringError =
        "There are multiple hashtags in a row therefore these " +
        "hashtags must be followed by a string literal.\n" +
        "It is not the case.";
    
    public enum ErrorCase
    {
        UnmatchedHashtagEof,
        UnmatchedHashtagNonKeywordAndStringLiteral,
        UnmatchedEndingStringLiteralHashtag,
        UnmatchedEndingStringLiteralHashtags,
        UnmatchedHashtagReservedKeyword,
        UnmatchedHashtagLiteralString
    }
}

public static class UnmatchedHashtagTokenProblemExtensions
{
    public static string ToMessage(this BackingUnmatchedHashtagToken.ErrorCase errorCase)
    {
        return errorCase switch
        {
            BackingUnmatchedHashtagToken.ErrorCase.UnmatchedHashtagEof => 
                BackingUnmatchedHashtagToken.UnexpectedHashtagEofError,
            BackingUnmatchedHashtagToken.ErrorCase.UnmatchedHashtagNonKeywordAndStringLiteral => 
                BackingUnmatchedHashtagToken.UnmatchedHashtagNonKeywordAndStringLiteralError,
            BackingUnmatchedHashtagToken.ErrorCase.UnmatchedEndingStringLiteralHashtag =>
                BackingUnmatchedHashtagToken.UnmatchedEndingStringLiteralHashtagError,
            BackingUnmatchedHashtagToken.ErrorCase.UnmatchedEndingStringLiteralHashtags =>
                BackingUnmatchedHashtagToken.UnmatchedEndingStringLiteralHashtagsError,
            BackingUnmatchedHashtagToken.ErrorCase.UnmatchedHashtagReservedKeyword =>
                BackingUnmatchedHashtagToken.UnmatchedHashtagReservedKeywordError,
            BackingUnmatchedHashtagToken.ErrorCase.UnmatchedHashtagLiteralString =>
                BackingUnmatchedHashtagToken.UnmatchedHashtagLiteralStringError,
            _ => throw new ArgumentOutOfRangeException(nameof(errorCase), errorCase, null)
        };
    }
}