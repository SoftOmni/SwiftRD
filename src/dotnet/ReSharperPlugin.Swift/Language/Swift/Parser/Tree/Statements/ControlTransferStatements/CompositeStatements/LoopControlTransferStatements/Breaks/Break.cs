using JetBrains.DocumentModel.Impl;
using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Parser.Tree.Base.InternalNode;
using ReSharperPlugin.Swift.Language.Parser.Tree.Statements.ControlTransferStatements.LoopControlTransferStatements.Breaks;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Statements.ControlTransferStatements;

public class Break : StatementLeafNode, ISwiftKeyword
{
    public const string Keyword = "break";
    
    public BreakStatement? BreakStatement { get; internal set; }
    
    internal Break(IEditableBuffer buffer)
        : base(buffer, NodeTypes.NodeTypes.Break)
    { }

    internal Break(SwiftInternalNode parent, IEditableBuffer buffer)
        : base(parent, buffer, NodeTypes.NodeTypes.Break)
    {
        if (parent is BreakStatement breakStatement)
        {
            BreakStatement = breakStatement;
        }
    }

    internal Break(BreakStatement breakStatement, IEditableBuffer buffer)
        : base(breakStatement, buffer, NodeTypes.NodeTypes.Break)
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