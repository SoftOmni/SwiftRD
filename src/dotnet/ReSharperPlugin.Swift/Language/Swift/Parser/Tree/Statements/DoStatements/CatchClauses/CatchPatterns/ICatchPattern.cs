using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Patterns;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.BranchStatements.Switches.WhereClauses;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.DoStatements.CatchClauses;

public interface ICatchPattern : IReadOnlyCatchPattern
{
    new IPattern Pattern { get; }
    
    new IWhereClause? WhereClause { get; }

    void ChangePattern(IPattern newPattern);

    void SetWhereClauseTo(IWhereClause? whereClause);

    void RemoveWhereClause();
}