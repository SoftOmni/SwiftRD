using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Attributes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers.AccessLevelModifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Generics.ArgumentClauses;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Identifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.TypeAliases;

public interface ITypeAlias : IReadOnlyTypeAlias,
    IDeclaration
{
    new IAttributeGroup? Attributes { get; }
    
    new IAccessLevelModifier? AccessLevelModifier { get; }
    
    new IIdentifier Name { get; }
    
    new IGenericArgumentClause? GenericArgumentClause { get; }
    
    new IType Type { get; }

    void SetAttributesTo(IAttributeGroup? newAttributes);

    void RemoveAttributes();

    void SetAccessLevelModifierTo(IAccessLevelModifier? newAccessLevelModifier);

    void RemoveAccessLevelModifier();

    void ChangeName(IIdentifier newName);

    void SetGenericArgumentClauseTo(IGenericArgumentClause? newGenericArgumentClause);

    void RemoveGenericArgumentClause();

    void ChangeType(IType newType);
}
