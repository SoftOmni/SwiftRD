using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Attributes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Operators;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.TypeIdentifiers;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.TypeInheritanceClauses;

public interface ITypeInheritanceListElement : IReadOnlyTypeInheritanceListElement
{
    new IAttributeGroup? AttributeGroup { get; }
    
    new IOperator? Tilde { get; }
    
    new ITypeIdentifier TypeIdentifier { get; }

    bool AddIfNotPresentAttributeGroup(IAttributeGroup attributeGroup);
    
    void SetAttributeGroupTo(IAttributeGroup? attributeGroup);

    void RemoveAttributeGroup();

    void AddTildeIfNotPresent();

    void RemoveTilde();

    void ChangeTypeIdentifier(ITypeIdentifier typeIdentifier);
}
