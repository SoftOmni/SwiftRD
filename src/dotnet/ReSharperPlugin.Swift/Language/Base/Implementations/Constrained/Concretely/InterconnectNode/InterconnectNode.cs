using JetBrains.DocumentModel.Impl;
using SoftOmni.SwiftRd.Language.Base.Implementations.Constrained.InternalNodes;
using SoftOmni.SwiftRd.Language.Base.Interfaces.Constrained;
using SoftOmni.SwiftRd.Language.Base.Interfaces.Constrained.InternalNodes;
using SoftOmni.SwiftRd.Language.Base.Interfaces.Constrained.LeafNodes;
using SoftOmni.SwiftRd.Language.Base.Interfaces.Flexible.InternalNodes;

namespace SoftOmni.SwiftRd.Language.Base.Implementations.Constrained.Concretely.InterconnectNode;

public abstract class InterconnectNode<TFamily, TBaseNode, TLeafNode, TOtherNode> :
    InternalNode<TFamily, TBaseNode, TLeafNode>,
    IInterconnectNode<TFamily, TBaseNode, TLeafNode, TOtherNode>
    where TFamily : INodeFamily<TFamily, TBaseNode, TLeafNode>
    where TBaseNode : InternalNode<TFamily, TBaseNode, TLeafNode>
    where TLeafNode : ILeafNode<TFamily, TBaseNode, TLeafNode>
    where TOtherNode : IInternalNode
{
    public TOtherNode EquivalentNode { get; protected set; }

    protected InterconnectNode(TOtherNode equivalentNode)
    {
        EquivalentNode = equivalentNode;
    }

    protected InterconnectNode(TOtherNode equivalentNode, TBaseNode parent, int index)
        : base(parent, index, new EditableBuffer(equivalentNode.GetText()))
    {
        EquivalentNode = equivalentNode;
    }

    protected InterconnectNode(TOtherNode equivalentNode, TBaseNode parent, int index, int textIndex, int lengthInParent)
        : base(parent, index, textIndex, lengthInParent)
    {
        EquivalentNode = equivalentNode;
    }

    public virtual void InjectEquivalentNode(TOtherNode equivalentNode)
    {
        EquivalentNode = equivalentNode;
    }
}