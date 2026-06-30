using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions;

namespace SoftOmni.SwiftRd.Rider.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.SelectorExpressions;

public interface IExplicitSetterSelectorExpression : IReadOnlyExplicitSetterSelectorExpression
{
    new IExpression SetterArgumentValue { get; }

    void ChangeSetterArgumentValue(IExpression expression);
}
