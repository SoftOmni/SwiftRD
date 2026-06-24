using System.Collections.Generic;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.FunctionCallExpressions.Arguments;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.FunctionCallExpressions.Closures;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.FunctionCallExpressions;

public interface IReadOnlyFunctionCallExpression : IReadOnlyList<IReadOnlyFunctionCallArgument>
{
    IReadOnlyPostfixExpression PostfixExpression { get; }
    
    IReadOnlyFunctionCallArgumentList? Arguments { get; }
    
    IReadOnlyTrailingClosuresGroup? TrailingClosuresGroup { get; }
    
    IReadOnlyList<IReadOnlyFunctionCallArgument> ArgumentsList { get; }
}
