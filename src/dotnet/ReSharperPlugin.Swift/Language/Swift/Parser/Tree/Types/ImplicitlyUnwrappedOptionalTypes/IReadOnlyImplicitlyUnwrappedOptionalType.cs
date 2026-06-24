using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.InternalNode;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.ImplicitlyUnwrappedOptionalType;

public interface IReadOnlyImplicitlyUnwrappedOptionalType : ISwiftInternalNode<SwiftCompositeNode>, IReadOnlyType
{
    IReadOnlyType Type { get; }

    ExclamationMark ExclamationMark { get; }
}
