using System.Collections.Generic;
using System.Text;
using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.ReSharper.Psi.Tree;
using JetBrains.Text;
using JetBrains.Util;

namespace ReSharperPlugin.Swift.Language.Parser.Tree;

public abstract class SwiftNode : TreeElement, ISwiftNode
{
    protected readonly List<ISwiftNode> _children;

    protected ISwiftNode? _parent;

    protected SwiftNode(IEditableBuffer buffer, List<ISwiftNode> children)
    {
        Buffer = buffer;
        _children = children;
        _parent = null;
    }

    protected SwiftNode(IEditableBuffer buffer, IEnumerable<ISwiftNode> children)
    {
        Buffer = buffer;
        _children = [];
        foreach (ISwiftNode child in children)
        {
            _children.Add(child);
        }

        _parent = null;
    }

    protected SwiftNode(ISwiftNode parent, IEditableBuffer buffer, List<ISwiftNode> nodes)
    {
        _parent = parent;
        Buffer = buffer;
        _children = nodes;
    }
    
    protected SwiftNode(ISwiftNode parent, IEditableBuffer buffer, IEnumerable<ISwiftNode> nodes)
    {
        _parent = parent;
        Buffer = buffer;
        _children = [];

        foreach (ISwiftNode node in nodes)
        {
            _children.Add(node);
        }
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
        ISwiftNode? previousParent = _parent;
        if (HasParent())
        {
            // TODO
        }
        
        
        return previousParent;
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

    public override string GetText()
    {
        return Buffer.GetText();
    }

    public override ITreeNode? FindNodeAt(TreeTextRange treeRange)
    {
        throw new System.NotImplementedException();
    }

    public override void FindNodesAtInternal(TreeTextRange relativeRange, List<ITreeNode> result, bool includeContainingNodes)
    {
        throw new System.NotImplementedException();
    }

    public override ITreeNode? FirstChild => _children.IsEmpty() ? null : _children[0];
    
    public override ITreeNode? LastChild => _children.IsEmpty() ? null : _children[_children.Count - 1];
    
    public override PsiLanguageType Language => SwiftLanguage.Instance!;

    public IEditableBuffer Buffer { get; }

    public int NumberOfChildren()
    {
        return _children.Count;
    }

    public ISwiftNode this[int index]
    {
        get => GetChildAt(index);
        set => SetChildAt(index, value);
    }

    public ISwiftNode GetChildAt(int index)
    {
        return _children[index];
    }

    public ISwiftNode SetChildAt(int index, ISwiftNode newNode)
    {
        ISwiftNode previousNode = _children[index];
        _children[index] = newNode;

        return previousNode;
    }
}

public static class StringBuilderExtensions
{
    public static StringBuilder Append(this StringBuilder stringBuilder, IEditableBuffer buffer)
    {
        return Append(stringBuilder, (IBuffer)buffer);
    }
    
    public static StringBuilder Append(this StringBuilder stringBuilder, IBuffer buffer)
    {
        for (int i = 0; i < buffer.Length; i++)
        {
            stringBuilder.Append(i);
        }

        return stringBuilder;
    }
}