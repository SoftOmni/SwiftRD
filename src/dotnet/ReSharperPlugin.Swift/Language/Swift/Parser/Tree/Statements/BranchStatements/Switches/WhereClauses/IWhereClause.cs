using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.BranchStatements.Switches.WhereClauses;

public interface IWhereClause : IReadOnlyWhereClause
{
    new IExpression Expression { get; }

    void ChangeExpression(IExpression newExpression);
}
