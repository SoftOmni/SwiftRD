using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Attributes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Functions.ParameterClauses;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Generics.ParameterClauses;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Generics.WhereClauses;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Subscripts;

public interface IReadOnlySubscriptDeclaration : IReadOnlyDeclaration
{
    IReadOnlyAttributeGroup? Attributes { get; }
    
    IReadOnlyDeclarationModifierGroup? DeclarationModifiers { get; }
    
    Subscript SubscriptKeyword { get; }
    
    IReadOnlyGenericParameterClause? GenericParameterClause { get; }
    
    IReadOnlyParameterClause Parameters { get; }
    
    Arrow ReturnTypeIntroducer { get; }
    
    IReadOnlyAttributeGroup? ReturnTypeAttributes { get; }
    
    IReadOnlyType ReturnType { get; }
    
    IReadOnlyGenericWhereClause? GenericsConstraintsClause { get; }
}
