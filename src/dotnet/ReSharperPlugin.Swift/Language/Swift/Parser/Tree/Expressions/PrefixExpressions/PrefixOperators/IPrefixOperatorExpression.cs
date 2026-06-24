
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PrefixExpressions.PrefixOperators;

public interface IPrefixOperatorExpression : IReadOnlyPrefixOperatorExpression, IPrefixExpression
{
    new IPrefixOperator PrefixOperator { get; }
    
    new IPostfixExpression PostfixExpression { get; }

    void ChangeOperator(IPrefixOperator newOperator);

    void ChangePostfixExpression(IPostfixExpression newExpression);
}
