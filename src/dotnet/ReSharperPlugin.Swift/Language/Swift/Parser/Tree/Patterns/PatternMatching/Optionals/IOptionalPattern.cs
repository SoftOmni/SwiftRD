using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Patterns.Destructuring.Identifiers;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Patterns.PatternMatching.Optionals;

public interface IOptionalPattern : IReadOnlyOptionalPattern, IPatternMatchingPattern
{
    new IIdentifierPattern IdentifierPattern { get; }

    void SetIdentifierPattern(IIdentifierPattern identifierPattern);
}