using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Attributes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.CodeBlocks;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Functions.ParameterClauses;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Initializers.Inits;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Generics.WhereClauses;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Initializers;

public interface IInitializerDeclaration : IReadOnlyInitializerDeclaration
{
    new IAttributeGroup? Attributes { get; }
    
    new IDeclarationModifierGroup? DeclarationModifiers { get; }
    
    new IInit InitKeyword { get; }
    
    new IParameterClause Parameters { get; }
    
    new IGenericWhereClause? GenericsConstraintClause { get; }
    
    new ICodeBlock CodeBlock { get; }

    void SetAttributesTo(IAttributeGroup? newAttributeGroups);

    void RemoveAttributes();

    void SetDeclarationModifiersTo(IDeclarationModifierGroup? newDeclarationModifiers);

    void RemoveDeclarationModifiers();

    void ChangeInitKeywordGroup(IInit newInitGroup);

    void ChangeParameters(IParameterClause newParameters);

    void SetGenericsConstraintClauseTo(IGenericWhereClause? newGenericsConstraintClause);

    void RemoveGenericsConstraintClause();

    void ChangeCodeBlock(ICodeBlock newCodeBlock);
}
