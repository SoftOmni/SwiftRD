using System.Collections.Generic;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Attributes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers.AccessLevelModifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Enumerations.Members;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Generics.ParameterClauses;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Generics.WhereClauses;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Identifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.TypeInheritanceClauses;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Enumerations;

public interface IEnumerationDeclaration : IReadOnlyEnumerationDeclaration, IList<ISwitchCaseMember>
{
    new IAttributeGroup? Attributes { get; }
    
    new IAccessLevelModifier? AccessLevelModifier { get; }

    void SetAttributesTo(IAttributeGroup? newAttributes);

    void RemoveAttributes();

    void SetAccessLevelModifierTo(IAccessLevelModifier? newAccessLevelModifier);

    void RemoveAccessLevelModifier();new IIdentifier Name { get; }

    new IGenericParameterClause? GenericParameterClause { get; }

    new ITypeInheritanceClause? TypeInheritanceClause { get; }

    new IGenericWhereClause? GenericWhereClause { get; }
    
    new ISwitchCaseMembers Members { get; }
    
    new IReadOnlyList<ISwitchCaseMember> MembersAsList { get; }

    void ChangeName(IIdentifier newName);

    void SetGenericParameterClauseTo(IGenericParameterClause newGenericParameterClause);

    void RemoveGenericParameterClause();

    void SetTypeInheritanceClauseTo(ITypeInheritanceClause newTypeInheritanceClause);

    void RemoveTypeInheritanceClause();

    void SetGenericWhereClauseTo(IGenericWhereClause? newGenericWhereClause);

    void RemoveGenericWhereClause();

    void ChangeMembers(ISwitchCaseMembers newMembers);

    new int Count { get; }
    
    new IEnumerator<ISwitchCaseMember> GetEnumerator();
    
    new ISwitchCaseMember this[int index] { get; set; }
}
