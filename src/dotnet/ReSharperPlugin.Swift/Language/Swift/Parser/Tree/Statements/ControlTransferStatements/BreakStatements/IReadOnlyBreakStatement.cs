using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Identifiers;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.ControlTransferStatements.BreakStatements;

public interface IReadOnlyBreakStatement : IReadOnlyControlTransferStatement
{
    Break Break { get; }
    
    IReadOnlyIdentifier? Label { get; }
}
