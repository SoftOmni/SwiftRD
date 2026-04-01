using SoftOmni.SwiftRd.Language.Base.Interfaces.Constrained.InternalNodes;
using SoftOmni.SwiftRd.Language.Base.Interfaces.Constrained.Root;
using SoftOmni.SwiftRd.Language.Base.Interfaces.Flexible.LeafNodes;

namespace SoftOmni.SwiftRd.Language.Base.Interfaces.Constrained.LeafNodes;

public interface ILeafNode<TFamily, TInternalNode, TSelf> :
    INode<TFamily, TSelf, TInternalNode, TSelf>, ILeafNode
    where TFamily : INodeFamily<TFamily, TInternalNode, TSelf>
    where TInternalNode : IInternalNode<TFamily, TInternalNode, TSelf>
    where TSelf : ILeafNode<TFamily, TInternalNode, TSelf>
{
    public void AttachToParent<TParent>(TInternalNode newParent, int parentIndex)
        where TParent : IInternalNode<TFamily, TInternalNode, TSelf>;
}