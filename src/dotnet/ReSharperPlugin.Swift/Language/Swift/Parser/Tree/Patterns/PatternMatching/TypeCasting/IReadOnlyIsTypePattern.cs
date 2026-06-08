using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.InfixExpressions.TypeCastingOperators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Patterns.PatternMatching.TypeCasting;

public interface IReadOnlyIsTypePattern : IReadOnlyTypeCastingPattern
{
    Is? Is { get; }
}