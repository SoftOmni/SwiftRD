using JetBrains.DocumentModel.Impl;
using JetBrains.Text;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Declarations.TypeAliases;

public class TypeAliasKeyword : SwiftLeafNode, ISwiftKeyword
{
    public const string Keyword = "typealias";
    
    public TypeAlias? TypeAlias { get; internal set; }

    internal TypeAliasKeyword(IEditableBuffer buffer) 
        : base(buffer, NodeTypes.NodeTypes.Typealias)
    { }

    internal TypeAliasKeyword(ISwiftNode parent, IEditableBuffer buffer)
        : base(parent, buffer, NodeTypes.NodeTypes.Typealias)
    {
        if (parent is TypeAlias typeAlias)
        {
            TypeAlias = typeAlias;
        }
    }

    internal TypeAliasKeyword(TypeAlias parent, IEditableBuffer buffer)
        : base(parent, buffer, NodeTypes.NodeTypes.Typealias)
    {
        TypeAlias = parent;
    }

    public string KeywordValue => Keyword;

    public static TypeAliasKeyword Create()
    {
        return new TypeAliasKeyword(new EditableBuffer(Keyword));
    }

    public static TypeAliasKeyword Create(TypeAlias typeAlias)
    {
        return new TypeAliasKeyword(typeAlias, new EditableBuffer(Keyword));
    }

    public static TypeAliasKeyword CreateUnchecked(ISwiftNode parent)
    {
        return new TypeAliasKeyword(parent, new EditableBuffer(Keyword));
    }
}