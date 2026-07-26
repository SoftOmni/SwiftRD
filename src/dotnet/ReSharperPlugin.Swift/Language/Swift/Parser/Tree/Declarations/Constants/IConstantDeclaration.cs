using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Attributes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Constants;

public interface IConstantDeclaration : IReadOnlyConstantDeclaration, IDeclaration
{
    new IAttributeGroup? AttributeGroup { get; }
    
    new IDeclarationModifierGroup? DeclarationModifierGroup { get; }
    
    new IPatternInitializerList PatternInitializerList { get; }

    void SetAttributeGroupTo(IAttributeGroup? attributeGroup);

    void RemoveAttributeGroup();

    void SetDeclarationModifier(IDeclarationModifierGroup? declarationModifier);

    void RemoveDeclarationModifier();

    void ChangePatternInitializerList(IPatternInitializerList newPatternInitializerList);
}
