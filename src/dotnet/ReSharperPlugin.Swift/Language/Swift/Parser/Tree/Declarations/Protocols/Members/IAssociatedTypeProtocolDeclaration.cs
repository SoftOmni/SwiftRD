using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Attributes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers.AccessLevelModifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Generics.WhereClauses;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Identifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.TypeInheritanceClauses;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Protocols.Members;

public interface IAssociatedTypeProtocolDeclaration : IReadOnlyAssociatedTypeProtocolDeclaration, IProtocolMember, IDeclaration
{
    new IAttributeGroup? Attributes { get; }

    new IAccessLevelModifier? AccessLevelModifier { get; }

    new IIdentifier TypeAliasName { get; }
    
    new ITypeInheritanceClause? TypeInheritanceClause { get; }
    
    new IType? AliasedType { get; }
    
    new IGenericWhereClause? GenericsConstraintsClause { get; }

    void SetAttributesTo(IAttributeGroup? newAttributes);

    void RemoveAttributes();

    void SetAccessLevelModifierTo(IAccessLevelModifier? newAccessLevelModifier);

    void RemoveAccessLevelModifier();

    void ChangeTypeAliasName(IIdentifier newName);

    void SetTypeInheritanceClauseTo(ITypeInheritanceClause? newTypeInheritanceClause);

    void RemoveTypeInheritanceClause();

    void SetAliasedTypeTo(IType? newAliasedType);

    void RemoveAliasedType();

    void SetGenericsConstraintsClauseTo(IGenericWhereClause? newGenericsConstraintsClause);

    void RemoveGenericsConstraintsClause();
}
