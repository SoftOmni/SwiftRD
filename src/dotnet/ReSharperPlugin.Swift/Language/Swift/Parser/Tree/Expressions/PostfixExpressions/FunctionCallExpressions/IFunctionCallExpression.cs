using System.Collections.Generic;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.FunctionCallExpressions.Arguments;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.FunctionCallExpressions.Closures;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.FunctionCallExpressions;

public interface IFunctionCallExpression : IReadOnlyFunctionCallExpression, IPostfixExpression, IList<IFunctionCallArgument>
{
    new IPostfixExpression PostfixExpression { get; }
    
    new IFunctionCallArgumentList? Arguments { get; }
    
    new ITrailingClosuresGroup? TrailingClosuresGroup { get; }
    
    new int Count { get; }

    new IEnumerator<IFunctionCallArgument> GetEnumerator();
    
    new IFunctionCallArgument this[int index] { get; }
}
