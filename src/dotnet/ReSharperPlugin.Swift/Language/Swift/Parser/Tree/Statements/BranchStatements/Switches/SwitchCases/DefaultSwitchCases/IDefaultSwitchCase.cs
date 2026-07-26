using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.StatementGroups;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.BranchStatements.Switches.SwitchCases.DefaultSwitchCases;

public interface IDefaultSwitchCase : IReadOnlyDefaultSwitchCase
{
    new IDefaultLabel DefaultLabel { get; }
    
    new IStatementGroup Statements { get; }

    void ChangeDefaultLabel(IDefaultLabel newDefaultLabel);

    void ChangeStatementGroup(IStatementGroup newStatementGroup);
}
