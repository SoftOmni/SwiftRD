using JetBrains.DocumentModel.Impl;
using JetBrains.Text;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.PrecedenceGroups.Associativity;

public class Left : SwiftLeafNode, ISwiftKeywordNode
{
    public const string Keyword = "left";
    
    public PrecedenceGroupAssociativity? PrecedenceGroupAssociativity { get; internal set; }

    internal Left(IEditableBuffer buffer) 
        : base(buffer, SwiftNodeTypes.Left)
    { }

    internal Left(SwiftInternalNode parent, IEditableBuffer buffer)
        : base(parent, buffer, SwiftNodeTypes.Left)
    {
        if (parent is PrecedenceGroupAssociativity precedenceGroupAssociativity)
        {
            PrecedenceGroupAssociativity = precedenceGroupAssociativity;
        }
    }

    internal Left(PrecedenceGroupAssociativity parent, IEditableBuffer buffer)
        : base(parent, buffer, SwiftNodeTypes.Left)
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

    public static Left CreateUnchecked(SwiftInternalNode parent)
    {
        return new Left(parent, new EditableBuffer(Keyword));
    }
}