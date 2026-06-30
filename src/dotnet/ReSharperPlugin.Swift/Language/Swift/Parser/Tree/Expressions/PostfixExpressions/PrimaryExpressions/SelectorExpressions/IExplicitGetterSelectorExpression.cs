using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions;

namespace SoftOmni.SwiftRd.Rider.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.SelectorExpressions;

public interface IExplicitGetterSelectorExpression : IReadOnlyExplicitGetterSelectorExpression, ISelectorExpression
{
    new IExpression GetterArgumentValue { get; }

    void ChangeGetterArgumentValue(IExpression newValue);
}
