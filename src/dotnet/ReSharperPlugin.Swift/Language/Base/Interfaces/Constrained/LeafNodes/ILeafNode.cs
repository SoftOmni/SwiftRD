using ReSharperPlugin.Swift.Language.Base.Interfaces.Constrained.InternalNodes;
using ReSharperPlugin.Swift.Language.Base.Interfaces.Constrained.Root;
using ReSharperPlugin.Swift.Language.Base.Interfaces.Flexible.LeafNodes;

namespace ReSharperPlugin.Swift.Language.Base.Interfaces.Constrained.LeafNodes;

public interface ILeafNode<TBaseNode> : ILeafNode, INode<IInternalNode<TBaseNode>, ILeafNode<TBaseNode>>
    where TBaseNode : INode<IInternalNode<TBaseNode>, ILeafNode<TBaseNode>>
{
    public void AttachToParent<TInternalNode>(TInternalNode newParent, int parentIndex)
        where TInternalNode : IInternalNode<TBaseNode>;
}