using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.ExplicitMemberExpressions.ArgumentNames;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.InitializerExpressions;

public interface IInitializerExpression : IReadOnlyInitializerExpression, IPostfixExpression
{
    new IPostfixExpression PostfixExpression { get; }
    
    new IArgumentNames? ArgumentNames { get; }
    
    void ChangePostfixExpression(IPostfixExpression newPostfixExpression);
    
    void RemoveArgumentNames();
    
    void SetArgumentNamesTo(IArgumentNames? newArgumentNames); // TODO: Review this kind of API
}
