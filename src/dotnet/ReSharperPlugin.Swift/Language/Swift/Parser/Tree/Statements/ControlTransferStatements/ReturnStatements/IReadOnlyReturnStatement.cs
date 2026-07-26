using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.ControlTransferStatements.ReturnStatements;

public interface IReadOnlyReturnStatement : IReadOnlyControlTransferStatement
{
    Return Return { get; }
    
    IReadOnlyExpression? ReturnExpression { get; }
}
