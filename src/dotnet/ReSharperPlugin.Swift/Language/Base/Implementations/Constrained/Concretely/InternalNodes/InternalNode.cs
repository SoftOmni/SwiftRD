using ReSharperPlugin.Swift.Language.Base.Interfaces.Constrained.InternalNodes;
using ReSharperPlugin.Swift.Language.Base.Interfaces.Constrained.LeafNodes;
using ReSharperPlugin.Swift.Language.Base.Interfaces.Constrained.Root;

namespace ReSharperPlugin.Swift.Language.Base.Implementations.Constrained.InternalNodes;

public abstract class InternalNode<TBaseNode> : IInternalNode<TBaseNode>
    where TBaseNode : INode<IInternalNode<TBaseNode>, ILeafNode<TBaseNode>>
{
    
}