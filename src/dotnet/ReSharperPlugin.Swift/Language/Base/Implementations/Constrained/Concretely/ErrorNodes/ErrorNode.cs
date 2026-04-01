using System;
using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Base.Implementations.Constrained.Base;
using SoftOmni.SwiftRd.Language.Base.Interfaces.Constrained;
using SoftOmni.SwiftRd.Language.Base.Interfaces.Constrained.InternalNodes;
using SoftOmni.SwiftRd.Language.Base.Interfaces.Constrained.LeafNodes;
using SoftOmni.SwiftRd.Language.Base.Interfaces.Constrained.Root;
using SoftOmni.SwiftRd.Language.Base.Interfaces.Flexible.BaseNodes;
using SoftOmni.SwiftRd.Language.Base.Interfaces.Flexible.ErrorNodes;
using SoftOmni.SwiftRd.Language.Base.Interfaces.Flexible.InternalNodes;

namespace SoftOmni.SwiftRd.Language.Base.Implementations.Constrained.Concretely.ErrorNodes;

public abstract class ErrorNode<TFamily, TSelf, TInternalNode, TLeafNode> : ErrorElement, INode<TFamily, TSelf, TInternalNode, TLeafNode>,
    IErrorNode
    where TFamily : INodeFamily<TFamily, TInternalNode, TLeafNode>
    where TSelf : Node<TFamily, TSelf, TInternalNode, TLeafNode>
    where TInternalNode : class, IInternalNode<TFamily, TInternalNode, TLeafNode>
    where TLeafNode : ILeafNode<TFamily, TInternalNode, TLeafNode>
{
    protected IEditableBuffer UnderlyingBuffer;

    protected TInternalNode? ParentNode;

    protected string Message; // Think about localization

    protected ErrorNode(IEditableBuffer underlyingBuffer, string message)
        : base(message)
    {
        UnderlyingBuffer = underlyingBuffer;
        ParentNode = null;
        ParentIndex = -1;
        ParentTextIndex = -1;

        Message = message;
    }

    protected ErrorNode(IEditableBuffer underlyingBuffer, TInternalNode parentNode, int parentIndex, int parentTextIndex, string message)
        : base(message)
    {
        UnderlyingBuffer = underlyingBuffer;
        ParentNode = parentNode;
        ParentIndex = parentIndex;
        ParentTextIndex = parentTextIndex;

        Message = message;
    }

    public string GetErrorMessage()
    {
        return Message;
    }

    public TInternalNode? GetParent()
    {
        return ParentNode;
    }

    TSelf INode<TFamily, TSelf, TInternalNode, TLeafNode>.CloneAsDetached()
    {
        throw new NotImplementedException();
    }

    INode INode.CloneAsAttachedTo(IInternalNode newParent, int index)
    {
        return CloneAsAttachedTo(newParent, index);
    }

    void INode.AttachToParent(IInternalNode newParent, int parentIndex)
    {
        AttachToParent(newParent, parentIndex);
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

    INode INode.CloneAsDetached()
    {
        return CloneAsDetached();
    }

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