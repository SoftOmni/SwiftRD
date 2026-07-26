using System.Collections.Generic;
using JetBrains.Application.UI.Icons.CompiledIcons;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Attributes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Functions.ParameterClauses;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Generics.ParameterClauses;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Generics.WhereClauses;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Identifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Macros;

public class MacroDeclaration : SwiftCompositeNode, IMacroDeclaration
{
    public IAttributeGroup? Attributes { get; }

    public IDeclarationModifierGroup? DeclarationModifiers { get; }

    public Macro MacroKeyword { get; }

    public IIdentifier Name { get; }

    public IGenericParameterClause? GenericParameterClause { get; }

    public IParameterClause Parameters { get; }

    public Arrow ReturnTypeAnnouncer { get; }

    public IType ReturnType { get; }

    public IMacroDefinition? MacroDefinition { get; }

    public IGenericWhereClause? GenericsConstraintsClause { get; }

    internal MacroDeclaration(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        IAttributeGroup? attributes, IDeclarationModifierGroup? declarationModifiers, Macro macroKeyword,
        IIdentifier name, IGenericParameterClause? genericParameterClause, IParameterClause parameters,
        Arrow returnTypeAnnouncer, IType returnType, IMacroDefinition? macroDefinition,
        IGenericWhereClause? genericsConstraintsClause, AnyCompiledIconClass icon)
        : base(buffer, children)
    {
        Attributes = attributes;
        DeclarationModifiers = declarationModifiers;
        MacroKeyword = macroKeyword;
        Name = name;
        GenericParameterClause = genericParameterClause;
        Parameters = parameters;
        ReturnTypeAnnouncer = returnTypeAnnouncer;
        ReturnType = returnType;
        MacroDefinition = macroDefinition;
        GenericsConstraintsClause = genericsConstraintsClause;
        Icon = icon;
    }

    public AnyCompiledIconClass Icon { get; }

    IReadOnlyAttributeGroup? IReadOnlyMacroDeclaration.Attributes => Attributes;

    IReadOnlyDeclarationModifierGroup? IReadOnlyMacroDeclaration.DeclarationModifiers => DeclarationModifiers;

    IReadOnlyIdentifier IReadOnlyMacroDeclaration.Name => Name;

    IReadOnlyGenericParameterClause? IReadOnlyMacroDeclaration.GenericParameterClause => GenericParameterClause;

    IReadOnlyParameterClause IReadOnlyMacroDeclaration.Parameters => Parameters;

    IReadOnlyType IReadOnlyMacroDeclaration.ReturnType => ReturnType;

    IReadOnlyMacroDefinition? IReadOnlyMacroDeclaration.MacroDefinition => MacroDefinition;

    IReadOnlyGenericWhereClause? IReadOnlyMacroDeclaration.GenericsConstraintsClause => GenericsConstraintsClause;

    public void SetAttributesTo(IAttributeGroup? newAttributes)
    {
        throw new System.NotImplementedException();
    }

    public void RemoveAttributes()
    {
        throw new System.NotImplementedException();
    }

    public void SetDeclarationModifiersTo(IDeclarationModifierGroup? newDeclarationModifiers)
    {
        throw new System.NotImplementedException();
    }

    public void RemoveDeclarationModifiers()
    {
        throw new System.NotImplementedException();
    }

    public void ChangeName(IIdentifier newName)
    {
        throw new System.NotImplementedException();
    }

    public void SetGenericsParameterClauseTo(IGenericParameterClause? newGenericsParameterClause)
    {
        throw new System.NotImplementedException();
    }

    public void RemoveGenericsParameterClause()
    {
        throw new System.NotImplementedException();
    }

    public void ChangeParameters(IParameterClause newParameters)
    {
        throw new System.NotImplementedException();
    }

    public void ChangeReturnType(IType newReturnType)
    {
        throw new System.NotImplementedException();
    }

    public void SetMacroDefinitionTo(IMacroDefinition? newMacroDefinition)
    {
        throw new System.NotImplementedException();
    }

    public void RemoveMacroDefinition()
    {
        throw new System.NotImplementedException();
    }

    public bool SetMacroDefinitionExpressionTo(IExpression? newMacroExpression)
    {
        throw new System.NotImplementedException();
    }

    public void SetGenericsConstraintsClause(IGenericWhereClause? newGenericsConstraintsClause)
    {
        throw new System.NotImplementedException();
    }

    public void RemoveGenericsConstraintsClause()
    {
        throw new System.NotImplementedException();
    }
}
