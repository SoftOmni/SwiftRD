using JetBrains.DocumentModel.Impl;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Generics.WhereClauses;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.BranchStatements.Switches;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Generics.GenericWhereClauseClauses;

public class Where : SwiftLeafNode, ISwiftKeywordNode
{
    public const string Keyword = "where";
    
    public GenericWhereClause? GenericWhereClause { get; internal set; }
    
    public WhereClause? WhereClause { get; internal set; } 

    internal Where(IEditableBuffer buffer) 
        : base(buffer, SwiftNodeTypes.Where)
    { }

    internal Where(SwiftInternalNode parent, IEditableBuffer buffer)
        : base(parent, buffer, SwiftNodeTypes.Where)
    {
        if (parent is GenericWhereClause genericWhereClause)
        {
            GenericWhereClause = genericWhereClause;
        }
        else if (parent is WhereClause whereClause)
        {
            WhereClause = whereClause;
        }
    }

    internal Where(GenericWhereClause parent, IEditableBuffer buffer)
        : base(parent, buffer, SwiftNodeTypes.Where)
    {
        GenericWhereClause = parent;
    }
    
    internal Where(WhereClause parent, IEditableBuffer buffer)
        : base(parent, buffer, SwiftNodeTypes.Where)
    {
        WhereClause = parent;
    }

    public string KeywordValue => Keyword;

    public static Where Create()
    {
        return new Where(new EditableBuffer(Keyword));
    }

    public static Where Create(GenericWhereClause genericWhereClause)
    {
        return new Where(genericWhereClause, new EditableBuffer(Keyword));
    }
    
    public static Where Create(WhereClause whereClause)
    {
        return new Where(whereClause, new EditableBuffer(Keyword));
    }

    public static Where CreateUnchecked(SwiftInternalNode parent)
    {
        return new Where(parent, new EditableBuffer(Keyword));
    }
}