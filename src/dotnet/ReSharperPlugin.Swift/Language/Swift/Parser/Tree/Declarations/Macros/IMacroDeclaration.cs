using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Attributes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Functions.ParameterClauses;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Generics.ParameterClauses;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Generics.WhereClauses;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Identifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Macros;

public interface IMacroDeclaration : IReadOnlyMacroDeclaration, IDeclaration
{
    new IAttributeGroup? Attributes { get; }
    
    new IDeclarationModifierGroup? DeclarationModifiers { get; }
    
    new IIdentifier Name { get; }
    
    new IGenericParameterClause? GenericParameterClause { get; }
    
    new IParameterClause Parameters { get; }
    
    new IType ReturnType { get; }
    
    new IMacroDefinition? MacroDefinition { get; }
    
    new IGenericWhereClause? GenericsConstraintsClause { get; }

    void SetAttributesTo(IAttributeGroup? newAttributes);

    void RemoveAttributes();

    void SetDeclarationModifiersTo(IDeclarationModifierGroup? newDeclarationModifiers);

    void RemoveDeclarationModifiers();

    void ChangeName(IIdentifier newName);

    void SetGenericsParameterClauseTo(IGenericParameterClause? newGenericsParameterClause);

    void RemoveGenericsParameterClause();

    void ChangeParameters(IParameterClause newParameters);

    void ChangeReturnType(IType newReturnType);

    void SetMacroDefinitionTo(IMacroDefinition? newMacroDefinition);

    void RemoveMacroDefinition();

    bool SetMacroDefinitionExpressionTo(IExpression? newMacroExpression);

    void SetGenericsConstraintsClause(IGenericWhereClause? newGenericsConstraintsClause);

    void RemoveGenericsConstraintsClause();
}
