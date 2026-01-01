using JetBrains.DocumentModel.Impl;
using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Parser.Tree.Base.InternalNode;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Statements.ControlTransferStatements.LoopControlTransferStatements.Continues;

public class Continue : StatementLeafNode, ISwiftKeyword
{
    public const string Keyword = "continue";
    
    public ContinueStatement? ContinueStatement { get; internal set; }
    
    internal Continue(IEditableBuffer buffer)
        : base(buffer, NodeTypes.NodeTypes.Continue)
    { }

    internal Continue(SwiftInternalNode parent, IEditableBuffer buffer)
        : base(parent, buffer, NodeTypes.NodeTypes.Continue)
    {
        if (parent is ContinueStatement continueStatement)
        {
            ContinueStatement = continueStatement;
        }
    }

    internal Continue(ContinueStatement continueStatement, IEditableBuffer buffer)
        : base(continueStatement, buffer, NodeTypes.NodeTypes.Continue)
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