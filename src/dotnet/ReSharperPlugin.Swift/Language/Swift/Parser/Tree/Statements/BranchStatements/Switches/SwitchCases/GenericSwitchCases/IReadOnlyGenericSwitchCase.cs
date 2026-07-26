using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.StatementGroups;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.BranchStatements.Switches.SwitchCases.GenericSwitchCases;

public interface IReadOnlyGenericSwitchCase : IReadOnlySwitchCase
{
    IReadOnlyCaseLabel CaseLabel { get; }
    
    IReadOnlyStatementGroup Statements { get; }
}
