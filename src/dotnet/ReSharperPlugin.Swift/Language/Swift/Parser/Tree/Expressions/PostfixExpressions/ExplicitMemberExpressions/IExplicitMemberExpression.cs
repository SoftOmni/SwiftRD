namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.ExplicitMemberExpressions;

public interface IExplicitMemberExpression : IReadOnlyExplicitMemberExpression, IPostfixExpression
{
    new IPostfixExpression PostfixExpression { get; }
    
    void ChangePostfixExpression(IPostfixExpression newPostfixExpression);
}
