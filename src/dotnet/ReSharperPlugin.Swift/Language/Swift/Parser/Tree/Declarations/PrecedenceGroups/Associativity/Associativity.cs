using JetBrains.DocumentModel.Impl;
using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Parser.Tree.Base.InternalNode;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Declarations.PrecedenceGroups.Associativity;

public class Associativity : SwiftLeafNode, ISwiftKeyword
{
    public const string Keyword = "associativity";
    
    public PrecedenceGroupAssociativity? PrecedenceGroupAssociativity { get; internal set; }

    internal Associativity(IEditableBuffer buffer) 
        : base(buffer, NodeTypes.NodeTypes.Associativity)
    { }

    internal Associativity(SwiftInternalNode parent, IEditableBuffer buffer)
        : base(parent, buffer, NodeTypes.NodeTypes.Associativity)
    {
        if (parent is PrecedenceGroupAssociativity precedenceGroupAssociativity)
        {
            PrecedenceGroupAssociativity = precedenceGroupAssociativity;
        }
    }

    internal Associativity(PrecedenceGroupAssociativity parent, IEditableBuffer buffer)
        : base(parent, buffer, NodeTypes.NodeTypes.Associativity)
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