using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Patterns;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.BranchStatements.Switches.WhereClauses;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.DoStatements.CatchClauses;

public class CatchPattern : SwiftCompositeNode, ICatchPattern
{
    public IPattern Pattern { get; }
    
    public IWhereClause? WhereClause { get; }

    internal CatchPattern(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children, 
        IPattern pattern, IWhereClause? whereClause = null)
        : base(buffer, children)
    {
        Pattern = pattern;
        WhereClause = whereClause;
    }

    IReadOnlyPattern IReadOnlyCatchPattern.Pattern => Pattern;

    IReadOnlyWhereClause? IReadOnlyCatchPattern.WhereClause => WhereClause;

    public void ChangePattern(IPattern newPattern)
    {
        throw new System.NotImplementedException();
    }

    public void SetWhereClauseTo(IWhereClause? whereClause)
    {
        throw new System.NotImplementedException();
    }

    public void RemoveWhereClause()
    {
        throw new System.NotImplementedException();
    }
}
