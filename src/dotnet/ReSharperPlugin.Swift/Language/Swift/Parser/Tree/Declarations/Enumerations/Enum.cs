using JetBrains.DocumentModel.Impl;
using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Parser.Tree.Base.InternalNode;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Declarations.Enumerations;

public class Enum : SwiftLeafNode, ISwiftKeyword
{
    public const string Keyword = "enum";
    
    public Enumeration? Enumeration { get; internal set; }

    internal Enum(IEditableBuffer buffer) 
        : base(buffer, NodeTypes.NodeTypes.Enum)
    { }

    internal Enum(SwiftInternalNode parent, IEditableBuffer buffer)
        : base(parent, buffer, NodeTypes.NodeTypes.Enum)
    {
        if (parent is Enumeration enumeration)
        {
            Enumeration = enumeration;
        }
    }

    internal Enum(Enumeration parent, IEditableBuffer buffer)
        : base(parent, buffer, NodeTypes.NodeTypes.Enum)
    {
        Enumeration = parent;
    }

    public string KeywordValue => Keyword;

    public static Enum Create()
    {
        return new Enum(new EditableBuffer(Keyword));
    }

    public static Enum Create(Enumeration enumeration)
    {
        return new Enum(enumeration, new EditableBuffer(Keyword));
    }

    public static Enum CreateUnchecked(SwiftInternalNode parent)
    {
        return new Enum(parent, new EditableBuffer(Keyword));
    }
}