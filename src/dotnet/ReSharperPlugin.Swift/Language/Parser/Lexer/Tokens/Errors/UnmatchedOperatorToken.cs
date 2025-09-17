using System;

namespace ReSharperPlugin.Swift.Language.Parser.Lexer.Tokens.Errors;

public class UnmatchedOperatorToken(string value, UnmatchedOperatorToken.ErrorCase errorCase)
    : ErroneousToken(SwiftTokens.UnmatchedOperatorId, value, errorCase.ToMessage(), SwiftTokens.UnmatchedOperatorIndex)
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
    public static string ToMessage(this UnmatchedOperatorToken.ErrorCase errorCase)
    {
        return errorCase switch
        {
            UnmatchedOperatorToken.ErrorCase.UnmatchedOperatorOnlyEmpty => UnmatchedOperatorToken
                .UnmatchedOperatorOnlyEmptyError,
            UnmatchedOperatorToken.ErrorCase.UnmatchedStartingPostfixOperator => UnmatchedOperatorToken
                .UnmatchedStartingPostfixOperatorError,
            UnmatchedOperatorToken.ErrorCase.UnmatchedStartingPostfixOperatorWhitespaceUnexpected => UnmatchedOperatorToken
                .UnmatchedStartingPostfixOperatorErrorWhitespaceUnexpected,
            UnmatchedOperatorToken.ErrorCase.UnmatchedPostfixOrInfixOperatorEof => UnmatchedOperatorToken
                .UnmatchedPostfixOrInfixOperatorEofError,
            UnmatchedOperatorToken.ErrorCase.UnmatchedPostfixOrInfixOperatorEofUnexpectedPrefixWhitespace => UnmatchedOperatorToken
                .UnmatchedPostfixOrInfixOperatorEofUnexpectedPrefixWhitespaceError,
            UnmatchedOperatorToken.ErrorCase.UnmatchedForciblyPostfixDotOperatorWhitespace => UnmatchedOperatorToken
                .UnmatchedForciblyPostfixDotOperatorWhitespaceError,
            UnmatchedOperatorToken.ErrorCase.UnmatchedForciblyPostfixDotOperatorWhitespaceUnexpected => UnmatchedOperatorToken
                .UnmatchedForciblyPostfixDotOperatorWhitespaceErrorWhitespaceUnexpected,
            UnmatchedOperatorToken.ErrorCase.UnmatchedForciblyPostfixDotOperatorEof => UnmatchedOperatorToken
                .UnmatchedForciblyPostfixDotOperatorEofError,
            _ => throw new ArgumentOutOfRangeException(nameof(errorCase), errorCase, null)
        };
    }
}