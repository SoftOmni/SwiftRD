using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.ControlTransferStatements.ReturnStatements;

public interface IReturnStatement : IReadOnlyReturnStatement, IControlTransferStatement
{
    new IExpression? ReturnExpression { get; }

    void SetReturnExpressionTo(IExpression? expression);

    void RemoveReturnExpression();
}
