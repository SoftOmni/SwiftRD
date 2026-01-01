using System;
using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Base.Implementations.Constrained.InternalNodes;
using ReSharperPlugin.Swift.Language.Base.Implementations.Constrained.Root;
using ReSharperPlugin.Swift.Language.Base.Interfaces.Constrained.InternalNodes;
using ReSharperPlugin.Swift.Language.Base.Interfaces.Constrained.LeafNodes;
using ReSharperPlugin.Swift.Language.Base.Interfaces.Constrained.Root;
using ReSharperPlugin.Swift.Language.Base.Interfaces.Flexible.InternalNodes;
using ReSharperPlugin.Swift.Language.Base.Interfaces.Flexible.Root;

namespace ReSharperPlugin.Swift.Language.Base.Implementations.Constrained.LeafNodes;

public abstract class LeafNode<TBaseNode> : LeafElementBase, ILeafNode<TBaseNode>
    where TBaseNode : INode<IInternalNode<TBaseNode>, ILeafNode<TBaseNode>>
{
    protected IEditableBuffer UnderlyingBuffer;

    protected InternalNode<TBaseNode>? ParentNode;

    protected LeafNode(IEditableBuffer underlyingBuffer)
    {
        UnderlyingBuffer = underlyingBuffer;
        ParentNode = null;
        ParentIndex = -1;
        ParentTextIndex = -1;
    }

    protected LeafNode(IEditableBuffer underlyingBuffer, InternalNode<TBaseNode> parentNode, int parentIndex,
        int parentTextIndex)
    {
        UnderlyingBuffer = underlyingBuffer;
        ParentNode = parentNode;
        ParentIndex = parentIndex;
        ParentTextIndex = parentTextIndex;
    }

    public IInternalNode? GetParent() => ParentNode;

    public bool HasParent() => ParentNode is not null;

    public int ParentIndex { get; private set; }

    public int ParentTextIndex { get; private set; }

    public IBuffer Buffer => UnderlyingBuffer;

    public abstract INode CloneAsDetached();

    public abstract INode CloneAsAttachedTo(IInternalNode newParent, int index);

    public void AttachToParent(IInternalNode newParent, int parentIndex)
    {
        if (!newParent.GetType()
                .IsAssignableFrom(typeof(IInternalNode<TBaseNode>))) //TODO: Review and adjust documentation
        {
            throw new NotSupportedException(
                $"The type of new parent ({newParent.GetType().FullName} (runtime type))\n" +
                $"is not assignable to the type of {typeof(IInternalNode<TBaseNode>).FullName}.\n" +
                "This is required for a constrained LeafNode<TBaseNode>."); //TODO: review message
        }

        newParent.AttachChild(parentIndex, this);
    }

    public void AttachToParent(IInternalNode<TBaseNode> newParent, int parentIndex)
    {
        newParent.AttachChild<LeafNode<TBaseNode>>(ParentIndex, this);
    }

    public void AttachToParent<TInternalNode>(TInternalNode newParent, int parentIndex)
        where TInternalNode : IInternalNode<TBaseNode>
    {
        newParent.AttachChild<LeafNode<TBaseNode>>(ParentIndex, this);
    }

    public void DetachFromParent()
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