using SoftOmni.SwiftRd.Language.Swift.Semantics.PrimitiveLiterals;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.Literals;

public interface IReadOnlyLiteral : IReadOnlyPrimaryExpression
{
    IReadOnlyPrimitiveLiteralTypeResolutionContext PrimitiveLiteralTypeResolutionContext { get; }
}

public interface IReadOnlyLiteral<out TCSharpValueType> : IReadOnlyLiteral
{
    public TCSharpValueType Value { get; }

    public TCSharpValueType GetValueCopy();
}
