using System;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Base.Interfaces.Flexible.BaseNodes;
using SoftOmni.SwiftRd.Language.Base.Implementations.Flexible.Loose.Base;
using SoftOmni.SwiftRd.Technology;

namespace SoftOmni.SwiftRd.Language.Base.Implementations.Flexible.Loose.InternalNodes;

public partial class InternalNode
{
    public abstract void CheckChildForAttachment(int index, INode child);
    
    public abstract void CheckChildForAttachment(int index, Node child);
    
    public abstract void CheckChildForAttachment<TNode>(int index, TNode child) where TNode : INode;
    
    public int AttachChild(int index, INode child) => AttachChildLoose(index, child);

    public int AttachChild(int index, INode child, Action<INode> actionOnAddition) => AttachChildLoose(index, child, actionOnAddition);

    public int AttachChildLoose(int index, INode child)
    {
        CheckChildForAttachment(index, child);
        return AttachChildForcibly(index, child);
    }

    public int AttachChildLoose(int index, INode child, Action<INode> actionOnAddition)
    {
        CheckChildForAttachment(index, child);
        int textBufferIndex = AttachChildForcibly(index, child);
        actionOnAddition(child);
        return textBufferIndex;
    }

    public int AttachChildConcrete(int index, Node child)
    {
        CheckChildForAttachment(index, child);
        return AttachChildForcibly(index, child);
    }

    public int AttachChildConcrete(int index, Node child, Action<Node> actionOnAddition)
    {
        CheckChildForAttachment(index, child);
        int textBufferIndex = AttachChildForcibly(index, child);
        actionOnAddition(child);
        return textBufferIndex;
    }

    public int AttachChild<TNode>(int index, TNode child)
        where TNode : INode
    {
        CheckChildForAttachment(index, child);
        return AttachChildForcibly(index, child);
    }

    public int AttachChild<TNode>(int index, TNode child, Action<TNode> actionOnAddition)
        where TNode : INode
    {
        CheckChildForAttachment(index, child);
        int textBufferIndex = AttachChildForcibly(index, child);
        actionOnAddition(child);
        return textBufferIndex;
    }

    public int AttachChildLoose<TNode>(int index, TNode child)
        where TNode : INode
    {
        CheckChildForAttachment(index, child);
        return AttachChildForcibly(index, child);
    }

    public int AttachChildLoose<TNode>(int index, TNode child, Action<TNode> actionOnAddition)
        where TNode : INode
    {
        CheckChildForAttachment(index, child);
        int textBufferIndex = AttachChildForcibly(index, child);
        actionOnAddition(child);
        return textBufferIndex;
    }

    public int AttachChildConcrete<TNode>(int index, TNode child)
        where TNode : Node
    {
        CheckChildForAttachment(index, child);
        return AttachChildForcibly(index, child);
    }

    public int AttachChildConcrete<TNode>(int index, TNode child, Action<TNode> actionOnAddition)
        where TNode : Node
    {
        CheckChildForAttachment(index, child);
        int textBufferIndex = AttachChildForcibly(index, child);
        actionOnAddition(child);
        return textBufferIndex;
    }

    protected virtual int AttachChildForcibly(int index, INode child)
    {
        if (index < 0 || index >= _children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        int textInsertionIndex;
        if (_children.Count == 0 || index == 0)
        {
            textInsertionIndex = 0;
        }
        else if (index == _children.Count)
        {
            textInsertionIndex = Buffer.Length;
        }
        else
        {
            textInsertionIndex = _children[index].ParentTextIndex;
        }
        
        InsertInBuffer(UnderlyingBuffer, child.Buffer, textInsertionIndex);
        child.UnsafeDangerousSetUnderlyingBuffer(new SubEditableBuffer(UnderlyingBuffer, textInsertionIndex, child.Buffer.Length));
        child.UnsafeDangerousSetParentIndex(index);
        child.UnsafeDangerousSetParentTextIndex(textInsertionIndex);

        for (int i = index; i < NumberOfChildren; i++)
        {
            _children[i].UnsafeDangerousSetParentIndex(_children[i].ParentIndex + 1);
            _children[i].UnsafeDangerousSetParentTextIndex(_children[i].ParentTextIndex + child.GetTextLength());
        }
        
        _children.Insert(index, child);

        return textInsertionIndex;
    }

    private static void InsertInBuffer(IEditableBuffer editableBuffer, IBuffer buffer, int index)
    {
        for (int bufferIndex = 0; bufferIndex < buffer.Length; bufferIndex++)
        {
            editableBuffer.Insert(index + bufferIndex, buffer[bufferIndex].ToString());
        }
    }
}