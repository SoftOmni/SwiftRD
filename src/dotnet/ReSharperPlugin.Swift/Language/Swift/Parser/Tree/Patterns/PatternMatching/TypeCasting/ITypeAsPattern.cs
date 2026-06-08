namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Patterns.PatternMatching.TypeCasting;

public interface ITypeAsPattern : IReadOnlyTypeAsPattern, ITypeCastingPattern
{
    void SetPattern(IPattern pattern);
}