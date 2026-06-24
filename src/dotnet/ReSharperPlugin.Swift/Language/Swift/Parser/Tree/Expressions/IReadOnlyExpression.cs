using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.InfixExpressions;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PrefixExpressions;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.TryOperators;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.LoopStatements.Conditions;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions;

public interface IReadOnlyExpression : IReadOnlyBaseExpression, IReadOnlyCondition
{
    IReadOnlyTryExpression? AccompanyingTryExpression { get; }
    
    IReadOnlyAwaitExpression? AwaitExpression { get; }
    
    IPrefixExpression PrefixExpression { get; }
    
    IReadOnlyInfixExpressionGroup InfixExpressionGroup { get; }
}
