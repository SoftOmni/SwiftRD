using JetBrains.DocumentModel.Impl;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.InternalNode;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.ControlTransferStatements.Defers;

public class Defer : StatementLeafNode, ISwiftKeyword
{
    public const string Keyword = "defer";
    
    public DeferStatement? DeferStatement { get; internal set; }
    
    internal Defer(IEditableBuffer buffer)
        : base(buffer, SwiftNodeTypes.Defer)
    { }

    internal Defer(SwiftInternalNode parent, IEditableBuffer buffer)
        : base(parent, buffer, SwiftNodeTypes.Defer)
    {
        if (parent is DeferStatement deferStatement)
        {
            DeferStatement = deferStatement;
        }
    }

    internal Defer(DeferStatement deferStatement, IEditableBuffer buffer)
        : base(deferStatement, buffer, SwiftNodeTypes.Defer)
    {
        DeferStatement = deferStatement;
    }

    public string KeywordValue => Keyword;

    public static Defer Create()
    {
        return new Defer(new EditableBuffer(Keyword));
    }
    
    public static Defer Create(SwiftInternalNode parent)
    {
        return new Defer(parent, new EditableBuffer(Keyword));
    }
    
    public static Defer CreateUnchecked(DeferStatement parent)
    {
        return new Defer(parent, new EditableBuffer(Keyword));
    }
}