using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Attributes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.InternalNode;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.TypeAnnotations;

public interface IReadOnlyTypeAnnotation : ISwiftInternalNode<SwiftCompositeNode>
{
    public Colon Colon { get; }
    
    public IReadOnlyAttributeGroup? AttributeGroup { get; }
    
    public IReadOnlyType Type { get; }
}