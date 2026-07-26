using System.Collections.Generic;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Attributes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers.AccessLevelModifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Generics.ParameterClauses;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Generics.WhereClauses;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Identifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.TypeInheritanceClauses;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Actorures;

public interface IActorDeclaration : IReadOnlyActorDeclaration, 
    IDeclaration,
    IList<IActorMember>
{
    new IAttributeGroup? Attributes { get; }
    
    new IAccessLevelModifier? AccessLevelModifier { get; }
    
    new IIdentifier Name { get; }
    
    new IGenericParameterClause? GenericParameterClause { get; }
    
    new ITypeInheritanceClause? TypeInheritanceClause { get; }
    
    new IGenericWhereClause? GenericConstraintsClause { get; }
    
    new IActorMembers Members { get; }
    
    new IReadOnlyList<IActorMember> MembersAsList { get; }
    
    new int Count { get; }

    new IEnumerator<IActorMember> GetEnumerator();
    
    new IActorMember this[int index] { get; set; }

    void SetAttributesTo(IAttributeGroup? newAttributes);

    void RemoveAttributes();

    void SetAccessLevelModifierTo(IAccessLevelModifier? newAccessLevelModifier);

    void RemoveAccessLevelModifier();

    void ChangeName(IIdentifier newName);

    void SetGenericParameterClauseTo(IGenericParameterClause? newGenericParameterClause);

    void RemoveGenericParameterClause();

    void SetTypeInheritanceClauseTo(ITypeInheritanceClause newTypeInheritanceClause);

    void RemoveTypeInheritanceClause();

    void SetGenericConstraintsClauseTo(IGenericWhereClause? newGenericConstraintsClause);

    void RemoveGenericConstraintsClause();

    void ChangeMembers(IActorMembers newActorMembers);
}
