using JetBrains.DocumentModel.Impl;
using JetBrains.Text;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Declarations.PrecedenceGroups.Associativity;

public class Left : SwiftLeafNode, ISwiftKeyword
{
    public const string Keyword = "left";
    
    public PrecedenceGroupAssociativity? PrecedenceGroupAssociativity { get; internal set; }

    internal Left(IEditableBuffer buffer) 
        : base(buffer, NodeTypes.NodeTypes.Left)
    { }

    internal Left(ISwiftNode parent, IEditableBuffer buffer)
        : base(parent, buffer, NodeTypes.NodeTypes.Left)
    {
        if (parent is PrecedenceGroupAssociativity precedenceGroupAssociativity)
        {
            PrecedenceGroupAssociativity = precedenceGroupAssociativity;
        }
    }

    internal Left(PrecedenceGroupAssociativity parent, IEditableBuffer buffer)
        : base(parent, buffer, NodeTypes.NodeTypes.Left)
    {
        PrecedenceGroupAssociativity = parent;
    }

    public string KeywordValue => Keyword;

    public static Left Create()
    {
        return new Left(new EditableBuffer(Keyword));
    }

    public static Left Create(PrecedenceGroupAssociativity precedenceGroupAssociativity)
    {
        return new Left(precedenceGroupAssociativity, new EditableBuffer(Keyword));
    }

    public static Left CreateUnchecked(ISwiftNode parent)
    {
        return new Left(parent, new EditableBuffer(Keyword));
    }
}