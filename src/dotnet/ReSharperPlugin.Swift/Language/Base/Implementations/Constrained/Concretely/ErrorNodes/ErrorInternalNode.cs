using System;
using System.Collections.Generic;
using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Base.Implementations.Constrained.InternalNodes;
using SoftOmni.SwiftRd.Language.Base.Interfaces.Constrained;
using SoftOmni.SwiftRd.Language.Base.Interfaces.Constrained.InternalNodes;
using SoftOmni.SwiftRd.Language.Base.Interfaces.Constrained.LeafNodes;
using SoftOmni.SwiftRd.Language.Base.Interfaces.Constrained.Root;
using SoftOmni.SwiftRd.Language.Base.Interfaces.Flexible.BaseNodes;
using SoftOmni.SwiftRd.Language.Base.Interfaces.Flexible.ErrorNodes;
using SoftOmni.SwiftRd.Language.Base.Interfaces.Flexible.InternalNodes;
using SoftOmni.SwiftRd.Technology;

namespace SoftOmni.SwiftRd.Language.Base.Implementations.Constrained.Concretely.ErrorNodes;

public class ErrorInternalNode<TFamily, TSelf, TLeafNode> : ErrorElement, IInternalNode<TFamily, TSelf, TLeafNode>, IErrorNode
    where TFamily : INodeFamily<TFamily, TSelf, TLeafNode>
    where TSelf : InternalNode<TFamily, TSelf, TLeafNode>
    where TLeafNode : ILeafNode<TFamily, TSelf, TLeafNode>
{
    protected readonly List<INode> ChildNodes = [];

    protected TSelf? CoreParent;

    protected string Message;

    protected ErrorInternalNode(string message)
        : base(message)
    {
        UnderlyingBuffer = new EditableBuffer();
        Message = message;
    }

    protected ErrorInternalNode(IEditableBuffer buffer, string message)
        : base(message)
    {
        UnderlyingBuffer = CloneBuffer(buffer);
        Message = message;
    }

    protected ErrorInternalNode(TSelf parent, int index, IEditableBuffer editableBuffer,
        IEnumerable<INode<TFamily, TSelf, TSelf, TLeafNode>>? children = null, string message = "")
        : base(message)
    {
        UnderlyingBuffer = new EditableBuffer();
        parent.AttachChild(index, this);

        for (int i = 0; i < editableBuffer.Length; i++)
        {
            UnderlyingBuffer.Insert(i, editableBuffer[i].ToString());
        }

        Message = message;
        if (children is null)
        {
            return;
        }

        foreach (INode<TFamily, TSelf, TSelf, TLeafNode> node in children)
        {
            ChildNodes.Add(node);
        }
    }

    protected ErrorInternalNode(TSelf parent, int index, int textIndex, int lengthInParent,
        IEnumerable<INode<TFamily, TSelf, TSelf, TLeafNode>>? children = null, string message = "")
        : base(message)
    {
        UnderlyingBuffer = new SubEditableBuffer((IEditableBuffer)parent.Buffer, textIndex, lengthInParent);
        ParentTextIndex = textIndex;
        ParentIndex = index;

        Message = message;
        if (children is null)
        {
            return;
        }

        foreach (INode<TFamily, TSelf, TSelf, TLeafNode> node in children)
        {
            ChildNodes.Add(node);
        }
    }

    protected ErrorInternalNode(IEnumerator<INode<TFamily, TSelf, TSelf, TLeafNode>> childEnumerator, string message, bool mustDispose = true)
        : base(message)
    {
        UnderlyingBuffer = new EditableBuffer();
        Message = message;

        while (childEnumerator.MoveNext())
        {
            INode<TFamily, TSelf, TSelf, TLeafNode>? currentNode = childEnumerator.Current;
            if (currentNode is null)
            {
                continue;
            }

            AppendChild(currentNode);
        }

        if (mustDispose)
        {
            childEnumerator.Dispose();
        }
    }

    protected ErrorInternalNode(IEnumerable<INode<TFamily, TSelf, TSelf, TLeafNode>> children, string message)
        : base(message)
    {
        UnderlyingBuffer = new EditableBuffer();
        Message = message;
        foreach (INode<TFamily, TSelf, TSelf, TLeafNode> child in children)
        {
            AppendChild(child);
        }
    }
    
    protected ErrorInternalNode(IEditableBuffer buffer, IEnumerable<INode<TFamily, TSelf, TSelf, TLeafNode>> children, string message) 
        : base(message)
    {
        UnderlyingBuffer = buffer;
        foreach (INode<TFamily, TSelf, TSelf, TLeafNode> child in children)
        {
            ChildNodes.Add(child); // TODO: Add more powerful logic
        }
    }

    protected virtual void UpdateParentRelatedNodeConfiguration()
    {
        // Nothing to do
    }

    private void AppendChild(INode<TFamily, TSelf, TSelf, TLeafNode> child)
    {
        throw new NotImplementedException();
    }

    private static IEditableBuffer CloneBuffer(IEditableBuffer buffer)
    {
        throw new NotImplementedException();
    }

    public IBuffer Buffer => UnderlyingBuffer;

    public int ParentIndex { get; protected set; }

    public int ParentTextIndex { get; protected set; }

    public int NumberOfChildren => ChildNodes.Count;

    protected IEditableBuffer UnderlyingBuffer;

    public string GetErrorMessage()
    {
        return Message;
    }

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

    public int AttachChild(int index, INode child)
    {
        throw new NotImplementedException();
    }

    public int AttachChild(int index, INode child, Action<INode> actionOnAttachment)
    {
        throw new NotImplementedException();
    }

    public int AttachChild<TNode>(int index, TNode child)
        where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AttachChild<TNode>(int index, TNode child, Action<TNode> actionOnAttachment)
        where TNode : INode
    {
        throw new NotImplementedException();
    }

    protected virtual int AttachChildForcibly(int index, INode child)
    {
        if (index < 0 || index >= ChildNodes.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        int textInsertionIndex;
        if (ChildNodes.Count == 0 || index == 0)
        {
            textInsertionIndex = 0;
        }
        else if (index == ChildNodes.Count)
        {
            textInsertionIndex = Buffer.Length;
        }
        else
        {
            textInsertionIndex = ChildNodes[index].ParentTextIndex;
        }

        InsertInBuffer(UnderlyingBuffer, child.Buffer, textInsertionIndex);
        child.UnsafeDangerousSetUnderlyingBuffer(new SubEditableBuffer(UnderlyingBuffer, textInsertionIndex, child.Buffer.Length));
        child.UnsafeDangerousSetParentIndex(index);
        child.UnsafeDangerousSetParentTextIndex(textInsertionIndex);

        for (int i = index; i < NumberOfChildren; i++)
        {
            ChildNodes[i].UnsafeDangerousSetParentIndex(ChildNodes[i].ParentIndex + 1);
            ChildNodes[i].UnsafeDangerousSetParentTextIndex(ChildNodes[i].ParentTextIndex + child.GetTextLength());
        }

        ChildNodes.Insert(index, child);

        return textInsertionIndex;
    }

    public INode? SetChildAt(int index, INode newNode)
    {
        throw new NotImplementedException();
    }

    public void SetChildAtAndDiscard(int index, INode newNode)
    {
        throw new NotImplementedException();
    }

    public INode SetChildAt<TNode>(int index, TNode newNode)
        where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void SetChildAtAndDiscard<TNode>(int index, TNode newNode)
        where TNode : INode
    {
        throw new NotImplementedException();
    }

    public INode DetachChildAt(int index)
    {
        throw new NotImplementedException();
    }

    public TNode DetachChildAt<TNode>(int index)
        where TNode : INode
    {
        throw new NotImplementedException();
    }

    public INode DetachChildAt(int index, Action<INode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public TNode DetachChildAt<TNode>(int index, Action<INode> onChildDetachment)
        where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void DetachChildAtAndDiscard(int index)
    {
        throw new NotImplementedException();
    }

    public void DetachChildAtAndDiscard<TNode>(int index)
        where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void DetachChildAtAndDiscard(int index, Action<INode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public INode RemoveChildAt(int index)
    {
        throw new NotImplementedException();
    }

    public INode RemoveChildAt(int index, Action<INode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public void ClearChildren(int startIndex, int endIndex)
    { }

    public void RemoveChildAtAndDiscard(int index)
    {
        throw new NotImplementedException();
    }

    public void RemoveChildAtAndDiscard(int index, Action<INode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public INode GetChildAt(int index)
    {
        throw new NotImplementedException();
    }

    public int InsertChild(int index, INode child)
    {
        throw new NotImplementedException();
    }

    public int InsertChild(int index, INode child, Action<INode> actionOnAddition)
    {
        throw new NotImplementedException();
    }

    public int InsertChild<TNode>(int index, TNode child)
        where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int InsertChild<TNode>(int index, TNode child, Action<TNode> actionOnAddition)
        where TNode : INode
    {
        throw new NotImplementedException();
    }

    public bool Contains(INode child)
    {
        throw new NotImplementedException();
    }

    public bool Contains<TNode>(TNode child)
        where TNode : INode
    {
        throw new NotImplementedException();
    }

    public INode this[int index]
    {
        get => throw new NotImplementedException();
        set => throw new NotImplementedException();
    }

    public TSelf? GetParent()
    {
        throw new NotImplementedException();
    }

    public TSelf CloneAsDetached()
    {
        throw new NotImplementedException();
    }

    public TSelf CloneAsAttachedTo(TSelf newParent, int index)
    {
        throw new NotImplementedException();
    }

    public void AttachToParent(TSelf newParent, int parentIndex)
    {
        throw new NotImplementedException();
    }

    INode INode.CloneAsDetached()
    {
        throw new NotImplementedException();
    }

    IInternalNode IInternalNode.CloneAsAttachedTo(IInternalNode newParent, int index)
    {
        throw new NotImplementedException();
    }

    IInternalNode IInternalNode.CloneAsDetached()
    {
        throw new NotImplementedException();
    }

    INode INode.CloneAsAttachedTo(IInternalNode newParent, int index)
    {
        throw new NotImplementedException();
    }

    public void AttachToParent(IInternalNode newParent, int parentIndex)
    {
        throw new NotImplementedException();
    }

    public void DetachFromParent()
    {
        throw new NotImplementedException();
    }

    IInternalNode? INode.GetParent()
    {
        return GetParent();
    }

    public bool HasParent()
    {
        throw new NotImplementedException();
    }

    public override string GetText()
    {
        return Buffer.GetText();
    }

    public override int GetTextLength()
    {
        return Buffer.Length;
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

    private static void InsertInBuffer(IEditableBuffer editableBuffer, IBuffer buffer, int index)
    {
        for (int bufferIndex = 0; bufferIndex < buffer.Length; bufferIndex++)
        {
            editableBuffer.Insert(index + bufferIndex, buffer[bufferIndex].ToString());
        }
    }
}