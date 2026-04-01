using System;
using System.Collections.Generic;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Base.Interfaces.Flexible.InternalNodes;
using SoftOmni.SwiftRd.Language.Base.Interfaces.Flexible.BaseNodes;

namespace SoftOmni.SwiftRd.Language.Base.Implementations.Flexible.Loose.InternalNodes;

public abstract partial class InternalNode : CompositeElement, IInternalNode
{
    private readonly List<INode> _children = [];

    protected IEditableBuffer UnderlyingBuffer;
    
    protected IInternalNode? ParentNode;

    public int NumberOfChildren => _children.Count;

    public INode this[int index]
    {
        get => _children[index];
        set => SetChildAtAndDiscard(index, value);
    }

    public virtual IInternalNode? GetParent()
    {
        return ParentNode;
    }

    public virtual bool HasParent()
    {
        return ParentNode is not null;
    }

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

    public abstract IInternalNode CloneAsDetached();

    INode INode.CloneAsAttachedTo(IInternalNode newParent, int index)
    {
        return CloneAsAttachedTo(newParent, index);
    }

    public void AttachToParent(IInternalNode newParent, int parentIndex)
    {
        ParentNode?.DetachChildAt(ParentIndex);
        ParentTextIndex = newParent.AttachChild(parentIndex, this);
        ParentNode = newParent;
        ParentIndex = parentIndex;
    }

    public void DetachFromParent()
    {
        ParentNode?.DetachChildAt(ParentIndex);
    }

    INode INode.CloneAsDetached()
    {
        return CloneAsDetached();
    }

    public IInternalNode CloneAsAttachedTo(IInternalNode newParent, int index)
    {
        IInternalNode clonedNode = CloneAsDetached(); // Could be optimized
        newParent.AttachChild(index, clonedNode);
        return clonedNode;
    }

    private void CheckIndexes(int startIndex)
    {
        if (startIndex < 0 || startIndex >= NumberOfChildren)
        {
            throw new ArgumentOutOfRangeException(nameof(startIndex));
        }
    }

    private void CheckIndexes(int startIndex, int count)
    {
        if (startIndex < 0 || startIndex >= NumberOfChildren)
        {
            throw new ArgumentOutOfRangeException(nameof(startIndex));
        }

        if (count < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(count));
        }

        if (startIndex + count >= NumberOfChildren)
        {
            throw new ArgumentOutOfRangeException(nameof(count));
        }
    }

    private void CheckIndexesInRange(int startIndex, int endIndex)
    {
        if (startIndex < 0 || startIndex >= NumberOfChildren)
        {
            throw new ArgumentOutOfRangeException(nameof(startIndex));
        }

        if (endIndex < startIndex || endIndex >= NumberOfChildren)
        {
            throw new ArgumentOutOfRangeException(nameof(endIndex));
        }
    }
}