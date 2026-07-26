using System.Collections.Generic;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Attributes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers.AccessLevelModifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Generics.ParameterClauses;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Generics.WhereClauses;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Identifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.TypeInheritanceClauses;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Extensions;

public interface IExtensionDeclaration : IReadOnlyExtensionDeclaration, 
    IDeclaration,
    IList<IExtensionMember>
{
    new IAttributeGroup? Attributes { get; }
    
    new IAccessLevelModifier? AccessLevelModifier { get; }
    
    new IIdentifier Name { get; }
    
    new IGenericParameterClause? GenericParameterClause { get; }
    
    new ITypeInheritanceClause? TypeInheritanceClause { get; }
    
    new IGenericWhereClause? GenericConstraintsClause { get; }
    
    new IExtensionMembers Members { get; }
    
    new IReadOnlyList<IExtensionMember> MembersAsList { get; }
    
    new int Count { get; }

    new IEnumerator<IExtensionMember> GetEnumerator();
    
    new IExtensionMember this[int index] { get; set; }

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

    void ChangeMembers(IExtensionMembers newExtensionMembers);
}
