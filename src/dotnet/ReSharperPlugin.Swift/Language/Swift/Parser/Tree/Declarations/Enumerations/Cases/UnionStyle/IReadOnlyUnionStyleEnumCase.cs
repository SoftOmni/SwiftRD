using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.InternalNode;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Identifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.TupleTypes;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Enumerations.Cases.UnionStyle;

public interface IReadOnlyUnionStyleEnumCase : ISwiftInternalNode<SwiftCompositeNode>
{
    IReadOnlyIdentifier Identifier { get; }
    
    IReadOnlyTupleType? TupleType { get; }
}
