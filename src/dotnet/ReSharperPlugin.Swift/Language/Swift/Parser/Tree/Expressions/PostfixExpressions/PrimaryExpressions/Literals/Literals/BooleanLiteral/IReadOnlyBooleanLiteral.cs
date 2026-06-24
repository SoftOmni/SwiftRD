namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.Literals.Literals;

public interface IReadOnlyBooleanLiteral : IReadOnlyLiteral<bool>
{
    bool IsTrue();

    bool IsFalse();
}