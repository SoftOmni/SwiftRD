using System.Collections.Generic;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.FunctionCallExpressions.Arguments;

namespace SoftOmni.SwiftRd.Rider.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.KeyPathExpressions.Components.KeyPathPostfixes;

public interface IArgumentListKeyPathPostfix : IReadOnlyArgumentListKeyPathPostfix, 
    IKeyPathPostfix, IList<IFunctionCallArgument>
{
    new IReadOnlyList<IFunctionCallArgument> Arguments { get; }
    
    new int Count { get; }

    new IEnumerator<IFunctionCallArgument> GetEnumerator();
    
    new IFunctionCallArgument this[int index] { get; }
}
