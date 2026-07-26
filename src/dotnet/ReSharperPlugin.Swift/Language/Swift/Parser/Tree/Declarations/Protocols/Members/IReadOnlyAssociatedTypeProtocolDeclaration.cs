using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Attributes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers.AccessLevelModifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Generics.WhereClauses;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Identifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.TypeInheritanceClauses;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Protocols.Members;

public interface IReadOnlyAssociatedTypeProtocolDeclaration : IReadOnlyProtocolMember, IReadOnlyDeclaration
{
    IReadOnlyAttributeGroup? Attributes { get; }
    
    IReadOnlyAccessLevelModifier? AccessLevelModifier { get; }
    
    AssociatedType AssociatedTypeKeyword { get; }
    
    IReadOnlyIdentifier TypeAliasName { get; }
    
    IReadOnlyTypeInheritanceClause? TypeInheritanceClause { get; }
    
    Equal? TypeAliasAssignmentAnnouncer { get; }
    
    IReadOnlyType? AliasedType { get; }
    
    IReadOnlyGenericWhereClause? GenericsConstraintsClause { get; }
}
