using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Identifiers;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.ControlTransferStatements.ContinueStatements;

public interface IContinueStatement : IReadOnlyContinueStatement, IControlTransferStatement
{
    new IIdentifier? Label { get; }

    void ChangeLabel(IIdentifier newLabel);
}
