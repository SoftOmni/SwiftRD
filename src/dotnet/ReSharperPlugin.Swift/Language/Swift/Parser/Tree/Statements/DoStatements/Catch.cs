using JetBrains.DocumentModel.Impl;
using JetBrains.Text;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.DoStatements;

public class Catch : SwiftLeafNode, ISwiftKeywordNode
{
    public const string Keyword = "catch";
    
    public CatchClause? CatchClause { get; internal set; }

    internal Catch(IEditableBuffer buffer) 
        : base(buffer, SwiftNodeTypes.Catch)
    { }

    internal Catch(SwiftInternalNode parent, IEditableBuffer buffer)
        : base(parent, buffer, SwiftNodeTypes.Catch)
    {
        if (parent is CatchClause catchClause)
        {
            CatchClause = catchClause;
        }
    }

    internal Catch(CatchClause parent, IEditableBuffer buffer)
        : base(parent, buffer, SwiftNodeTypes.Catch)
    {
        CatchClause = parent;
    }

    public string KeywordValue => Keyword;

    public static Catch Create()
    {
        return new Catch(new EditableBuffer(Keyword));
    }

    public static Catch Create(CatchClause catchClause)
    {
        return new Catch(catchClause, new EditableBuffer(Keyword));
    }

    public static Catch CreateUnchecked(SwiftInternalNode parent)
    {
        return new Catch(parent, new EditableBuffer(Keyword));
    }
}