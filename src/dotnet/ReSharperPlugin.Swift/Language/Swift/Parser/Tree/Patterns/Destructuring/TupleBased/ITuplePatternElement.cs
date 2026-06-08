using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Identifiers;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Patterns.Destructuring.TupleBased;

public interface ITuplePatternElement : IReadOnlyTuplePatternElement
{
    new IIdentifier? Identifier { get; }
    
    void SetIdentifier(IIdentifier identifier);

    void SetPattern(IPattern pattern);
}