using SoftOmni.SwiftRd.Language.Swift.Semantics.PrimitiveLiterals;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.Literals;

public interface ILiteral : IReadOnlyLiteral, IPrimaryExpression
{
    void ChangeLiteralContext(IReadOnlyPrimitiveLiteralTypeResolutionContext newContext);

}

public interface ILiteral<TCSharpValueType> :
    IReadOnlyLiteral<TCSharpValueType>,
    ILiteral
{
    public void SetValue(TCSharpValueType newValue);
}
