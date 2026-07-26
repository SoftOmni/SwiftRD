using System.Collections.Generic;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Attributes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers.AccessLevelModifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Generics.ParameterClauses;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Generics.WhereClauses;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Identifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.TypeInheritanceClauses;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Classures;

public interface IClassureDeclaration : IReadOnlyClassureDeclaration, 
    IDeclaration,
    IList<IClassMember>
{
    new IAttributeGroup? Attributes { get; }
    
    new IAccessLevelModifier? AccessLevelModifier { get; }
    
    new IIdentifier Name { get; }
    
    new IGenericParameterClause? GenericParameterClause { get; }
    
    new ITypeInheritanceClause? TypeInheritanceClause { get; }
    
    new IGenericWhereClause? GenericConstraintsClause { get; }
    
    new IClassMembers Members { get; }
    
    new IReadOnlyList<IClassMember> MembersAsList { get; }
    
    new int Count { get; }

    new IEnumerator<IClassMember> GetEnumerator();
    
    new IClassMember this[int index] { get; set; }

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

    void ChangeMembers(IClassMembers newClassMembers);
}
