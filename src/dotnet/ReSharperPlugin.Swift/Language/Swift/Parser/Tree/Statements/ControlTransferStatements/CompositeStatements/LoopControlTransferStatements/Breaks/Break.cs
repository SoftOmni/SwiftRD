using JetBrains.DocumentModel.Impl;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.ControlTransferStatements.LoopControlTransferStatements.Breaks;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.ControlTransferStatements;

public class Break : StatementLeafNode, ISwiftKeywordNode
{
    public const string Keyword = "break";
    
    public BreakStatement? BreakStatement { get; internal set; }
    
    internal Break(IEditableBuffer buffer)
        : base(buffer, SwiftNodeTypes.Break)
    { }

    internal Break(SwiftInternalNode parent, IEditableBuffer buffer)
        : base(parent, buffer, SwiftNodeTypes.Break)
    {
        if (parent is BreakStatement breakStatement)
        {
            BreakStatement = breakStatement;
        }
    }

    internal Break(BreakStatement breakStatement, IEditableBuffer buffer)
        : base(breakStatement, buffer, SwiftNodeTypes.Break)
    {
        BreakStatement = breakStatement;
    }

    public string KeywordValue => Keyword;

    public static Break Create()
    {
        return new Break(new EditableBuffer(Keyword));
    }
    
    public static Break Create(SwiftInternalNode parent)
    {
        return new Break(parent, new EditableBuffer(Keyword));
    }
    
    public static Break CreateUnchecked(BreakStatement parent)
    {
        return new Break(parent, new EditableBuffer(Keyword));
    }
}