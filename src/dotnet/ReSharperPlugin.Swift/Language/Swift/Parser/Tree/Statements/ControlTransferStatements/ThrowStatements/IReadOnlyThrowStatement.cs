using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.ControlTransferStatements.ThrowStatements;

public interface IReadOnlyThrowStatement : IReadOnlyControlTransferStatement
{
    Throw Throw { get; }
    
    IReadOnlyExpression Expression { get; }
}
