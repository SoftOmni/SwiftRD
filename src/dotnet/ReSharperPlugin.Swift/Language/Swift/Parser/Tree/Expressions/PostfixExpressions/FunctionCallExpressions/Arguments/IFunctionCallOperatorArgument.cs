using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Operators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.FunctionCallExpressions.Arguments;

public interface IFunctionCallOperatorArgument : IReadOnlyFunctionCallOperatorArgument, IFunctionCallArgument
{
    new IOperator Operator { get; }
    
    void ChangeOperator(IOperator newOperator);
}
