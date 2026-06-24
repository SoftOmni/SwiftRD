namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.ParenthesizedExpressions;

public interface IParenthesizedExpression : IReadOnlyParenthesizedExpression, IPrimaryExpression
{
    new IExpression Expression { get; }

    void ChangeExpression(IExpression newExpression);
}