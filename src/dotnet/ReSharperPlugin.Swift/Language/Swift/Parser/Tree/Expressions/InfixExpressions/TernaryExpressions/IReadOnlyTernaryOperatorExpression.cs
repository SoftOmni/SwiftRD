using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PrefixExpressions;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.TryOperators;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.InfixExpressions.TernaryExpressions;

public interface IReadOnlyTernaryOperatorExpression : IReadOnlyInfixExpression
{
    QuestionMark QuestionMark { get; }
    
    IReadOnlyExpression Expression { get; }
    
    Colon Colon { get; }
    
    IReadOnlyTryExpression? AccompanyingTryExpression { get; }
    
    IReadOnlyAwaitExpression? AccompanyingAwaitExpression { get; }
    
    IReadOnlyPrefixExpression PrefixExpression { get; }
}
