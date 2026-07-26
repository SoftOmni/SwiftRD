using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.StatementGroups;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.BranchStatements.Switches.SwitchCases.DefaultSwitchCases;

public interface IReadOnlyDefaultSwitchCase
{
    IReadOnlyDefaultLabel DefaultLabel { get; }
    
    IReadOnlyStatementGroup Statements { get; }
}
