using System.Collections.Generic;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.InternalNode;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.FunctionCallExpressions.Arguments;

public interface IReadOnlyFunctionCallArgumentList : ISwiftInternalNode<SwiftCompositeNode>, IReadOnlyList<IReadOnlyFunctionCallArgument>
{
    LeftParenthesis LeftParenthesis { get; }
    
    IReadOnlyList<IReadOnlyFunctionCallArgument> Arguments { get; }
    
    IReadOnlyList<Comma> Commas { get; }
    
    RightParenthesis RightParenthesis { get; }
    
    new int Count { get; }

    new IEnumerator<IReadOnlyFunctionCallArgument> GetEnumerator();
    
    new IReadOnlyFunctionCallArgument this[int index] { get; }
}
