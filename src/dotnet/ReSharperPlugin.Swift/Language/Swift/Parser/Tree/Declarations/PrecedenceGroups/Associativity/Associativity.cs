using JetBrains.DocumentModel.Impl;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.InternalNode;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.PrecedenceGroups.Associativity;

public class Associativity : SwiftLeafNode, ISwiftKeyword
{
    public const string Keyword = "associativity";
    
    public PrecedenceGroupAssociativity? PrecedenceGroupAssociativity { get; internal set; }

    internal Associativity(IEditableBuffer buffer) 
        : base(buffer, SwiftNodeTypes.Associativity)
    { }

    internal Associativity(SwiftInternalNode parent, IEditableBuffer buffer)
        : base(parent, buffer, SwiftNodeTypes.Associativity)
    {
        if (parent is PrecedenceGroupAssociativity precedenceGroupAssociativity)
        {
            PrecedenceGroupAssociativity = precedenceGroupAssociativity;
        }
    }

    internal Associativity(PrecedenceGroupAssociativity parent, IEditableBuffer buffer)
        : base(parent, buffer, SwiftNodeTypes.Associativity)
    {
        PrecedenceGroupAssociativity = parent;
    }

    public string KeywordValue => Keyword;

    public static Associativity Create()
    {
        return new Associativity(new EditableBuffer(Keyword));
    }

    public static Associativity Create(PrecedenceGroupAssociativity precedenceGroupAssociativity)
    {
        return new Associativity(precedenceGroupAssociativity, new EditableBuffer(Keyword));
    }

    public static Associativity CreateUnchecked(SwiftInternalNode parent)
    {
        return new Associativity(parent, new EditableBuffer(Keyword));
    }
}