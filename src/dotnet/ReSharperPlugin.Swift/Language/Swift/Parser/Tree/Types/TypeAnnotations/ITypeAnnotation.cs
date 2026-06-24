using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Attributes;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.TypeAnnotations;

public interface ITypeAnnotation : IReadOnlyTypeAnnotation
{
    new IType Type { get; }
    
    new IAttributeGroup? AttributeGroup { get; }

    void ChangeType(IType type);
}
