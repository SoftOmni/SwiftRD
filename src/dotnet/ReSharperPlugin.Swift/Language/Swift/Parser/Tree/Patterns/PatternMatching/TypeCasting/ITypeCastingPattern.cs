using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Patterns.PatternMatching.TypeCasting;

public interface ITypeCastingPattern : IReadOnlyTypeCastingPattern, IPatternMatchingPattern
{
    void SetType(IType type);
}
