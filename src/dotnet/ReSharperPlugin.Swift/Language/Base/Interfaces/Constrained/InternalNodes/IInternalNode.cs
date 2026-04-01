using SoftOmni.SwiftRd.Language.Base.Interfaces.Constrained.LeafNodes;
using SoftOmni.SwiftRd.Language.Base.Interfaces.Constrained.Root;
using SoftOmni.SwiftRd.Language.Base.Interfaces.Flexible.InternalNodes;
using SoftOmni.SwiftRd.Language.Base.Interfaces.Flexible.LeafNodes;

namespace SoftOmni.SwiftRd.Language.Base.Interfaces.Constrained.InternalNodes;

public interface IInternalNode<TFamily, TSelf, TLeafNode> :
    INode<TFamily, TSelf, TSelf, TLeafNode>, IInternalNode
    where TFamily : INodeFamily<TFamily, TSelf, TLeafNode>
    where TSelf : IInternalNode<TFamily, TSelf, TLeafNode>
    where TLeafNode : ILeafNode<TFamily, TSelf, TLeafNode>
{
    
}