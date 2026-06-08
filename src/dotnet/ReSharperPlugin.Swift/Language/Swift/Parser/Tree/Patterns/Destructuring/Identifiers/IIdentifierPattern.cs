using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Identifiers;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Patterns.Destructuring.Identifiers;

public interface IIdentifierPattern : IReadOnlyIdentifierPattern
{
    new IIdentifier Identifier { get; }

    void SetIdentifier(IIdentifier identifier);
}