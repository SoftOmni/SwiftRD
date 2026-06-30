namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.KeyPathStringExpressions;

public interface IKeyPathStringExpression : IReadOnlyKeyPathStringExpression, IPrimaryExpression
{
    new IExpression Expression { get; }

    void ChangeExpression(IExpression newExpression);
}
