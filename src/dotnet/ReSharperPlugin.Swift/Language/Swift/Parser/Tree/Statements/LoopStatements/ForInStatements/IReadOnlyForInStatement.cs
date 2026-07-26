using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Enumerations.Cases;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.ClosureExpressions;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Patterns;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.BranchStatements.Switches.WhereClauses;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.LoopStatements.ForInStatements;

public interface IReadOnlyForInStatement : IReadOnlyLoopStatement
{
    For For { get; }
    
    Case? Case { get; }
    
    IReadOnlyPattern Pattern { get; }
    
    In In { get; }
    
    IReadOnlyExpression? Expression { get; }
    
    IReadOnlyWhereClause? WhereClause { get; }
}
