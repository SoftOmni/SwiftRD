using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Base.Implementations.Flexible.InternalNodes;
using ReSharperPlugin.Swift.Language.Base.Implementations.Flexible.LeafNodes;
using ReSharperPlugin.Swift.Language.Base.Implementations.Constrained.InternalNodes;
using ReSharperPlugin.Swift.Language.Base.Implementations.Constrained.LeafNodes;
using ReSharperPlugin.Swift.Language.Base.Implementations.Constrained.Root;
using ReSharperPlugin.Swift.Language.Base.Interfaces.Flexible.Root;
using ReSharperPlugin.Swift.Language.Base.Interfaces.Flexible.InternalNodes;
using ReSharperPlugin.Swift.Language.Base.Interfaces.Constrained.Root;
using ReSharperPlugin.Swift.Language.Base.Interfaces.Constrained.InternalNodes;
using ReSharperPlugin.Swift.Language.Base.Interfaces.Constrained.LeafNodes;

namespace ReSharperPlugin.Swift.Language.Base.Implementations.Flexible.Root;

/// <summary>
///     <para>
///         The default implementation of <see cref="INode"/> (the flexible variant
///         (not the constrained variant <see cref="INode{TIInternalNode, TILeafNode}"/>)
///     </para>
///     <para>
///         Represents a generic concrete or abstract syntax tree node for an arbitrary language.
///     </para>
///     <para>
///         This is the base node implementation and doesn't assume the node is an internal node or a leaf node.
///         <see cref="InternalNode"/> and <see cref="LeafNode"/> are there for respective internal nodes and leaf nodes.
///     </para>
///     <para>
///         This also doesn't assume that all the <see cref="INode"/>s of the tree have a particular language tied to them.
///         There could be differing languages within the same tree.
///         Use <see cref="INode{TIInternalNode, TILeafNode}"/> and <see cref="IInternalNode{TBaseNode}"/> and <see cref="ILeafNode{TBaseNode}"/>
///         to have a set of <see cref="INode"/>s that correspond to a particular language.
///         Use <see cref="Node{TInternalNode,TLeafNode}"/>, <see cref="InternalNode{TBaseNode}"/> and <see cref="LeafNode{TBaseNode}"/>
///         for their respective default implementations.
///     </para>
/// </summary>
public abstract class Node : TreeElement, INode
{
    protected IEditableBuffer UnderlyingBuffer;

    protected InternalNode? ParentNode;

    protected Node()
        : this(new EditableBuffer())
    { }

    protected Node(IEditableBuffer underlyingBuffer)
    {
        UnderlyingBuffer = underlyingBuffer;
        ParentNode = null;
        ParentIndex = -1;
        ParentTextIndex = -1;
    }

    protected Node(IEditableBuffer underlyingBuffer, InternalNode parentNode, int parentIndex, int parentTextIndex)
    {
        UnderlyingBuffer = underlyingBuffer;
        ParentNode = parentNode;
        ParentIndex = parentIndex;
        ParentTextIndex = parentTextIndex;
    }

    public IInternalNode? GetParent()
    {
        return ParentNode;
    }

    public bool HasParent() => ParentNode is not null;

    public int ParentIndex { get; protected set; }

    public int ParentTextIndex { get; protected set; }

    public IBuffer Buffer => UnderlyingBuffer;

    public abstract INode CloneAsDetached();

    public abstract INode CloneAsAttachedTo(IInternalNode newParent, int index);

    public virtual void AttachToParent(IInternalNode newParent, int parentIndex)
    {
        newParent.AttachChild(parentIndex, this);
    }

    public virtual void DetachFromParent()
    {
        IEditableBuffer newBuffer = new EditableBuffer(UnderlyingBuffer.Length);
        for (int i = 0; i < UnderlyingBuffer.Length; i++)
        {
            newBuffer.Insert(i, UnderlyingBuffer[i].ToString());
        }

        ParentNode = null;
        ParentIndex = -1;
        ParentTextIndex = -1;
        UnderlyingBuffer = newBuffer;
    }
}