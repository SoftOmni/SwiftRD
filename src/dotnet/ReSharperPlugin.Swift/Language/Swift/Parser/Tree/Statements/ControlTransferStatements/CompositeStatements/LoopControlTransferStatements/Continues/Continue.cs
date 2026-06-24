using JetBrains.DocumentModel.Impl;
using JetBrains.Text;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.ControlTransferStatements.LoopControlTransferStatements.Continues;

public class Continue : StatementLeafNode, ISwiftKeywordNode
{
    public const string Keyword = "continue";
    
    public ContinueStatement? ContinueStatement { get; internal set; }
    
    internal Continue(IEditableBuffer buffer)
        : base(buffer, SwiftNodeTypes.Continue)
    { }

    internal Continue(SwiftInternalNode parent, IEditableBuffer buffer)
        : base(parent, buffer, SwiftNodeTypes.Continue)
    {
        if (parent is ContinueStatement continueStatement)
        {
            ContinueStatement = continueStatement;
        }
    }

    internal Continue(ContinueStatement continueStatement, IEditableBuffer buffer)
        : base(continueStatement, buffer, SwiftNodeTypes.Continue)
    {
        ContinueStatement = continueStatement;
    }

    public string KeywordValue => Keyword;

    public static Continue Create()
    {
        return new Continue(new EditableBuffer(Keyword));
    }
    
    public static Continue Create(SwiftInternalNode parent)
    {
        return new Continue(parent, new EditableBuffer(Keyword));
    }
    
    public static Continue CreateUnchecked(ContinueStatement parent)
    {
        return new Continue(parent, new EditableBuffer(Keyword));
    }
}