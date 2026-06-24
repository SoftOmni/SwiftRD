namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.FunctionCallExpressions.Arguments;

public interface IFunctionCallExpressionArgument : IReadOnlyFunctionCallExpressionArgument, IFunctionCallArgument
{
    new IExpression Expression { get; }
    
    void ChangeExpression(IExpression expression);
}
