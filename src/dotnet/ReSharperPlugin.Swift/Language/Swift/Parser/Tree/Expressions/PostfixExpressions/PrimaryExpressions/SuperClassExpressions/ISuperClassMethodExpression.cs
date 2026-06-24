using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Identifiers;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.SuperClassExpressions;

public interface ISuperClassMethodExpression : IReadOnlySuperClassMethodExpression, ISuperClassExpression
{
    new IIdentifier MethodName { get; }

    void ChangeMethodName(IIdentifier newMethodName);
}
