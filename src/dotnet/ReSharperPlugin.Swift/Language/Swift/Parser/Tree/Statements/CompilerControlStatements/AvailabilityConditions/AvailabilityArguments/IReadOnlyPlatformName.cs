using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Identifiers;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.CompilerControlStatements.AvailabilityConditions.AvailabilityArguments;

public interface IReadOnlyPlatformName : ISwiftNode<SwiftCompositeNode>
{
    IReadOnlyIdentifier Platform { get; }

    bool IsExtension();

    bool IsStandalone();

    bool IsIOs();

    bool IsMacOs();

    bool IsWatchOs();

    bool IsTvOs();

    bool IsVisionOs();
}
