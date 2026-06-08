using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Patterns.PatternMatching.TypeCasting;

public interface IReadOnlyTypeCastingPattern : IPatternMatchingPattern
{
    IType? Type { get; }
}