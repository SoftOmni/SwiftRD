using JetBrains.DocumentModel.Impl;
using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Parser.Tree.Base.InternalNode;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Declarations.PrecedenceGroups.Associativity;

public class Right : SwiftLeafNode, ISwiftKeyword
{
    public const string Keyword = "right";
    
    public PrecedenceGroupAssociativity? PrecedenceGroupAssociativity { get; internal set; }

    internal Right(IEditableBuffer buffer) 
        : base(buffer, NodeTypes.NodeTypes.Right)
    { }

    internal Right(SwiftInternalNode parent, IEditableBuffer buffer)
        : base(parent, buffer, NodeTypes.NodeTypes.Right)
    {
        if (parent is PrecedenceGroupAssociativity precedenceGroupAssociativity)
        {
            PrecedenceGroupAssociativity = precedenceGroupAssociativity;
        }
    }

    internal Right(PrecedenceGroupAssociativity parent, IEditableBuffer buffer)
        : base(parent, buffer, NodeTypes.NodeTypes.Right)
    {
        PrecedenceGroupAssociativity = parent;
    }

    public string KeywordValue => Keyword;

    public static Right Create()
    {
        return new Right(new EditableBuffer(Keyword));
    }

    public static Right Create(PrecedenceGroupAssociativity precedenceGroupAssociativity)
    {
        return new Right(precedenceGroupAssociativity, new EditableBuffer(Keyword));
    }

    public static Right CreateUnchecked(SwiftInternalNode parent)
    {
        return new Right(parent, new EditableBuffer(Keyword));
    }
}