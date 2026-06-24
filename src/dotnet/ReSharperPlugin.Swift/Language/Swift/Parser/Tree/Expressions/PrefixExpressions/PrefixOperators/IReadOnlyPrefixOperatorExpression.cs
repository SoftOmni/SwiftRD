using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PrefixExpressions.PrefixOperators;

public interface IReadOnlyPrefixOperatorExpression : IReadOnlyPrefixExpression
{
    IReadOnlyPrefixOperator PrefixOperator { get; }
    
    IReadOnlyPostfixExpression PostfixExpression { get; }
}
