namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.FunctionCallExpressions.Arguments;

public interface IReadOnlyFunctionCallExpressionArgument : IReadOnlyFunctionCallArgument
{
    IReadOnlyExpression Expression { get; }
}
