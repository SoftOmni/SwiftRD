using System;
using System.Text;
using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;

namespace ReSharperPlugin.Swift.Language.Parser.Tree;

public abstract class SwiftLeafNode : LeafElementBase, ISwiftNode
{
    internal SwiftInternalNode? CoreParent;
    
    protected SwiftLeafNode(IEditableBuffer editableBuffer, NodeType nodeType)
    {
        ParentIndex = SwiftNodeBasesCommonConstants.NoParentIndex;
        ParentTextIndex = SwiftNodeBasesCommonConstants.NoParentIndex;
        NodeType = nodeType;
        EditableBuffer = editableBuffer;
    }

    protected SwiftLeafNode(SwiftInternalNode parent, int parentIndex, int parentTextIndex, IEditableBuffer editableBuffer, NodeType nodeType)
    {
        ParentIndex = parentIndex;
        ParentTextIndex = parentTextIndex;
        CoreParent = parent;
        EditableBuffer = editableBuffer;
        NodeType = nodeType;
    }

    public SwiftInternalNode? GetParent()
    {
        return CoreParent;
    }

    public bool HasParent()
    {
        return CoreParent is not null;
    }

    public int ParentIndex { get; internal set; }

    public int ParentTextIndex { get; internal set; }

    public override string GetText()
    {
        return Buffer.GetText();
    }

    public override StringBuilder GetText(StringBuilder to)
    {
        return StringBuilderExtensions.Append(Buffer, to);
    }

    public override int GetTextLength()
    {
        return Buffer.Length;
    }

    public override IBuffer GetTextAsBuffer()
    {
        return Buffer;
    }

    public IBuffer GetBuffer()
    {
        return Buffer;
    }

    public override NodeType NodeType { get; }

    public override PsiLanguageType Language => SwiftLanguage.Instance!;

    public IBuffer Buffer => EditableBuffer;
    
    internal IEditableBuffer EditableBuffer { get; set; }
    
    public int NumberOfChildren() => 0;

    public ISwiftNode this[int index]
    {
        get => GetChildAt(index);
        set => SetChildAt(index, value);
    }

    public ISwiftNode GetChildAt(int index)
    {
        throw new ArgumentOutOfRangeException(nameof(index), $"This is a leaf node, there are no children (index passed: {index})");
    }

    public ISwiftNode SetChildAt(int index, ISwiftNode newNode)
    {
        throw new ArgumentOutOfRangeException(nameof(index), $"This is a leaf node, there are no children (index passed: {index})");
    }

    protected void ClearBuffer()
    {
        EditableBuffer.Remove(0, EditableBuffer.Length);
    }

    protected abstract ISwiftNode Clone();
    
    public ISwiftNode CloneAsDetachedShallow()
    {
        return Clone();
    }

    public ISwiftNode CloneAsDetachedDeep()
    {
        return Clone();
    }

    public ISwiftNode CloneAsDetachedDeep(int _)
    {
        return Clone();
    }

    private ISwiftNode CloneAsAttached(int index, SwiftInternalNode newParent)
    {
        ISwiftNode swiftNode = Clone();
        AttachToParent(newParent, index);

        return swiftNode;
    }

    public virtual ISwiftNode CloneAsAttachedToShallow(int index, SwiftInternalNode newParent)
    {
        return CloneAsAttached(index, newParent);
    }

    public virtual ISwiftNode CloneAsAttachedToDeep(int index, SwiftInternalNode newParent)
    {
        return CloneAsAttached(index, newParent);
    }

    public virtual ISwiftNode CloneAsAttachedToDeep(int index, SwiftInternalNode newParent, int depth)
    {
        return CloneAsAttached(index, newParent);
    }

    public virtual void AttachToParent(SwiftInternalNode newParent, int parentIndex)
    {
        CoreParent?.DetachChild(ParentIndex);
        newParent.AttachChild(parentIndex, this);
    }

    public void DetachChild(int childIndex)
    {
        throw new NotSupportedException(
            "You cannot detach a child as this is a leaf node and there are no children");
    }

    public void DetachFromParent()
    {
        CoreParent?.DetachChild(ParentIndex);
    }
    
    internal void DetachFromParentForcibly()
    {
        CoreParent?.DetachChildForcibly(ParentIndex);
    }
    
}

public static class StringBuilderExtensions
{
    public static StringBuilder Append(IBuffer buffer, StringBuilder stringBuilder)
    {
        for (int i = 0; i < buffer.Length; i++)
        {
            stringBuilder.Append(buffer[i]);
        }

        return stringBuilder;
    }
}

