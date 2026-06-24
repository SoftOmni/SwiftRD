using JetBrains.DocumentModel.Impl;
using JetBrains.Text;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Enumerations;

public class Enum : SwiftLeafNode, ISwiftKeywordNode
{
    public const string Keyword = "enum";
    
    public Enumeration? Enumeration { get; internal set; }

    internal Enum(IEditableBuffer buffer) 
        : base(buffer, SwiftNodeTypes.Enum)
    { }

    internal Enum(SwiftInternalNode parent, IEditableBuffer buffer)
        : base(parent, buffer, SwiftNodeTypes.Enum)
    {
        if (parent is Enumeration enumeration)
        {
            Enumeration = enumeration;
        }
    }

    internal Enum(Enumeration parent, IEditableBuffer buffer)
        : base(parent, buffer, SwiftNodeTypes.Enum)
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