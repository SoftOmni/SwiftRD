using System.Collections.Generic;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Attributes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers.AccessLevelModifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Generics.ParameterClauses;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Generics.WhereClauses;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Identifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.TypeInheritanceClauses;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Structs;

public interface IReadOnlyStructureDeclaration : IReadOnlyDeclaration, 
    IReadOnlyList<IReadOnlyStructMember>
{
    IReadOnlyAttributeGroup? Attributes { get; }
    
    IReadOnlyAccessLevelModifier? AccessLevelModifier { get; }
    
    Struct StructKeyword { get; }
    
    IReadOnlyIdentifier Name { get; }
    
    IReadOnlyGenericParameterClause? GenericParameterClause { get; }
    
    IReadOnlyTypeInheritanceClause? TypeInheritanceClause { get; }
    
    IReadOnlyGenericWhereClause? GenericConstraintsClause { get; }
    
    LeftCurlyBrace MembersStart { get; }
    
    IReadOnlyStructMembers Members { get; }
    
    RightCurlyBrace MembersEnd { get; }
    
    IReadOnlyList<IReadOnlyStructMember> MembersAsList { get; }
    
    new IReadOnlyStructMember this[int index] { get; }
}
