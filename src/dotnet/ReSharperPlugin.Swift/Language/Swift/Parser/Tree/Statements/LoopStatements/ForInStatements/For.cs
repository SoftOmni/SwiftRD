using JetBrains.DocumentModel.Impl;
using JetBrains.Text;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.LoopStatements.ForInStatements;

public class For : SwiftLeafNode, ISwiftKeywordNode
{
    public const string Keyword = "for";
    
    public ForInStatement? ForInStatement { get; internal set; }

    internal For(IEditableBuffer buffer) 
        : base(buffer, SwiftNodeTypes.For)
    { }

    internal For(SwiftInternalNode parent, IEditableBuffer buffer)
        : base(parent, buffer, SwiftNodeTypes.For)
    {
        if (parent is ForInStatement forInStatement)
        {
            ForInStatement = forInStatement;
        }
    }

    internal For(ForInStatement parent, IEditableBuffer buffer)
        : base(parent, buffer, SwiftNodeTypes.For)
    {
        ForInStatement = parent;
    }

    public string KeywordValue => Keyword;

    public static For Create()
    {
        return new For(new EditableBuffer(Keyword));
    }

    public static For Create(ForInStatement forInStatement)
    {
        return new For(forInStatement, new EditableBuffer(Keyword));
    }

    public static For CreateUnchecked(SwiftInternalNode parent)
    {
        return new For(parent, new EditableBuffer(Keyword));
    }
}