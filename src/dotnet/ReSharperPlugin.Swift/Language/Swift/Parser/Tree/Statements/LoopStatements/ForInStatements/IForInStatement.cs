using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Patterns;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.BranchStatements.Switches.WhereClauses;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.LoopStatements.ForInStatements;

public interface IForInStatement : IReadOnlyForInStatement, ILoopStatement
{
    new IPattern Pattern { get; }
    
    new IExpression? Expression { get; }
    
    new IWhereClause? WhereClause { get; }

    void AddExplicitCase();

    void RemoveExplicitCase();

    void ChangePattern(IPattern newPattern);

    void SetExpressionTo(IExpression newExpression);

    void RemoveExpression();

    void SetWhereClause(IWhereClause newWhereClause);

    void RemoveWhereClause();
}
