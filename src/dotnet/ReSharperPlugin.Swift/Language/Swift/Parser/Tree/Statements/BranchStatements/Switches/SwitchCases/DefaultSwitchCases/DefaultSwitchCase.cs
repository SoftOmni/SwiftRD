using System;
using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.StatementGroups;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.BranchStatements.Switches.SwitchCases.
    DefaultSwitchCases;

public class DefaultSwitchCase : SwiftCompositeNode, IDefaultSwitchCase
{
    public IDefaultLabel DefaultLabel { get; }

    public IStatementGroup Statements { get; }

    internal DefaultSwitchCase(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        IDefaultLabel defaultLabel, IStatementGroup statements)
        : base(buffer, children)
    {
        DefaultLabel = defaultLabel;
        Statements = statements;
    }

    IReadOnlyDefaultLabel IReadOnlyDefaultSwitchCase.DefaultLabel => DefaultLabel;

    IReadOnlyStatementGroup IReadOnlyDefaultSwitchCase.Statements => Statements;

    public void ChangeDefaultLabel(IDefaultLabel newDefaultLabel)
    {
        throw new NotImplementedException();
    }

    public void ChangeStatementGroup(IStatementGroup newStatementGroup)
    {
        throw new NotImplementedException();
    }
}
