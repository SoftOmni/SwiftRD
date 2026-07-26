using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.StatementGroups;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.BranchStatements.Switches.SwitchCases.GenericSwitchCases;

public interface IGenericSwitchCase : IReadOnlyGenericSwitchCase
{
    new ICaseLabel CaseLabel { get; }

    void ChangeCaseLabel(ICaseLabel newCaseLabel);
    
    new IStatementGroup Statements { get; }

    void ChangeStatementGroup(IStatementGroup newStatementGroup);
}
