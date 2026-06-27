using System.Collections.Generic;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.InternalNode;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.FunctionTypes.Arguments;

public interface IReadOnlyFunctionTypeArgumentList : ISwiftInternalNode<SwiftCompositeNode>, IReadOnlyList<IReadOnlyFunctionTypeArgument>
{
    IReadOnlyList<IReadOnlyFunctionTypeArgument> TypeArguments { get; }
    
    new IReadOnlyFunctionTypeArgument this[int index] { get; }
}
