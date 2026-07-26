using System;
using System.Collections.Generic;
using System.Text;
using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.ReSharper.Psi.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Extensions;
using SoftOmni.SwiftRd.Language.Base.Implementations.Flexible.Concretely.InternalNodes;
using SoftOmni.SwiftRd.Language.Base.Interfaces.Flexible.BaseNodes;
using SoftOmni.SwiftRd.Language.Base.Interfaces.Flexible.InternalNodes;

namespace SoftOmni.SwiftRd.Language.Base.Implementations.Flexible.Concretely.BaseNodes;

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
///         Use <see cref="Node{TInternalNode,TLeafNode}"/>, <see cref="Loose.InternalNodes.InternalNode"/> and <see cref="LeafNode{TBaseNode}"/>
///         for their respective default implementations.
///     </para>
/// </summary>
public abstract class Node : TreeElement, INode
{
    public const int NoParentIndex = -1;
    
    protected IEditableBuffer UnderlyingBuffer;

    protected InternalNode? ParentNode;

    protected Node()
        : this(new EditableBuffer())
    { }

    protected Node(IEditableBuffer underlyingBuffer)
    {
        UnderlyingBuffer = underlyingBuffer;
        ParentNode = null;
        ParentIndex = NoParentIndex;
        ParentTextIndex = NoParentIndex;
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
    
    

    public void UnsafeDangerousSetParentIndex(int index)
    {
        if (index < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        ParentIndex = index;
    }

    public void UnsafeDangerousSetParentTextIndex(int index)
    {
        if (index < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }
        
        ParentTextIndex = index;
    }

    public void UnsafeDangerousSetUnderlyingBuffer(IEditableBuffer buffer)
    {
        UnderlyingBuffer = buffer;
    }

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
        ParentIndex = NoParentIndex;
        ParentTextIndex = NoParentIndex;
        UnderlyingBuffer = newBuffer;
    }

    public override string GetText()
    {
        return UnderlyingBuffer.ToString();
    }

    public override IBuffer GetTextAsBuffer()
    {
        return UnderlyingBuffer;
    }

    public override int GetTextLength()
    {
        return UnderlyingBuffer.Length;
    }

    public override StringBuilder GetText(StringBuilder to)
    {
        return StringBuilderExtensions.Append(to, UnderlyingBuffer);
    }

    public override ITreeNode? FirstChild => null;
    
    public override ITreeNode? LastChild => null;

    public override NodeType NodeType => EmptyNodeType.Instance;

    public override ITreeNode FindNodeAt(TreeTextRange treeRange)
    {
        return this;
    }

    public override void FindNodesAtInternal(TreeTextRange relativeRange, List<ITreeNode> result, bool includeContainingNodes)
    {
        result.Add(this);
    }

    public class EmptyNodeType : NodeType
    {
        internal static readonly EmptyNodeType Instance = new();

        public const int ElementIndex = 1_000_000;

        public const string ElementId = "SoftOmniConcreteNodeEmptyNodeType";
        
        private EmptyNodeType()
            : base(ElementId, ElementIndex, NodeTypeFlags.Token)
        { }
    }
}