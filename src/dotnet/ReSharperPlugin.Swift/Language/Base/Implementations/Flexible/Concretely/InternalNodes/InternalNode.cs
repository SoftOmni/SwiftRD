using System;
using System.Collections.Generic;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Base.Implementations.Flexible.Concretely.BaseNodes;
using SoftOmni.SwiftRd.Language.Base.Interfaces.Flexible.InternalNodes;
using SoftOmni.SwiftRd.Language.Base.Interfaces.Flexible.BaseNodes;

namespace SoftOmni.SwiftRd.Language.Base.Implementations.Flexible.Concretely.InternalNodes;

public abstract partial class InternalNode : TreeElement, IInternalNode
{
    private readonly List<Node> _children = [];

    protected IEditableBuffer UnderlyingBuffer;

    public int NumberOfChildren => _children.Count;

    public INode this[int index]
    {
        get => throw new NotImplementedException();
        set => throw new NotImplementedException();
    }

    public IInternalNode? GetParent()
    {
        throw new NotImplementedException();
    }

    public bool HasParent()
    {
        throw new NotImplementedException();
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

    public IInternalNode CloneAsDetached()
    {
        throw new NotImplementedException();
    }

    INode INode.CloneAsAttachedTo(IInternalNode newParent, int index)
    {
        return CloneAsAttachedTo(newParent, index);
    }

    public void AttachToParent(IInternalNode newParent, int parentIndex)
    {
        throw new NotImplementedException();
    }

    public void DetachFromParent()
    {
        throw new NotImplementedException();
    }

    INode INode.CloneAsDetached()
    {
        return CloneAsDetached();
    }

    public IInternalNode CloneAsAttachedTo(IInternalNode newParent, int index)
    {
        throw new NotImplementedException();
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