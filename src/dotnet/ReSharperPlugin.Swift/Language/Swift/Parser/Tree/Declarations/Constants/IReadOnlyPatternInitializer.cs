using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.InternalNode;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Patterns;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Constants;

public interface IReadOnlyPatternInitializer : ISwiftInternalNode<SwiftCompositeNode>
{
    IReadOnlyPattern Pattern { get; }
    
    IReadOnlyInitializer? Initializer { get; }
}
