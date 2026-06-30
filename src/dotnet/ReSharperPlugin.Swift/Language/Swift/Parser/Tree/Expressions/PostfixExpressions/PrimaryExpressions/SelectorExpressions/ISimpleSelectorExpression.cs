using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions;

namespace SoftOmni.SwiftRd.Rider.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.SelectorExpressions;

public interface ISimpleSelectorExpression : IReadOnlySimpleSelectorExpression, ISelectorExpression
{
    new IExpression MainExpressionArgumentValue { get; }

    void ChangeMainExpressionArgumentValue();
}
