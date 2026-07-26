using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Identifiers;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.ControlTransferStatements.BreakStatements;

public interface IBreakStatement : IReadOnlyBreakStatement, IControlTransferStatement
{
    new IIdentifier? Label { get; }

    void ChangeLabel(IIdentifier newLabel);
}
