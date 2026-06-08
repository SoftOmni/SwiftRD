using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.InfixExpressions.TypeCastingOperators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Patterns.PatternMatching.TypeCasting;

public interface IReadOnlyTypeAsPattern : IReadOnlyTypeCastingPattern
{
    IPattern? Pattern { get; }
    
    As? As { get; }
}