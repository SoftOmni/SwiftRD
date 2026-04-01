using System;
using System.Text;
using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Extensions;
using SoftOmni.SwiftRd.Language.Base.Implementations.Constrained.LeafNodes;
using SoftOmni.SwiftRd.Language.Base.Interfaces.Constrained;
using SoftOmni.SwiftRd.Language.Base.Interfaces.Constrained.InternalNodes;
using SoftOmni.SwiftRd.Language.Base.Interfaces.Constrained.LeafNodes;
using SoftOmni.SwiftRd.Language.Base.Interfaces.Constrained.Root;
using SoftOmni.SwiftRd.Language.Base.Interfaces.Flexible.BaseNodes;
using SoftOmni.SwiftRd.Language.Base.Interfaces.Flexible.ErrorNodes;
using SoftOmni.SwiftRd.Language.Base.Interfaces.Flexible.InternalNodes;
using SoftOmni.SwiftRd.Language.Base.Interfaces.Flexible.LeafNodes;

namespace SoftOmni.SwiftRd.Language.Base.Implementations.Constrained.Concretely.ErrorNodes;

public class ErrorLeafNode<TFamily, TSelf, TInternalNode> : ErrorElement, ILeafNode<TFamily, TInternalNode, TSelf>, IErrorNode
    where TFamily : INodeFamily<TFamily, TInternalNode, TSelf>
    where TSelf : LeafNode<TFamily, TSelf, TInternalNode>
    where TInternalNode : class, IInternalNode<TFamily, TInternalNode, TSelf>
{
    protected IEditableBuffer UnderlyingBuffer;

    protected TInternalNode? ParentCommentNode;

    protected string Message;

    protected ErrorLeafNode(IEditableBuffer underlyingBuffer, string message) : base(message)
    {
        UnderlyingBuffer = underlyingBuffer;
        ParentCommentNode = null;
        ParentIndex = -1;
        ParentTextIndex = -1;

        Message = message;
    }

    protected ErrorLeafNode(IEditableBuffer underlyingBuffer, TInternalNode parentNode, int parentIndex, int parentTextIndex,
        string message) : base(message)
    {
        UnderlyingBuffer = underlyingBuffer;
        ParentCommentNode = parentNode;
        ParentIndex = parentIndex;
        ParentTextIndex = parentTextIndex;

        Message = message;
    }

    public TInternalNode? GetParent() => ParentCommentNode;

    IInternalNode? INode.GetParent()
    {
        return GetParent();
    }

    public string GetErrorMessage()
    {
        return Message;
    }

    TSelf INode<TFamily, TSelf, TInternalNode, TSelf>.CloneAsDetached()
    {
        throw new NotImplementedException();
    }

    public TSelf CloneAsAttachedTo(TInternalNode newParent, int index)
    {
        throw new NotImplementedException();
    }

    public void AttachToParent(TInternalNode newParent, int parentIndex)
    {
        throw new NotImplementedException();
    }

    public void AttachToParent<TParent>(TInternalNode newParent, int parentIndex)
        where TParent : IInternalNode<TFamily, TInternalNode, TSelf>
    {
        throw new NotImplementedException();
    }

    public bool HasParent() => ParentCommentNode is not null;

    public int ParentIndex { get; private set; }

    public int ParentTextIndex { get; private set; }

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

    public override string GetText()
    {
        return Buffer.GetText();
    }

    public override int GetTextLength()
    {
        return Buffer.Length;
    }

    public override IBuffer GetTextAsBuffer()
    {
        return Buffer;
    }

    public override StringBuilder GetText(StringBuilder to)
    {
        return StringBuilderExtensions.Append(to, Buffer);
    }

    public INode CloneAsDetached()
    {
        throw new NotImplementedException();
    }

    ILeafNode ILeafNode.CloneAsAttachedTo(IInternalNode newParent, int index)
    {
        throw new NotImplementedException();
    }

    ILeafNode ILeafNode.CloneAsDetached()
    {
        throw new NotImplementedException();
    }

    INode INode.CloneAsAttachedTo(IInternalNode newParent, int index)
    {
        return CloneAsAttachedTo(newParent, index);
    }

    INode INode.CloneAsDetached()
    {
        return CloneAsDetached();
    }

    public TSelf CloneAsAttachedTo(IInternalNode newParent, int index)
    {
        throw new NotImplementedException();
    }

    public void AttachToParent(IInternalNode newParent, int parentIndex)
    {
        if (!newParent.GetType().IsAssignableFrom(typeof(TInternalNode))) //TODO: Review and adjust documentation
        {
            throw new NotSupportedException($"The type of new parent ({newParent.GetType().FullName} (runtime type))\n" +
                                            $"is not assignable to the type of {typeof(TInternalNode).FullName}.\n" +
                                            "This is required for a constrained LeafNode<TBaseNode>."); //TODO: review message
        }

        newParent.AttachChild(parentIndex, this);
    }

    public void DetachFromParent()
    {
        IEditableBuffer newBuffer = new EditableBuffer(UnderlyingBuffer.Length);
        for (int i = 0; i < UnderlyingBuffer.Length; i++)
        {
            newBuffer.Insert(i, UnderlyingBuffer[i].ToString());
        }

        ParentCommentNode = null;
        ParentIndex = -1;
        ParentTextIndex = -1;
        UnderlyingBuffer = newBuffer;
    }

    protected void CascadeTextOffsetChange(int offsetDelta)
    {
        if (offsetDelta == 0)
        {
            return;
        }

        INode node = this;
        while (node.GetParent() is not null)
        {
            node.UnsafeDangerousSetParentTextIndex(node.ParentTextIndex + offsetDelta);
            IInternalNode? parentNode = node.GetParent();
            if (parentNode is null)
            {
                return;
            }

            for (int i = node.ParentIndex; i < parentNode.NumberOfChildren; i++)
            {
                INode child = parentNode[i];
                child.UnsafeDangerousSetParentTextIndex(child.ParentTextIndex + offsetDelta);
            }

            node = parentNode;
        }
    }
}