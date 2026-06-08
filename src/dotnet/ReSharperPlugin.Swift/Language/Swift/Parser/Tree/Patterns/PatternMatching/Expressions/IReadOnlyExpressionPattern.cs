using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Patterns.PatternMatching.Expressions;

public interface IReadOnlyExpressionPattern : IPatternMatchingPattern
{
    IReadOnlyExpression? Expression { get; }
}