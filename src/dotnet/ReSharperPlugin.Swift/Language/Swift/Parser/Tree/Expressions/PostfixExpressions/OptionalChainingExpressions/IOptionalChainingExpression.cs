namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.OptionalChainingExpressions;

public interface IOptionalChainingExpression : IReadOnlyOptionalChainingExpression, IPostfixExpression
{
    new IPostfixExpression PostfixExpression { get; }
    
    void ChangePostfixExpression(IPostfixExpression newPostfixExpression);
}
