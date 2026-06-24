using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PrefixExpressions;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.TryOperators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.InfixExpressions.TernaryExpressions;

public interface ITernaryOperatorExpression : IReadOnlyTernaryOperatorExpression, IInfixExpression
{
    new IExpression Expression { get; }
    
    new ITryExpression? AccompanyingTryExpression { get; }
    
    new IAwaitExpression? AccompanyingAwaitExpression { get; }
    
    new IPrefixExpression PrefixExpression { get; }

    void MakeAwaiting();

    void MakeNonAwaiting();

    void SetTryExpressionTo(ITryExpression? newAccompanyingTryExpression);

    void SetTryExpressionTo(IReadOnlyTryExpression.ExpressionKind kind);

    void RemoveTryExpression();

    void ChangeExpression(IExpression newExpression);
}
