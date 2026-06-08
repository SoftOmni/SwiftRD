using System.Collections.Generic;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.InternalNode;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.TypeAnnotations;

public interface IReadOnlyTypeAnnotation : ISwiftInternalNode<SwiftCompositeNode>, IReadOnlyList<IReadOnlyAttribute>
{
    public Colon? Colon { get; }
    
    public IReadOnlyAttributeGroup? AttributeGroup { get; }
    
    public IType? Type { get; }
}