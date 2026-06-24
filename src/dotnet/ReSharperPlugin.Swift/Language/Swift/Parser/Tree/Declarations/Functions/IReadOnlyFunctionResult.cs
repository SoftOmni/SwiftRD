using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Attributes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.InternalNode;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Functions;

public interface IReadOnlyFunctionResult : ISwiftInternalNode<SwiftCompositeNode>
{
    IReadOnlyAttributeGroup? AttributeGroup { get; }
    
    IReadOnlyType Type { get; }
}
