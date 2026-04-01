using System;
using System.Text;
using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Extensions;
using SoftOmni.SwiftRd.Language.Base.Implementations.Flexible.Concretely.InternalNodes;
using SoftOmni.SwiftRd.Language.Base.Interfaces.Flexible.BaseNodes;
using SoftOmni.SwiftRd.Language.Base.Interfaces.Flexible.InternalNodes;
using SoftOmni.SwiftRd.Language.Base.Interfaces.Flexible.LeafNodes;

namespace SoftOmni.SwiftRd.Language.Base.Implementations.Flexible.Concretely.LeafNodes;

public abstract class LeafNode : LeafElementBase, ILeafNode
{
    protected IEditableBuffer UnderlyingBuffer;

    protected InternalNode? ParentNode;

    protected LeafNode(IEditableBuffer underlyingBuffer)
    {
        UnderlyingBuffer = underlyingBuffer;
        ParentNode = null;
        ParentIndex = -1;
        ParentTextIndex = -1;
    }

    protected LeafNode(IEditableBuffer underlyingBuffer, InternalNode parentNode, int parentIndex, int parentTextIndex)
    {
        UnderlyingBuffer = underlyingBuffer;
        ParentNode = parentNode;
        ParentIndex = parentIndex;
        ParentTextIndex = parentTextIndex;
    }

    public IInternalNode? GetParent() => ParentNode;

    public bool HasParent() => ParentNode is not null;

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

    public abstract ILeafNode CloneAsDetached();

    public abstract ILeafNode CloneAsAttachedTo(IInternalNode newParent, int index);

    public void AttachToParent(IInternalNode newParent, int parentIndex)
    {
        newParent.AttachChild(parentIndex, this);
    }

    public void DetachFromParent()
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

    INode INode.CloneAsDetached()
    {
        return CloneAsDetached();
    }

    INode INode.CloneAsAttachedTo(IInternalNode newParent, int index)
    {
        return CloneAsAttachedTo(newParent, index);
    }

    public override string GetText()
    {
        return UnderlyingBuffer.ToString();
    }

    public override IBuffer GetTextAsBuffer()
    {
        return UnderlyingBuffer;
    }

    public override int GetTextLength()
    {
        return UnderlyingBuffer.Length;
    }

    public override StringBuilder GetText(StringBuilder to)
    {
        return StringBuilderExtensions.Append(to, UnderlyingBuffer);
    }
}