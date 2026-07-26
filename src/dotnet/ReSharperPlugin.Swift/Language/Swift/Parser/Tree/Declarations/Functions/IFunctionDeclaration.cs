using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Attributes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.CodeBlocks;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Functions.Signatures;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Generics.ParameterClauses;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Generics.WhereClauses;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Functions;

public interface IFunctionDeclaration : IReadOnlyFunctionDeclaration,
    IDeclaration
{
    new IAttributeGroup? Attributes { get; }
    
    new IDeclarationModifierGroup? DeclarationModifiers { get; }
    
    new IFunctionName Name { get; }
    
    new IGenericParameterClause? GenericParameterClause { get; }
    
    new IFunctionSignature Signature { get; }
    
    new IGenericWhereClause? GenericWhereClause { get; }
    
    new ICodeBlock? Body { get; }

    void SetAttributesTo(IAttributeGroup? newAttributes);

    void RemoveAttributes();

    void SetDeclarationModifiersTo(IDeclarationModifierGroup? newDeclarationModifiers);

    void RemoveDeclarationModifiers();

    void ChangeFunctionName(IFunctionName newFunctionName);

    void SetGenericParameterClauseTo(IGenericParameterClause? newGenericParameterClause);

    void RemoveGenericParameterClause();

    void ChangeFunctionSignature(IFunctionSignature newSignature);

    void SetGenericWhereClauseTo(IGenericWhereClause? newGenericWhereClause);

    void RemoveGenericWhereClause();

    void SetBodyTo(ICodeBlock? newBody);

    void RemoveBody();
}
