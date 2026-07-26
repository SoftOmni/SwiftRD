using System.Collections.Generic;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Patterns;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.BranchStatements.Switches.WhereClauses;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.BranchStatements.Switches.SwitchCases.
    GenericSwitchCases;

public interface IReadOnlyCaseItemList :
    IReadOnlyList<(IReadOnlyPattern pattern, IReadOnlyWhereClause? whereClause)>
{
    IReadOnlyList<(IReadOnlyPattern pattern, IReadOnlyWhereClause? whereClause)> CaseItems { get; }
    
    IReadOnlyList<Comma> CaseItemSeparators { get; }
}
