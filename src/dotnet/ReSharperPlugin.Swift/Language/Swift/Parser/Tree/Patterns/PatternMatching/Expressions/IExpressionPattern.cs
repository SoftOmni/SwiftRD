using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Patterns.PatternMatching.Expressions;

public interface IExpressionPattern : IReadOnlyExpressionPattern
{
    new IExpression Expression { get; }

    void SetExpression(IExpression expression);
}