using System;
using String = ReSharperPlugin.Swift.Language.Semantics.Type.BuiltinTypes.String;

namespace ReSharperPlugin.Swift.Language.Parser.Lexer.Tokens.Errors;

public class ErroneousStringLiteral(ErroneousStringLiteral.ErrorCase errorCase, string valueOfContents, string value)
    : ErroneousSwiftLiteral<String, string>(SwiftTokens.ErroneousStringLiteralId, errorCase.ToMessage(),
        String.Instance, valueOfContents, value, SwiftTokens.ErroneousStringLiteralIndex)
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
    public static string ToMessage(this ErroneousStringLiteral.ErrorCase errorCase)
    {
        return errorCase switch
        {
            ErroneousStringLiteral.ErrorCase.UnclosedStringLiteralWithHashtagsEof => ErroneousStringLiteral
                .UnclosedStringLiteralWithHashtagsEofError,
            ErroneousStringLiteral.ErrorCase.UnclosedStringLiteralEof => ErroneousStringLiteral
                .UnclosedStringLiteralEofError,
            ErroneousStringLiteral.ErrorCase.UnclosedStringLiteralWithHashtags => ErroneousStringLiteral
                .UnclosedStringLiteralWithHashtagsError,
            ErroneousStringLiteral.ErrorCase.UnclosedStringLiteral =>
                ErroneousStringLiteral.UnclosedStringLiteralError,
            _ => throw new ArgumentOutOfRangeException(nameof(errorCase), errorCase, null)
        };
    }
}