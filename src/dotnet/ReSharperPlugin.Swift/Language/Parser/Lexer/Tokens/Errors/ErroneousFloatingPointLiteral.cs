using System;
using ExtendedNumerics;
using ReSharperPlugin.Swift.Language.Parser.Lexer.Tokens.Literals;
using Type = ReSharperPlugin.Swift.Language.Semantics.Type.Type;

namespace ReSharperPlugin.Swift.Language.Parser.Lexer.Tokens.Errors;

public class ErroneousFloatingPointLiteral<TType>(
    ErroneousFloatingPointLiteral<TType>.ErrorCase errorCase,
    TType type,
    BigDecimal valueOfContents,
    string value,
    FloatingPointRepresentation representation = FloatingPointRepresentation.Decimal)
    : ErroneousSwiftLiteral<TType, BigDecimal>(errorCase.ToMessage(), type, valueOfContents, value,
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

    public override bool IsConstantLiteral => true;

    public override string TokenRepresentation { get; } = value;

    public FloatingPointRepresentation Representation { get; } = representation;

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
    public static string ToMessage<TType>(this ErroneousFloatingPointLiteral<TType>.ErrorCase errorCase) where TType : Type
    {
        return errorCase switch
        {
            ErroneousFloatingPointLiteral<TType>.ErrorCase.DecimalPartMissingDecimal =>
                ErroneousFloatingPointLiteral<TType>.DecimalPartMissingMessageDecimalError,
            ErroneousFloatingPointLiteral<TType>.ErrorCase.DecimalPartMissingHexadecimal =>
                ErroneousFloatingPointLiteral<TType>.DecimalPartMissingMessageHexadecimalError,
            ErroneousFloatingPointLiteral<TType>.ErrorCase.ExponentValueMissingDecimal =>
                ErroneousFloatingPointLiteral<TType>.ExponentValueMissingMessageDecimalError,
            ErroneousFloatingPointLiteral<TType>.ErrorCase.ExponentValueMissingHexadecimal =>
                ErroneousFloatingPointLiteral<TType>.ExponentValueMissingMessageHexadecimalError,
            _ => throw new ArgumentOutOfRangeException(nameof(errorCase), errorCase, null)
        };
    }
}