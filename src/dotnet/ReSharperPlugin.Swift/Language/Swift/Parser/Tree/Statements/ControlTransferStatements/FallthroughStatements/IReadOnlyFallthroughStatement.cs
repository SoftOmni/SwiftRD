namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.ControlTransferStatements.FallthroughStatements;

public interface IReadOnlyFallthroughStatement : IReadOnlyControlTransferStatement
{
    Fallthrough Fallthrough { get; }
}
