using System.Collections.Generic;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.DoStatements.CatchClauses;

public interface ICatchClauseList : IReadOnlyCatchClauseList, IList<ICatchClause>
{
    new IReadOnlyList<ICatchClause> CatchClauses { get; }
    
    new int Count { get; }

    new IEnumerator<ICatchClause> GetEnumerator();
    
    new ICatchClause this[int index] { get; set; }
}
