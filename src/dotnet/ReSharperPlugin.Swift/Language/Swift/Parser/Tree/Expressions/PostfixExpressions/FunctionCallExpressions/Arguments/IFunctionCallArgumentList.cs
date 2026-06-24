using System.Collections.Generic;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.FunctionCallExpressions.Arguments;

public interface IFunctionCallArgumentList : IReadOnlyFunctionCallArgumentList, IList<IFunctionCallArgument>
{
    new IReadOnlyList<IFunctionCallArgument> Arguments { get; }
    
    new int Count { get; }

    new IEnumerator<IFunctionCallArgument> GetEnumerator();
    
    new IFunctionCallArgument this[int index] { get; }
}
