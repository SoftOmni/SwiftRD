using System;
using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Base.Interfaces.Constrained;
using SoftOmni.SwiftRd.Language.Base.Interfaces.Constrained.InternalNodes;
using SoftOmni.SwiftRd.Language.Base.Interfaces.Constrained.LeafNodes;
using SoftOmni.SwiftRd.Language.Base.Interfaces.Constrained.Root;
using SoftOmni.SwiftRd.Language.Base.Interfaces.Flexible.BaseNodes;
using SoftOmni.SwiftRd.Language.Base.Interfaces.Flexible.InternalNodes;

namespace SoftOmni.SwiftRd.Language.Base.Implementations.Constrained.Base;

public abstract class Node<TFamily, TSelf, TInternalNode, TLeafNode> : TreeElement,
    INode<TFamily, TSelf, TInternalNode, TLeafNode>
    where TFamily : INodeFamily<TFamily, TInternalNode, TLeafNode>
    where TSelf : Node<TFamily, TSelf, TInternalNode, TLeafNode>
    where TInternalNode : class, IInternalNode<TFamily, TInternalNode, TLeafNode>
    where TLeafNode : ILeafNode<TFamily, TInternalNode, TLeafNode>
{
    protected IEditableBuffer UnderlyingBuffer;

    protected TInternalNode? ParentNode;

    protected Node(IEditableBuffer underlyingBuffer)
    {
        UnderlyingBuffer = underlyingBuffer;
        ParentNode = null;
        ParentIndex = -1;
        ParentTextIndex = -1;
    }

    protected Node(IEditableBuffer underlyingBuffer, TInternalNode parentNode, int parentIndex, int parentTextIndex)
    {
        UnderlyingBuffer = underlyingBuffer;
        ParentNode = parentNode;
        ParentIndex = parentIndex;
        ParentTextIndex = parentTextIndex;
    }
    
    public TInternalNode? GetParent()
    {
        return ParentNode;
    }

    TSelf INode<TFamily, TSelf, TInternalNode, TLeafNode>.CloneAsDetached()
    {
        throw new NotImplementedException();
    }

    public TSelf CloneAsAttachedTo(TInternalNode newParent, int index)
    {
        throw new NotImplementedException();
    }

    IInternalNode? INode.GetParent()
    {
        return GetParent();
    }

    public bool HasParent() => ParentNode is not null;

    public int ParentIndex { get; private set; }
    
    public int ParentTextIndex { get; private set; }
    
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
        if (!newParent.GetType().IsAssignableFrom(typeof(TInternalNode)))
        {
            throw new NotSupportedException($"The type of new parent ({newParent.GetType().FullName} (runtime type))\n" +
                                            $"is not assignable to the type of {typeof(TInternalNode).FullName}.\n" +
                                            "This is required for a constrained Node<TInternalNode, TLeafNode>.");
        }
        
        newParent.AttachChild(parentIndex, this);
    }

    public void AttachToParent(TInternalNode newParent, int parentIndex)
    {
        newParent.AttachChild<INode<TFamily, TSelf, TInternalNode, TLeafNode>>(ParentIndex, this);
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

    public abstract override PsiLanguageType Language { get; }
}