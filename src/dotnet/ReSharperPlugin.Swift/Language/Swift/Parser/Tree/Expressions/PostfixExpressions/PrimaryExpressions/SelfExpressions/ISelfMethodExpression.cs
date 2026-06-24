using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Identifiers;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.SelfExpressions;

public interface ISelfMethodExpression : IReadOnlySelfMethodExpression, ISelfExpression
{
    new IIdentifier MethodName { get; }

    void ChangeMethodName(IIdentifier newMethodName);
}
