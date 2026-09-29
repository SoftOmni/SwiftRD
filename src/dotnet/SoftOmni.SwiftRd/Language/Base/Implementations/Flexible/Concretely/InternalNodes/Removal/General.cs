using System;
using JetBrains.DocumentModel.Impl;
using SoftOmni.SwiftRd.Language.Base.Interfaces.Flexible.BaseNodes;

namespace SoftOmni.SwiftRd.Language.Base.Implementations.Flexible.Concretely.InternalNodes;

public partial class InternalNode
{
    public INode RemoveChildAt(int index) => RemoveChildAtLoose(index);

    public void RemoveChildAtAndDiscard(int index) => RemoveChildAtLooseAndDiscard(index);

    public INode RemoveChildAt(int index, Action<INode> onChildDetachment) => RemoveChildAtLoose(index, onChildDetachment);

    public void RemoveChildAtAndDiscard(int index, Action<INode> onChildDetachment) => RemoveChildAtLooseAndDiscard(index, onChildDetachment);

    public INode RemoveChildAtLoose(int index)
    {
        CheckIndexes(index);

        INode child = _children[index];
        EditableBuffer clonedBuffer = new(child.GetTextLength());
        InsertInBuffer(clonedBuffer, child.Buffer, 0);
        child.UnsafeDangerousSetUnderlyingBuffer(clonedBuffer);

        _children.RemoveAt(index);
        for (int i = index; i < NumberOfChildren; i++)
        {
            _children[i].UnsafeDangerousSetParentIndex(i - 1);
            _children[i].UnsafeDangerousSetParentTextIndex(_children[i].ParentTextIndex - child.Buffer.Length);
        }

        return child;
    }

    public void RemoveChildAtLooseAndDiscard(int index)
    {
        CheckIndexes(index);
        int bufferLengthToSubtract = _children[index].ParentTextIndex;
        _children.RemoveAt(index);

        for (int i = index; i < NumberOfChildren; i++)
        {
            _children[i].UnsafeDangerousSetParentIndex(i - 1);
            _children[i].UnsafeDangerousSetParentTextIndex(_children[i].ParentTextIndex - bufferLengthToSubtract);
        }
    }

    public INode RemoveChildAtLoose(int index, Action<INode> onChildDetachment)
    {
        INode removedChild = RemoveChildAtLoose(index);
        onChildDetachment(removedChild);

        return removedChild;
    }

    public void RemoveChildAtLooseAndDiscard(int index, Action<INode> onChildDetachment)
    {
        CheckIndexes(index);
        int bufferLengthToSubtract = _children[index].ParentTextIndex;
        INode child = _children[index];
        _children.RemoveAt(index);

        onChildDetachment(child);

        for (int i = index; i < NumberOfChildren; i++)
        {
            _children[i].UnsafeDangerousSetParentIndex(i - 1);
            _children[i].UnsafeDangerousSetParentTextIndex(_children[i].ParentTextIndex - bufferLengthToSubtract);
        }
    }
}