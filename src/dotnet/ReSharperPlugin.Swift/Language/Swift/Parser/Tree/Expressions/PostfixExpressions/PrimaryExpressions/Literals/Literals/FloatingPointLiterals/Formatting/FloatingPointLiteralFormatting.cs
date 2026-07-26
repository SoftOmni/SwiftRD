using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.Literals.Literals.IntegerLiterals;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.Literals.Literals.IntegerLiterals.Formatting;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.Literals.
    Literals.FloatingPointLiterals.Formatting;

public readonly struct FloatingPointLiteralFormatting(
    IIntegerLiteralFormatting integralPartFormatting,
    IIntegerLiteralFormatting decimalPartFormatting,
    IIntegerLiteralFormatting exponentPartFormatting,
    IFloatingPointLiteralFormatting.Casing exponentCasing,
    IFloatingPointLiteralFormatting.Explicitness signExplicitness)
    : IFloatingPointLiteralFormatting
{
    public IIntegerLiteralFormatting IntegralPartFormatting { get; } = integralPartFormatting;

    public IIntegerLiteralFormatting DecimalPartFormatting { get; } = decimalPartFormatting;

    public IIntegerLiteralFormatting ExponentPartFormatting { get; } = exponentPartFormatting;

    public IFloatingPointLiteralFormatting.Casing ExponentCasing { get; } = exponentCasing;

    public IFloatingPointLiteralFormatting.Explicitness SignExplicitness { get; } = signExplicitness;

    public const IFloatingPointLiteralFormatting.Casing AbsoluteDefaultCasing =
        IFloatingPointLiteralFormatting.Casing.Uppercase;

    public static IFloatingPointLiteralFormatting.Casing CurrentStoredDefaultCasing { get; } = AbsoluteDefaultCasing;

    public const IFloatingPointLiteralFormatting.Explicitness AbsoluteDefaultSignExplicitness =
        IFloatingPointLiteralFormatting.Explicitness.Implicit;

    public static IFloatingPointLiteralFormatting.Explicitness CurrentStoredDefaultSignExplicitness { get; } =
        AbsoluteDefaultSignExplicitness;

    public static FloatingPointLiteralFormatting Default()
    {
        return new FloatingPointLiteralFormatting(
            IntegerLiteralFormatting.CurrentDefaultForBase(IReadOnlyIntegerLiteral.Base.Decimal),
            IntegerLiteralFormatting.CurrentDefaultForBase(IReadOnlyIntegerLiteral.Base.Decimal),
            IntegerLiteralFormatting.CurrentDefaultForBase(IReadOnlyIntegerLiteral.Base.Decimal),
            CurrentStoredDefaultCasing, CurrentStoredDefaultSignExplicitness);
    }
}