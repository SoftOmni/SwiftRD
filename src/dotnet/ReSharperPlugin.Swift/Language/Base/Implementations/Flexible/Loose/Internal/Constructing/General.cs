using System.Collections.Generic;
using JetBrains.DocumentModel.Impl;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Base.Interfaces.Flexible.BaseNodes;
using SoftOmni.SwiftRd.Language.Base.Interfaces.Flexible.InternalNodes;
using SoftOmni.SwiftRd.Technology;

namespace SoftOmni.SwiftRd.Language.Base.Implementations.Flexible.Loose.InternalNodes;

public partial class InternalNode
{
    protected InternalNode()
    {
        UnderlyingBuffer = new EditableBuffer();
    }

    protected InternalNode(IEditableBuffer buffer)
    {
        UnderlyingBuffer = CloneBuffer(buffer);
    }

    protected InternalNode(IInternalNode parent, int index, IEditableBuffer editableBuffer)
    {
        UnderlyingBuffer = new EditableBuffer();
        parent.AttachChild(index, this);
        
        for (int i = 0; i < editableBuffer.Length; i++)
        {
            UnderlyingBuffer.Insert(i, editableBuffer[i].ToString());
        }
    }

    protected InternalNode(InternalNode parent, int index, IEditableBuffer editableBuffer)
    {
        UnderlyingBuffer = new EditableBuffer();
        parent.AttachChild(index, this);
        
        for (int i = 0; i < editableBuffer.Length; i++)
        {
            UnderlyingBuffer.Insert(i, editableBuffer[i].ToString());
        }
    }

    protected InternalNode(InternalNode parent, int index, int textIndex, int lengthInParent)
    {
        UnderlyingBuffer = new SubEditableBuffer(parent.UnderlyingBuffer, textIndex, lengthInParent);
        ParentTextIndex = textIndex;
        ParentIndex = index;
    }

    protected InternalNode(IEnumerator<INode> childEnumerator, bool mustDispose = true)
    {
        UnderlyingBuffer = new EditableBuffer();

        while (childEnumerator.MoveNext())
        {
            INode? currentNode = childEnumerator.Current;
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

    protected InternalNode(IEnumerable<INode> children)
    {
        UnderlyingBuffer = new EditableBuffer();
        foreach (INode child in children)
        {
            AppendChild(child);
        }
    }

    private static IEditableBuffer CloneBuffer(IEditableBuffer bufferToClone)
    {
        EditableBuffer clonedBuffer = new(bufferToClone.Length);

        for (int i = 0; i < bufferToClone.Length; i++)
        {
            clonedBuffer.Insert(i, bufferToClone[i].ToString());
        }

        return clonedBuffer;
    }
}