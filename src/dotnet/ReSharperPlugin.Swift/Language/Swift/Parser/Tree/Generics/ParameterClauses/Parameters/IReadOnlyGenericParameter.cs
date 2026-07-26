using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.InternalNode;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Identifiers;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Generics.ParameterClauses.Parameters;

public interface IReadOnlyGenericParameter : ISwiftInternalNode<SwiftCompositeNode>
{
    IReadOnlyIdentifier GenericParameterName { get; }
}
