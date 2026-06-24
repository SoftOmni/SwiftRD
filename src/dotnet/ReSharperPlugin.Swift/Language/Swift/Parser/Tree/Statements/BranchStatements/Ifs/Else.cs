using JetBrains.DocumentModel.Impl;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.BranchStatements.Guard;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.BranchStatements.Ifs;

public class Else : StatementLeafNode, ISwiftKeywordNode
{
    public const string Keyword = "else";

    public ElseClause? ElseClause { get; private set; }

    public GuardStatement? GuardStatement { get; internal set; }

    internal Else(IEditableBuffer buffer)
        : base(buffer, SwiftNodeTypes.Else)
    { }

    internal Else(SwiftInternalNode parent, IEditableBuffer buffer)
        : base(parent, buffer, SwiftNodeTypes.Else)
    {
        if (parent is ElseClause elseClause)
        {
            ElseClause = elseClause;
        }
        else if (parent is GuardStatement guardStatement)
        {
            GuardStatement = guardStatement;
        }
    }

    internal Else(ElseClause elseClause, IEditableBuffer buffer)
        : base(elseClause, buffer, SwiftNodeTypes.Else)
    {
        ElseClause = elseClause;
    }

    internal Else(GuardStatement guardStatement, IEditableBuffer buffer)
        : base(guardStatement, buffer, SwiftNodeTypes.Else)
    {
        GuardStatement = guardStatement;
    }

    public string KeywordValue => Keyword;

    public static Else Create()
    {
        return new Else(new EditableBuffer(Keyword));
    }

    public static Else Create(ElseClause elseClause)
    {
        return new Else(elseClause, new EditableBuffer(Keyword));
    }

    public static Else Create(GuardStatement guardStatement)
    {
        return new Else(guardStatement, new EditableBuffer(Keyword));
    }

    public static Else CreateUnchecked(SwiftInternalNode parent)
    {
        return new Else(parent, new EditableBuffer(Keyword));
    }
}