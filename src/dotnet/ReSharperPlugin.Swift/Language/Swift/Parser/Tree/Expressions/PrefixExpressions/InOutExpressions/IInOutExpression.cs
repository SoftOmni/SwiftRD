using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PrefixExpressions.InOutExpressions;

public interface IInOutExpression : IReadOnlyInOutExpression, IPrefixExpression
{
    new IPrimaryExpression PrimaryExpression { get; }

    void ChangePrimaryExpression(IPrimaryExpression newPrimaryExpression);
}
