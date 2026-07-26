using System;
using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.StatementGroups;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.BranchStatements.Switches.SwitchCases.
    GenericSwitchCases;

public class GenericSwitchCase : SwiftCompositeNode, IGenericSwitchCase
{
    public ICaseLabel CaseLabel { get; }

    public IStatementGroup Statements { get; }

    internal GenericSwitchCase(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        ICaseLabel caseLabel, IStatementGroup statements)
        : base(buffer, children)
    {
        CaseLabel = caseLabel;
        Statements = statements;
    }

    IReadOnlyCaseLabel IReadOnlyGenericSwitchCase.CaseLabel => CaseLabel;

    IReadOnlyStatementGroup IReadOnlyGenericSwitchCase.Statements => Statements;

    public void ChangeCaseLabel(ICaseLabel newCaseLabel)
    {
        throw new NotImplementedException();
    }

    public void ChangeStatementGroup(IStatementGroup newStatementGroup)
    {
        throw new NotImplementedException();
    }
}
