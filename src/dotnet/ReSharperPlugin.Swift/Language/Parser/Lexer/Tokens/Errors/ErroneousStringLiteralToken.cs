using System;
using String = ReSharperPlugin.Swift.Language.Semantics.Type.BuiltinTypes.String;

namespace ReSharperPlugin.Swift.Language.Parser.Lexer.Tokens.Errors;

public class ErroneousStringLiteralToken()
    : ErroneousSwiftLiteral(SwiftTokens.ErroneousStringLiteralId, SwiftTokens.ErroneousStringLiteralIndex);

public class BackingErroneousStringLiteralToken(BackingErroneousStringLiteralToken.ErrorCase errorCase, string valueOfContents, string value)
    : ErroneousTokenLiteralBacker<String, string>(String.Instance, valueOfContents, value, errorCase.ToMessage(), SwiftTokens.ErroneousStringLiteralIndex)
{
    public const string UnclosedStringLiteralEofError =
        "The string literal requires a closing quotation mark but the end of the file was reached.";

    public const string UnclosedStringLiteralWithHashtagsEofError =
        "The string literal requires a closing quotation mark but the end of the file was reached.\n" +
        "Hashtags must be balanced as well after the quotes.";

    public const string UnclosedStringLiteralWithHashtagsError =
        "The string literal requires a closing quotation mark but it was not found.\n" +
        "Hashtags must be balanced as well after the quotes.";

    public const string UnclosedStringLiteralError =
        "The string literal requires a closing quotation mark but the following character was not balanced.";

    public ErrorCase ProblemType => errorCase;

    public enum ErrorCase
    {
        UnclosedStringLiteralWithHashtagsEof,
        UnclosedStringLiteralEof,
        UnclosedStringLiteralWithHashtags,
        UnclosedStringLiteral
    }
}

public static class ErroneousStringLiteralExtensions
{
    public static string ToMessage(this BackingErroneousStringLiteralToken.ErrorCase errorCase)
    {
        return errorCase switch
        {
            BackingErroneousStringLiteralToken.ErrorCase.UnclosedStringLiteralWithHashtagsEof => BackingErroneousStringLiteralToken
                .UnclosedStringLiteralWithHashtagsEofError,
            BackingErroneousStringLiteralToken.ErrorCase.UnclosedStringLiteralEof => BackingErroneousStringLiteralToken
                .UnclosedStringLiteralEofError,
            BackingErroneousStringLiteralToken.ErrorCase.UnclosedStringLiteralWithHashtags => BackingErroneousStringLiteralToken
                .UnclosedStringLiteralWithHashtagsError,
            BackingErroneousStringLiteralToken.ErrorCase.UnclosedStringLiteral =>
                BackingErroneousStringLiteralToken.UnclosedStringLiteralError,
            _ => throw new ArgumentOutOfRangeException(nameof(errorCase), errorCase, null)
        };
    }
}