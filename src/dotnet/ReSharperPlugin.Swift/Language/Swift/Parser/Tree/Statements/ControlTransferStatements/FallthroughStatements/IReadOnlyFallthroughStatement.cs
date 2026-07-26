namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.ControlTransferStatements.Fallthroughs;

public interface IReadOnlyFallthroughStatement : IReadOnlyControlTransferStatement
{
    Fallthrough Fallthrough { get; }
}
