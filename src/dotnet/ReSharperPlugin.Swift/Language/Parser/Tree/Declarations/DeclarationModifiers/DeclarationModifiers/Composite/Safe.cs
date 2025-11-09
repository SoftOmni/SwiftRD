using JetBrains.DocumentModel.Impl;
using JetBrains.Text;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Declarations.DeclarationModifiers.DeclarationModifiers.Composite;

public class Safe : SwiftLeafNode, ISwiftKeyword
{
    public const string Keyword = "safe";
    
    public UnownedSafe? UnownedSafe { get; internal set; }

    internal Safe(IEditableBuffer buffer) 
        : base(buffer, NodeTypes.NodeTypes.Safe)
    { }

    internal Safe(ISwiftNode parent, IEditableBuffer buffer)
        : base(parent, buffer, NodeTypes.NodeTypes.Safe)
    {
        if (parent is UnownedSafe unownedSafe)
        {
            UnownedSafe = unownedSafe;
        }
    }

    internal Safe(UnownedSafe parent, IEditableBuffer buffer)
        : base(parent, buffer, NodeTypes.NodeTypes.Safe)
    {
        UnownedSafe = parent;
    }

    public string KeywordValue => Keyword;

    public static Safe Create()
    {
        return new Safe(new EditableBuffer(Keyword));
    }

    public static Safe Create(UnownedSafe unownedSafe)
    {
        return new Safe(unownedSafe, new EditableBuffer(Keyword));
    }

    public static Safe CreateUnchecked(ISwiftNode parent)
    {
        return new Safe(parent, new EditableBuffer(Keyword));
    }
}