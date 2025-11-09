using JetBrains.DocumentModel.Impl;
using JetBrains.Text;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Declarations.PrecedenceGroups.Associativity;

public class Associativity : SwiftLeafNode, ISwiftKeyword
{
    public const string Keyword = "associativity";
    
    public PrecedenceGroupAssociativity? PrecedenceGroupAssociativity { get; internal set; }

    internal Associativity(IEditableBuffer buffer) 
        : base(buffer, NodeTypes.NodeTypes.Associativity)
    { }

    internal Associativity(ISwiftNode parent, IEditableBuffer buffer)
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

    public static Associativity CreateUnchecked(ISwiftNode parent)
    {
        return new Associativity(parent, new EditableBuffer(Keyword));
    }
}