using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.InternalNode;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Identifiers;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Patterns.Destructuring.Identifiers;

public interface IReadOnlyIdentifierPattern : IDestructuringPattern, ISwiftInternalNode<SwiftCompositeNode>
{
    IReadOnlyIdentifier Identifier { get; }
}