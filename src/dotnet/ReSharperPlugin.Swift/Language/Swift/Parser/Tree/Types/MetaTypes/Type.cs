using JetBrains.DocumentModel.Impl;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.InternalNode;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.MetaTypes;

public class Type : SwiftLeafNode, ISwiftKeyword
{
    public const string Keyword = "Type";
    
    public TypeMetaType? TypeMetaType { get; internal set; }

    internal Type(IEditableBuffer buffer) 
        : base(buffer, SwiftNodeTypes.Type)
    { }

    internal Type(SwiftInternalNode parent, IEditableBuffer buffer)
        : base(parent, buffer, SwiftNodeTypes.Type)
    {
        if (parent is TypeMetaType typeMetaType)
        {
            TypeMetaType = typeMetaType;
        }
    }

    internal Type(TypeMetaType parent, IEditableBuffer buffer)
        : base(parent, buffer, SwiftNodeTypes.Type)
    {
        TypeMetaType = parent;
    }

    public string KeywordValue => Keyword;

    public static Type Create()
    {
        return new Type(new EditableBuffer(Keyword));
    }

    public static Type Create(TypeMetaType typeMetaType)
    {
        return new Type(typeMetaType, new EditableBuffer(Keyword));
    }

    public static Type CreateUnchecked(SwiftInternalNode parent)
    {
        return new Type(parent, new EditableBuffer(Keyword));
    }
}