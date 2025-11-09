using JetBrains.DocumentModel.Impl;
using JetBrains.Text;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Declarations.PrecedenceGroups.Associativity;

public class None : SwiftLeafNode, ISwiftKeyword
{
    public const string Keyword = "none";
    
    public PrecedenceGroupAssociativity? PrecedenceGroupAssociativity { get; internal set; }

    internal None(IEditableBuffer buffer) 
        : base(buffer, NodeTypes.NodeTypes.None)
    { }

    internal None(ISwiftNode parent, IEditableBuffer buffer)
        : base(parent, buffer, NodeTypes.NodeTypes.None)
    {
        if (parent is PrecedenceGroupAssociativity precedenceGroupAssociativity)
        {
            PrecedenceGroupAssociativity = precedenceGroupAssociativity;
        }
    }

    internal None(PrecedenceGroupAssociativity parent, IEditableBuffer buffer)
        : base(parent, buffer, NodeTypes.NodeTypes.None)
    {
        PrecedenceGroupAssociativity = parent;
    }

    public string KeywordValue => Keyword;

    public static None Create()
    {
        return new None(new EditableBuffer(Keyword));
    }

    public static None Create(PrecedenceGroupAssociativity precedenceGroupAssociativity)
    {
        return new None(precedenceGroupAssociativity, new EditableBuffer(Keyword));
    }

    public static None CreateUnchecked(ISwiftNode parent)
    {
        return new None(parent, new EditableBuffer(Keyword));
    }
}