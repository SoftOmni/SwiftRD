using System;
using System.Collections.Generic;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Base.Implementations.Flexible.Root;
using ReSharperPlugin.Swift.Language.Base.Interfaces.Flexible.InternalNodes;
using ReSharperPlugin.Swift.Language.Base.Interfaces.Flexible.Root;

namespace ReSharperPlugin.Swift.Language.Base.Implementations.Flexible.Loose.InternalNodes;

public abstract partial class InternalNode : TreeElement, IInternalNode
{
    private readonly List<INode> _children = [];

    protected IEditableBuffer UnderlyingBuffer;

    protected InternalNode(IEnumerator<INode> childEnumerator, bool mustDispose = true)
    {
        while (childEnumerator.MoveNext())
        {
            _children.Add(childEnumerator.Current);
        }

        if (mustDispose)
        {
            childEnumerator.Dispose();
        }
    }

    protected InternalNode(IEnumerator<INode> childEnumerator, int startIndexInEnumerator, bool mustDispose = true)
    {
        int index = 0;
        while (childEnumerator.MoveNext() && index < startIndexInEnumerator)
        {
            index++;
        }

        if (index < startIndexInEnumerator) // Means enumerator ran out
        {
            if (mustDispose)
            {
                childEnumerator.Dispose();
            }

            throw new ArgumentOutOfRangeException(nameof(startIndexInEnumerator));
        }

        while (childEnumerator.MoveNext())
        {
            _children.Add(childEnumerator.Current);
        }

        if (mustDispose)
        {
            childEnumerator.Dispose();
        }
    }

    protected InternalNode(IEnumerator<INode> childEnumerator, int startIndexInEnumerator, int numberOfChildrenInEnumeratorToTake,
        bool mustDispose = true)
    {
        int index = 0;
        while (childEnumerator.MoveNext() && index < startIndexInEnumerator)
        {
            index++;
        }

        if (index < startIndexInEnumerator)
        {
            if (mustDispose)
            {
                childEnumerator.Dispose();
            }

            throw new ArgumentOutOfRangeException(nameof(startIndexInEnumerator));
        }

        int targetIndex = startIndexInEnumerator + numberOfChildrenInEnumeratorToTake;
        while (childEnumerator.MoveNext() && index < targetIndex)
        {
            // _children.Add();
            index++;
        }
    } /*

    protected InternalNode(IEditableBuffer buffer)
        : base(buffer)
    { }

    protected InternalNode(IEditableBuffer buffer, InternalNode parent, int parentIndex, int parentTextIndex)
        : base(buffer, parent, parentIndex, parentTextIndex)
    { }*/

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