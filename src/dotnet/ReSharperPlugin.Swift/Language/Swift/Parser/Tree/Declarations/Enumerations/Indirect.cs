using JetBrains.DocumentModel.Impl;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Enumerations;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Indirecterations;

public class Indirect : SwiftLeafNode, ISwiftKeywordNode
{
    public const string Keyword = "indirect";
    
    public UnionStyleEnumeration? UnionStyleEnumeration { get; internal set; }

    internal Indirect(IEditableBuffer buffer) 
        : base(buffer, SwiftNodeTypes.Indirect)
    { }

    internal Indirect(SwiftInternalNode parent, IEditableBuffer buffer)
        : base(parent, buffer, SwiftNodeTypes.Indirect)
    {
        if (parent is UnionStyleEnumeration unionStyleEnumeration)
        {
            UnionStyleEnumeration = unionStyleEnumeration;
        }
    }

    internal Indirect(UnionStyleEnumeration parent, IEditableBuffer buffer)
        : base(parent, buffer, SwiftNodeTypes.Indirect)
    {
        UnionStyleEnumeration = parent;
    }

    public string KeywordValue => Keyword;

    public static Indirect Create()
    {
        return new Indirect(new EditableBuffer(Keyword));
    }

    public static Indirect Create(UnionStyleEnumeration indirecteration)
    {
        return new Indirect(indirecteration, new EditableBuffer(Keyword));
    }

    public static Indirect CreateUnchecked(SwiftInternalNode parent)
    {
        return new Indirect(parent, new EditableBuffer(Keyword));
    }
}