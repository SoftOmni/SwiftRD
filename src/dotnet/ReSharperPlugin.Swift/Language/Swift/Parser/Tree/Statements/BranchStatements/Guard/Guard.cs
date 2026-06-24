using JetBrains.DocumentModel.Impl;
using JetBrains.Text;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.BranchStatements.Guard;

public class Guard : StatementLeafNode, ISwiftKeywordNode
{
    public const string Keyword = "guard";
    
    public GuardStatement? GuardStatement { get; private set; }
    
    internal Guard(IEditableBuffer buffer) 
        : base(buffer, SwiftNodeTypes.Guard)
    { }

    internal Guard(SwiftInternalNode parent, IEditableBuffer buffer)
        : base(parent, buffer, SwiftNodeTypes.Guard)
    {
        if (parent is GuardStatement guardStatement)
        {
            GuardStatement = guardStatement;
        }
    }

    internal Guard(GuardStatement guardStatement, IEditableBuffer buffer)
        : base(guardStatement, buffer, SwiftNodeTypes.Guard)
    {
        GuardStatement = guardStatement;
    }

    public string KeywordValue => Keyword;

    public static Guard Create()
    {
        return new Guard(new EditableBuffer(Keyword));
    }

    public static Guard Create(GuardStatement guardStatement)
    {
        return new Guard(guardStatement, new EditableBuffer(Keyword));
    }

    public static Guard CreateUnchecked(SwiftInternalNode parent)
    {
        return new Guard(parent, new EditableBuffer(Keyword));
    }
}