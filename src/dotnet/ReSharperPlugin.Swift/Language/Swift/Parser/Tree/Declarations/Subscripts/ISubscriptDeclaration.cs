using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Attributes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Functions.ParameterClauses;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Generics.ParameterClauses;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Generics.WhereClauses;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Subscripts;

public interface ISubscriptDeclaration : IReadOnlySubscriptDeclaration, IDeclaration
{
    new IAttributeGroup? Attributes { get; }
    
    new IDeclarationModifierGroup? DeclarationModifiers { get; }
    
    new IGenericParameterClause? GenericParameterClause { get; }
    
    new IParameterClause Parameters { get; }
    
    new IAttributeGroup? ReturnTypeAttributes { get; }
    
    new IType ReturnType { get; }
    
    new IGenericWhereClause? GenericsConstraintsClause { get; }

    void SetSubscriptAttributesTo(IAttributeGroup? newSubscriptAttributes);

    void RemoveSubscriptAttributes();

    void SetDeclarationModifiersTo(IDeclarationModifierGroup? newDeclarationModifiers);

    void RemoveDeclarationModifiers();

    void SrtGenericsParameterClauseTo(IGenericParameterClause? newGenericsParameterClause);

    void RemoveGenericsParameterClause();

    void ChangeParameters(IParameterClause newParameters);

    void SetReturnTypeAttributesTo(IAttributeGroup? newReturnTypeAttributes);

    void RemoveReturnTypeAttributes();

    void ChangeReturnType(IType newReturnType);

    void SetGenericsConstraintsClauseTo(IGenericWhereClause? newGenericsConstraintsClause);

    void RemoveGenericsConstraintsClause();
}
