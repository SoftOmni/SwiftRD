using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PrefixExpressions;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.TryOperators;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.InfixExpressions.AssignmentExpressions;

public interface IReadOnlyAssignmentOperatorExpression : IReadOnlyInfixExpression
{
    Equal Equal { get; }
    
    IReadOnlyTryExpression? AccompanyingTryExpression { get; }
    
    IReadOnlyAwaitExpression? AccompanyingAwaitExpression { get; }
    
    IReadOnlyPrefixExpression PrefixExpression { get; }
}
