namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.Literals.Literals;

public interface IBooleanLiteral : IReadOnlyBooleanLiteral, ILiteral<bool>
{
    bool TryToMakeTrue();
    
    bool TryToMakeFalse();
}
