using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.InfixExpressions;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PrefixExpressions;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.TryOperators;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.LoopStatements.Conditions;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions;

public interface IExpression : IReadOnlyExpression, IBaseExpression, ICondition
{
    new ITryExpression? AccompanyingTryExpression { get; }
    
    new IAwaitExpression? AwaitExpression { get; }
    
    new IPrefixExpression PrefixExpression { get; }
    
    new IInfixExpressionGroup InfixExpressionGroup { get; }

    bool AddTryExpression(IReadOnlyTryExpression.ExpressionKind kind);

    bool AddTryExpression(ITryExpression tryExpression);

    void RemoveTryExpression();

    void MakeExpressionAwaitable();

    void MakeExpressionNonAwaitable();

    void ChangePrefixExpression(IPrefixExpression prefixExpression);
}
