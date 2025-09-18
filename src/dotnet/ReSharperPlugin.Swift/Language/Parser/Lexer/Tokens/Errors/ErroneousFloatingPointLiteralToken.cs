using System;
using ExtendedNumerics;
using ReSharperPlugin.Swift.Language.Parser.Lexer.Tokens.Literals;
using Type = ReSharperPlugin.Swift.Language.Semantics.Type.Type;

namespace ReSharperPlugin.Swift.Language.Parser.Lexer.Tokens.Errors;

public class ErroneousFloatingPointLiteralToken()
    : ErroneousSwiftLiteral(SwiftTokens.ErroneousFloatingPointLiteralId, SwiftTokens.ErroneousFloatingPointLiteralIndex)
{
    public override bool IsConstantLiteral => true;
}

public class BackingErroneousFloatingPointLiteralToken<TType>(
    BackingErroneousFloatingPointLiteralToken<TType>.ErrorCase errorCase,
    TType type,
    BigDecimal valueOfContents,
    string value,
    FloatingPointRepresentation representation = FloatingPointRepresentation.Decimal
) : ErroneousTokenLiteralBacker<TType, BigDecimal>(type, valueOfContents, value, errorCase.ToMessage(),
    SwiftTokens.ErroneousFloatingPointLiteralIndex) where TType : Type
{
    public const string DecimalPartMissingMessageDecimalError = "You put a dot but if a dot is present, " +
                                                                "at least one decimal digit must follow it";

    public const string DecimalPartMissingMessageHexadecimalError = "You put a dot but if a dot is present, " +
                                                                    "at least one hexadecimal digit must follow it";
    
    public const string ExponentValueMissingMessageDecimalError = "You put an exponent but if an exponent is present, " +
                                                                  "at least one decimal digit must follow it, possibly after " +
                                                                  "a single plus or minus sign";
    
    public const string ExponentValueMissingMessageHexadecimalError = "You put an exponent but if an exponent is present, " +
                                                                      "at least one hexadecimal digit must follow it, possibly after " +
                                                                      "a single plus or minus sign";
    
    public enum ErrorCase
    {
        DecimalPartMissingDecimal,
        DecimalPartMissingHexadecimal,
        ExponentValueMissingDecimal,
        ExponentValueMissingHexadecimal,
    }
}

public static class ErroneousFloatingPointLiteralProblemExtensions
{
    public static string ToMessage<TType>(this BackingErroneousFloatingPointLiteralToken<TType>.ErrorCase errorCase) where TType : Type
    {
        return errorCase switch
        {
            BackingErroneousFloatingPointLiteralToken<TType>.ErrorCase.DecimalPartMissingDecimal =>
                BackingErroneousFloatingPointLiteralToken<TType>.DecimalPartMissingMessageDecimalError,
            BackingErroneousFloatingPointLiteralToken<TType>.ErrorCase.DecimalPartMissingHexadecimal =>
                BackingErroneousFloatingPointLiteralToken<TType>.DecimalPartMissingMessageHexadecimalError,
            BackingErroneousFloatingPointLiteralToken<TType>.ErrorCase.ExponentValueMissingDecimal =>
                BackingErroneousFloatingPointLiteralToken<TType>.ExponentValueMissingMessageDecimalError,
            BackingErroneousFloatingPointLiteralToken<TType>.ErrorCase.ExponentValueMissingHexadecimal =>
                BackingErroneousFloatingPointLiteralToken<TType>.ExponentValueMissingMessageHexadecimalError,
            _ => throw new ArgumentOutOfRangeException(nameof(errorCase), errorCase, null)
        };
    }
}