using SoftOmni.SwiftRd.Language.Semantics.Type.BuiltinTypes;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.Literals.Literals;

public interface IBooleanLiteral : IReadOnlyBooleanLiteral, ILiteral<Bool, bool>
{
    bool TryToMakeTrue();
    
    bool TryToMakeFalse();
}