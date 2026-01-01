using ReSharperPlugin.Swift.Language.Base.Interfaces.Constrained.LeafNodes;
using ReSharperPlugin.Swift.Language.Base.Interfaces.Constrained.Root;
using ReSharperPlugin.Swift.Language.Base.Interfaces.Flexible.InternalNodes;

namespace ReSharperPlugin.Swift.Language.Base.Interfaces.Constrained.InternalNodes;

public interface IInternalNode<TBaseNode> : IInternalNode, INode<IInternalNode<TBaseNode>, ILeafNode<TBaseNode>>
    where TBaseNode : INode<IInternalNode<TBaseNode>, ILeafNode<TBaseNode>>
{
    
}