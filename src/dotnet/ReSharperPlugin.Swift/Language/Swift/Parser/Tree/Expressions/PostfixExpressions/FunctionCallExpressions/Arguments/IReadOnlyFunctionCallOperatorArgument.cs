using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Operators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.FunctionCallExpressions.Arguments;

public interface IReadOnlyFunctionCallOperatorArgument : IReadOnlyFunctionCallArgument
{
    IReadOnlyOperator Operator { get; }
}
