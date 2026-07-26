using System.Collections.Generic;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Patterns;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.BranchStatements.Switches.WhereClauses;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.BranchStatements.Switches.SwitchCases.GenericSwitchCases;

public interface ICaseItemList : IReadOnlyCaseItemList, 
    IList<(IPattern pattern, IWhereClause? whereClause)>
{
    new IReadOnlyList<(IPattern pattern, IWhereClause? whereClause)> CaseItems { get; }
    
    new int Count { get; }

    new IEnumerator<(IPattern pattern, IWhereClause? whereClause)> GetEnumerator();
    
    new (IPattern pattern, IWhereClause? whereClause) this[int index] { get; }

    void SetPatternAt(int index, IPattern newPattern);

    void SetWhereClauseAt(int index, IWhereClause? newWhereClause);

    void RemoveWhereClauseAt(int index);
}
