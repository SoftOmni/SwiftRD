namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.ForcedValueExpressions;

public interface IForcedValueExpression : IReadOnlyForcedValueExpression, IPostfixExpression
{
    new IPostfixExpression PostfixExpression { get; }
    
    void ChangePostfixExpression(IPostfixExpression newPostfixExpression);
}
