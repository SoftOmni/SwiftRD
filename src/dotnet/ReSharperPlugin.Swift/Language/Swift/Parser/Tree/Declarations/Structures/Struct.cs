using JetBrains.DocumentModel.Impl;
using JetBrains.Text;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Structures;

public class Struct : SwiftLeafNode, ISwiftKeywordNode
{
    public const string Keyword = "struct";
    
    public Structure? Structure { get; internal set; }

    internal Struct(IEditableBuffer buffer) 
        : base(buffer, SwiftNodeTypes.Struct)
    { }

    internal Struct(SwiftInternalNode parent, IEditableBuffer buffer)
        : base(parent, buffer, SwiftNodeTypes.Struct)
    {
        if (parent is Structure structure)
        {
            Structure = structure;
        }
    }

    internal Struct(Structure parent, IEditableBuffer buffer)
        : base(parent, buffer, SwiftNodeTypes.Struct)
    {
        Structure = parent;
    }

    public string KeywordValue => Keyword;

    public static Struct Create()
    {
        return new Struct(new EditableBuffer(Keyword));
    }

    public static Struct Create(Structure structure)
    {
        return new Struct(structure, new EditableBuffer(Keyword));
    }

    public static Struct CreateUnchecked(SwiftInternalNode parent)
    {
        return new Struct(parent, new EditableBuffer(Keyword));
    }
}