using SoftOmni.SwiftRd.Language.Swift.Semantics.PrimitiveLiterals;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.Literals;

public interface ILiteral<TCSharpValueType> : IReadOnlyLiteral<TCSharpValueType>, IPrimaryExpression
{
    void ChangeLiteralContext(IReadOnlyPrimitiveLiteralTypeResolutionContext newContext);
    
    public void SetValue(TCSharpValueType newValue);
}
