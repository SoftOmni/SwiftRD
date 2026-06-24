namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.Wildcards;

public interface IReadOnlyWildcardExpression : IReadOnlyPrimaryExpression
{
    Wildcard Wildcard { get; }
}
