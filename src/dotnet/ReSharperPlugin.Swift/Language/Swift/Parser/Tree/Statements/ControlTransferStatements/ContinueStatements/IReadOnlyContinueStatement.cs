using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Identifiers;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.ControlTransferStatements.ContinueStatements;

public interface IReadOnlyContinueStatement : IReadOnlyControlTransferStatement
{
    Continue Continue { get; }
    
    IReadOnlyIdentifier? Label { get; }
}
