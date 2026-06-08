using SoftOmni.SwiftRd.Language.Semantics.Type.BuiltinTypes;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.Literals.Literals;

public interface IReadOnlyBooleanLiteral : IReadOnlyLiteral<Bool, bool>
{
    bool IsTrue();

    bool IsFalse();
}