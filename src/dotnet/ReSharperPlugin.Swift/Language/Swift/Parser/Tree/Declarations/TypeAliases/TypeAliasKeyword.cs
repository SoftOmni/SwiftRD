using JetBrains.DocumentModel.Impl;
using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Parser.Tree.Base.InternalNode;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Declarations.TypeAliases;

public class TypeAliasKeyword : SwiftLeafNode, ISwiftKeyword
{
    public const string Keyword = "typealias";
    
    public TypeAlias? TypeAlias { get; internal set; }

    internal TypeAliasKeyword(IEditableBuffer buffer) 
        : base(buffer, NodeTypes.NodeTypes.Typealias)
    { }

    internal TypeAliasKeyword(SwiftInternalNode parent, int parentIndex, int parentTextIndex, IEditableBuffer buffer)
        : base(parent, parentIndex, parentTextIndex, buffer, NodeTypes.NodeTypes.Typealias)
    {
        if (parent is TypeAlias typeAlias)
        {
            TypeAlias = typeAlias;
        }
    }

    internal TypeAliasKeyword(TypeAlias parent, int parentIndex, int parentTextIndex, IEditableBuffer buffer)
        : base(parent, parentIndex, parentTextIndex, buffer, NodeTypes.NodeTypes.Typealias)
    {
        TypeAlias = parent;
    }

    public string KeywordValue => Keyword;

    public static TypeAliasKeyword Create()
    {
        return new TypeAliasKeyword(new EditableBuffer(Keyword));
    }

    public static TypeAliasKeyword Create(TypeAlias typeAlias, int parentIndex)
    {
        return new TypeAliasKeyword(typeAlias, parentIndex, typeAlias.TextIndexOfInsertingAt(parentIndex), new EditableBuffer(Keyword));
    }

    public static TypeAliasKeyword CreateUnchecked(SwiftInternalNode parent, int parentIndex)
    {
        return new TypeAliasKeyword(parent, parentIndex, parent.TextIndexOfInsertingAt(parentIndex), new EditableBuffer(Keyword));
    }
}