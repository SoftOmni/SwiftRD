using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.ControlTransferStatements.ThrowStatements;

public interface IThrowStatement : IReadOnlyThrowStatement, IControlTransferStatement
{
    new IExpression Expression { get; }

    void ChangeExpression(IExpression expression);
}
