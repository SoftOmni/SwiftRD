namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.ExplicitMemberExpressions;

public interface IReadOnlyExplicitMemberExpression : IReadOnlyPostfixExpression
{
    IReadOnlyPostfixExpression PostfixExpression { get; }
}
