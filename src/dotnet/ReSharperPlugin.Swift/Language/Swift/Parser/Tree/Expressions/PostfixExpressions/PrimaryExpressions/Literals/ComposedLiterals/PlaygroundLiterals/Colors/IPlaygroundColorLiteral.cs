using SoftOmni.SwiftRd.Language.Swift.Semantics.PrimitiveLiterals;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.Literals.ComposedLiterals.PlaygroundLiterals.Colors;

public interface IPlaygroundColorLiteral : IReadOnlyPlaygroundColorLiteral, 
    IPlaygroundLiteral<(IExpression red, IExpression green, IExpression blue, IExpression alpha)>
{
    new IExpression RedValue { get; }
    
    new IExpression GreenValue { get; }
    
    new IExpression BlueValue { get; }
    
    new IExpression AlphaValue { get; }
    
    new (IExpression red, IExpression green, IExpression blue, IExpression alpha) GetValueCopy();

    new void SetValue((IExpression red, IExpression green, IExpression blue, IExpression alpha) newValue);
    
    new IReadOnlyPrimitiveLiteralTypeResolutionContext PrimitiveLiteralTypeResolutionContext { get; }
    
    new (IExpression red, IExpression green, IExpression blue, IExpression alpha) Value { get; }

    IExpression ChangeRedExpression();

    IExpression ChangeGreenExpression();

    IExpression ChangeBlueExpression();

    IExpression ChangeAlphaExpression();
}
