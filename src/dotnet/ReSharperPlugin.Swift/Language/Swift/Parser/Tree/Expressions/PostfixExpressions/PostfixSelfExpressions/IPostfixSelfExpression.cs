namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PostfixSelfExpressions;

public interface IPostfixSelfExpression : IReadOnlyPostfixSelfExpression, IPostfixExpression
{
    new IPostfixExpression PostfixExpression { get; }
    
    void ChangePostfixExpression(IPostfixExpression newPostfixExpression);
}
