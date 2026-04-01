using System;
using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Base.Interfaces.Flexible.InternalNodes;
using SoftOmni.SwiftRd.Language.Base.Interfaces.Flexible.BaseNodes;

namespace SoftOmni.SwiftRd.Language.Base.Implementations.Flexible.Loose.Base;

public abstract class Node : TreeElement, INode
{
    protected IEditableBuffer UnderlyingBuffer;

    protected IInternalNode? ParentNode;
    
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

    protected Node(IEditableBuffer underlyingBuffer, IInternalNode parentNode, int parentIndex, int parentTextIndex)
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