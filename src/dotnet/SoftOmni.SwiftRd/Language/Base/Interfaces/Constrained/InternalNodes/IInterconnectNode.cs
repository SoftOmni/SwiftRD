using SoftOmni.SwiftRd.Language.Base.Interfaces.Constrained.LeafNodes;
using SoftOmni.SwiftRd.Language.Base.Interfaces.Flexible.InternalNodes;

namespace SoftOmni.SwiftRd.Language.Base.Interfaces.Constrained.InternalNodes;

public interface IInterconnectNode<TFamily, TBaseNode, TLeafNode, TOtherInternalNode> : 
    IInternalNode<TFamily, TBaseNode, TLeafNode>
    where TFamily : INodeFamily<TFamily, TBaseNode, TLeafNode>
    where TBaseNode : IInternalNode<TFamily, TBaseNode, TLeafNode>
    where TLeafNode : ILeafNode<TFamily, TBaseNode, TLeafNode>
    where TOtherInternalNode : IInternalNode
{
    TOtherInternalNode EquivalentNode { get; }

    void InjectEquivalentNode(TOtherInternalNode equivalentNode);
}
