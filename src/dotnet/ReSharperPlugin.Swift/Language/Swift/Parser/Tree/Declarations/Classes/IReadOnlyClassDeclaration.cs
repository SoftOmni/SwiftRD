using System.Collections.Generic;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Attributes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers.AccessLevelModifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers.DeclarationModifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Generics.ParameterClauses;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Generics.WhereClauses;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Identifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.TypeInheritanceClauses;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Classes;

public interface IReadOnlyClassDeclaration : IReadOnlyDeclaration, 
    IReadOnlyList<IReadOnlyClassMember>
{
    IReadOnlyAttributeGroup? Attributes { get; }
    
    IReadOnlyAccessLevelModifier? AccessLevelModifier { get; }
    
    Final? FinalKeyword { get; }
    
    Class ClassKeyword { get; }
    
    IReadOnlyIdentifier Name { get; }
    
    IReadOnlyGenericParameterClause? GenericParameterClause { get; }
    
    IReadOnlyTypeInheritanceClause? TypeInheritanceClause { get; }
    
    IReadOnlyGenericWhereClause? GenericConstraintsClause { get; }
    
    LeftCurlyBrace MembersStart { get; }
    
    IReadOnlyClassMembers Members { get; }
    
    RightCurlyBrace MembersEnd { get; }
    
    IReadOnlyList<IReadOnlyClassMember> MembersAsList { get; }
    
    new IReadOnlyClassMember this[int index] { get; }
}
