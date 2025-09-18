using System;

namespace ReSharperPlugin.Swift.Language.Parser.Lexer.Tokens.Errors;

public class UnmatchedOperatorToken() : ErroneousToken(SwiftTokens.UnmatchedOperatorId, SwiftTokens.UnmatchedOperatorIndex);

public class BackingUnmatchedOperatorToken(string value, BackingUnmatchedOperatorToken.ErrorCase errorCase)
    : BackingErroneousToken(value, errorCase.ToMessage(), SwiftTokens.UnmatchedOperatorIndex)
{
    public const string UnexpectedWhitespaceFollower =
        "Keep in mind that the whitespace character is not what one would typically consider whitespace\n" +
        "but the Swift standard considers for the purposes of operators the characters ',', ';', ':', " +
        "')', '}', ']' as whitespace after an operator";
    
    public const string UnexpectedWhitespacePreceding =
        "Keep in mind that the whitespace character is not what one would typically consider whitespace\n" +
        "but the Swift standard considers for the purposes of operators the characters ',', ';', ':', " +
        "'(', '{', '[' as whitespace before an operator";
    
    public const string UnmatchedOperatorOnlyEmptyError = "The operator was the only element in the file.\n" +
                                                          "It must be at the very least followed by an operand.";
    
    public const string UnmatchedStartingPostfixOperatorError =
        "The operator was at the very beginning of the file.\n" +
        "A postfix operator's operand was expected without preceeding whitespace\n" +
        "but the operator was followed by whitespace.\n";
    
    public const string UnmatchedStartingPostfixOperatorErrorWhitespaceUnexpected =
        UnmatchedStartingPostfixOperatorError + UnexpectedWhitespaceFollower;


    public const string UnmatchedPostfixOrInfixOperatorEofError =
        "The operator which has whitespace preceeding meaning " +
        "it can only be used as a postfix or infix operator was " +
        "the last element in the file with no operand to operate on.";
    
    public const string UnmatchedPostfixOrInfixOperatorEofUnexpectedPrefixWhitespaceError =
        UnmatchedPostfixOrInfixOperatorEofError + "\n" + UnexpectedWhitespacePreceding;
    
    public const string UnmatchedForciblyPostfixDotOperatorWhitespaceError =
        "The dot operator preceeded by a prefix operator is forcibly a postfix operator.\n" +
        "Prefix operators must have their operand immediately after without whitespace.\n" +
        "The dot operator was followed by whitespace.\n";
    
    public const string UnmatchedForciblyPostfixDotOperatorWhitespaceErrorWhitespaceUnexpected =
        UnmatchedForciblyPostfixDotOperatorWhitespaceError + UnexpectedWhitespaceFollower;


    public const string UnmatchedForciblyPostfixDotOperatorEofError =
        "The dot operator preceeded by a prefix operator is forcibly a postfix operator.\n" +
        "Prefix operators must have their operand immediately after without whitespace.\n" +
        "The dot operator was the last element in the file with no operand to operate on.";

    public enum ErrorCase
    {
        UnmatchedOperatorOnlyEmpty,
        UnmatchedStartingPostfixOperator,
        UnmatchedStartingPostfixOperatorWhitespaceUnexpected,
        UnmatchedPostfixOrInfixOperatorEof,
        UnmatchedPostfixOrInfixOperatorEofUnexpectedPrefixWhitespace,
        UnmatchedForciblyPostfixDotOperatorWhitespace,
        UnmatchedForciblyPostfixDotOperatorWhitespaceUnexpected,
        UnmatchedForciblyPostfixDotOperatorEof
    }
}

public static class UnmatchedOperatorTokenExtensions
{
    public static string ToMessage(this BackingUnmatchedOperatorToken.ErrorCase errorCase)
    {
        return errorCase switch
        {
            BackingUnmatchedOperatorToken.ErrorCase.UnmatchedOperatorOnlyEmpty => BackingUnmatchedOperatorToken
                .UnmatchedOperatorOnlyEmptyError,
            BackingUnmatchedOperatorToken.ErrorCase.UnmatchedStartingPostfixOperator => BackingUnmatchedOperatorToken
                .UnmatchedStartingPostfixOperatorError,
            BackingUnmatchedOperatorToken.ErrorCase.UnmatchedStartingPostfixOperatorWhitespaceUnexpected => BackingUnmatchedOperatorToken
                .UnmatchedStartingPostfixOperatorErrorWhitespaceUnexpected,
            BackingUnmatchedOperatorToken.ErrorCase.UnmatchedPostfixOrInfixOperatorEof => BackingUnmatchedOperatorToken
                .UnmatchedPostfixOrInfixOperatorEofError,
            BackingUnmatchedOperatorToken.ErrorCase.UnmatchedPostfixOrInfixOperatorEofUnexpectedPrefixWhitespace => BackingUnmatchedOperatorToken
                .UnmatchedPostfixOrInfixOperatorEofUnexpectedPrefixWhitespaceError,
            BackingUnmatchedOperatorToken.ErrorCase.UnmatchedForciblyPostfixDotOperatorWhitespace => BackingUnmatchedOperatorToken
                .UnmatchedForciblyPostfixDotOperatorWhitespaceError,
            BackingUnmatchedOperatorToken.ErrorCase.UnmatchedForciblyPostfixDotOperatorWhitespaceUnexpected => BackingUnmatchedOperatorToken
                .UnmatchedForciblyPostfixDotOperatorWhitespaceErrorWhitespaceUnexpected,
            BackingUnmatchedOperatorToken.ErrorCase.UnmatchedForciblyPostfixDotOperatorEof => BackingUnmatchedOperatorToken
                .UnmatchedForciblyPostfixDotOperatorEofError,
            _ => throw new ArgumentOutOfRangeException(nameof(errorCase), errorCase, null)
        };
    }
}