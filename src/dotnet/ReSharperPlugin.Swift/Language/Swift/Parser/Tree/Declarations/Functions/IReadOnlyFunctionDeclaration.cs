using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Attributes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.CodeBlocks;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Functions.Signatures;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Generics.ParameterClauses;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Generics.WhereClauses;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Functions;

public interface IReadOnlyFunctionDeclaration : IReadOnlyDeclaration
{
    IReadOnlyAttributeGroup? Attributes { get; }
    
    IReadOnlyDeclarationModifierGroup? DeclarationModifiers { get; }
    
    Func FunctionKeyword { get; }
    
    IReadOnlyFunctionName Name { get; }
    
    IReadOnlyGenericParameterClause? GenericParameterClause { get; }
    
    IReadOnlyFunctionSignature Signature { get; }
    
    IReadOnlyGenericWhereClause? GenericWhereClause { get; }
    
    IReadOnlyCodeBlock? Body { get; }
}
