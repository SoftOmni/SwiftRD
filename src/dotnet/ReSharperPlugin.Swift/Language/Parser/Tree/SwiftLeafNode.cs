using System;
using System.Text;
using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;

namespace ReSharperPlugin.Swift.Language.Parser.Tree;

public abstract class SwiftLeafNode : LeafElementBase, ISwiftNode
{
    internal ISwiftNode? CoreParent;
    
    protected SwiftLeafNode(IEditableBuffer editableBuffer, NodeType nodeType)
    {
        NodeType = nodeType;
        EditableBuffer = editableBuffer;
    }

    protected SwiftLeafNode(ISwiftNode parent, IEditableBuffer editableBuffer, NodeType nodeType)
    {
        CoreParent = parent;
        EditableBuffer = editableBuffer;
        NodeType = nodeType;
    }

    public ISwiftNode? GetParent()
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

    public ISwiftNode? SetChildAt(int index, ISwiftNode newNode)
    {
        throw new ArgumentOutOfRangeException(nameof(index), $"This is a leaf node, there are no children (index passed: {index})");
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

    private ISwiftNode CloneAsAttached(int index, ISwiftNode newParent)
    {
        ISwiftNode swiftNode = Clone();
        AttachToParent(index, newParent);

        return swiftNode;
    }

    public virtual ISwiftNode CloneAsAttachedToShallow(int index, ISwiftNode newParent)
    {
        return CloneAsAttached(index, newParent);
    }

    public virtual ISwiftNode CloneAsAttachedToDeep(int index, ISwiftNode newParent)
    {
        return CloneAsAttached(index, newParent);
    }

    public virtual ISwiftNode CloneAsAttachedToDeep(int index, ISwiftNode newParent, int depth)
    {
        return CloneAsAttached(index, newParent);
    }

    public virtual void AttachToParent(int parentIndex, ISwiftNode newParent)
    {
        if (newParent is not SwiftInternalNode internalNode)
        {
            throw new NotSupportedException(
                "You cannot attach to a parent node which isn't internal and thus doesn't support child attachment");
        }

        CoreParent?.DetachChild(ParentIndex);
        internalNode.AttachChild(parentIndex, this);
    }

    public void DetachChild(int childIndexInParent)
    {
        throw new NotSupportedException(
            "You cannot detach a child as this is a leaf node and there are no children");
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

