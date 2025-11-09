using System;
using System.Text;
using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;

namespace ReSharperPlugin.Swift.Language.Parser.Tree;

public abstract class SwiftLeafNode : LeafElementBase, ISwiftNode
{
    private ISwiftNode? _parent;
    
    protected SwiftLeafNode(IEditableBuffer buffer, NodeType nodeType)
    {
        NodeType = nodeType;
        Buffer = buffer;
    }

    protected SwiftLeafNode(ISwiftNode parent, IEditableBuffer buffer, NodeType nodeType)
    {
        _parent = parent;
        Buffer = buffer;
        NodeType = nodeType;
    }

    public ISwiftNode? GetParent()
    {
        return _parent;
    }

    public bool HasParent()
    {
        return _parent is not null;
    }

    public ISwiftNode? SetParent(ISwiftNode newParent)
    {
        throw new NotImplementedException();
    }

    public override int GetTextLength()
    {
        return Buffer.Length;
    }

    public override StringBuilder GetText(StringBuilder to)
    {
        return StringBuilderExtensions.Append(to, Buffer);
    }

    public override IBuffer GetTextAsBuffer()
    {
        return Buffer;
    }

    public override string GetText()
    {
        return Buffer.GetText();
    }

    public override NodeType NodeType { get; }

    public override PsiLanguageType Language => SwiftLanguage.Instance!;

    public IEditableBuffer Buffer { get; }
    
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
}