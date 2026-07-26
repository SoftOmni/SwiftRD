using System;
using System.Collections.Generic;
using JetBrains.Application.UI.Icons.CompiledIcons;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Attributes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Functions.ParameterClauses;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Variables.GetterSetterBlocks.RegularBlocks;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Generics.ParameterClauses;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Generics.WhereClauses;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types;
using SoftOmni.SwiftRd.Resources.Icons.Language;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Subscripts;

public class GetterSetterBlockSubscriptDeclaration : SwiftCompositeNode, IGetterSetterBlockSubscriptDeclaration
{
    public IAttributeGroup? Attributes { get; }

    public IDeclarationModifierGroup? DeclarationModifiers { get; }

    public Subscript SubscriptKeyword { get; }

    public IGenericParameterClause? GenericParameterClause { get; }

    public IParameterClause Parameters { get; }

    public Arrow ReturnTypeIntroducer { get; }

    public IAttributeGroup? ReturnTypeAttributes { get; }

    public IType ReturnType { get; }

    public IGenericWhereClause? GenericsConstraintsClause { get; }

    public IGetterSetterBlock GetterSetterBlock { get; }

    internal GetterSetterBlockSubscriptDeclaration(IEditableBuffer buffer,
        IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        IAttributeGroup? attributes, IDeclarationModifierGroup? declarationModifiers, Subscript subscriptKeyword,
        IGenericParameterClause? genericParameterClause, IParameterClause parameters, Arrow returnTypeIntroducer,
        IAttributeGroup? returnTypeAttributes, IType returnType, IGenericWhereClause? genericsConstraintsClause,
        IGetterSetterBlock getterSetterBlock)
        : base(buffer, children)
    {
        Attributes = attributes;
        DeclarationModifiers = declarationModifiers;
        SubscriptKeyword = subscriptKeyword;
        GenericParameterClause = genericParameterClause;
        Parameters = parameters;
        ReturnTypeIntroducer = returnTypeIntroducer;
        ReturnTypeAttributes = returnTypeAttributes;
        ReturnType = returnType;
        GenericsConstraintsClause = genericsConstraintsClause;
        GetterSetterBlock = getterSetterBlock;

        Icon = SwiftIcons.ConstantIcon;
    }

    public AnyCompiledIconClass Icon { get; }

    IReadOnlyAttributeGroup? IReadOnlySubscriptDeclaration.Attributes => Attributes;

    IReadOnlyDeclarationModifierGroup? IReadOnlySubscriptDeclaration.DeclarationModifiers => DeclarationModifiers;

    IReadOnlyGenericParameterClause? IReadOnlySubscriptDeclaration.GenericParameterClause => GenericParameterClause;

    IReadOnlyParameterClause IReadOnlySubscriptDeclaration.Parameters => Parameters;

    IReadOnlyAttributeGroup? IReadOnlySubscriptDeclaration.ReturnTypeAttributes => ReturnTypeAttributes;

    IReadOnlyType IReadOnlySubscriptDeclaration.ReturnType => ReturnType;

    IReadOnlyGenericWhereClause? IReadOnlySubscriptDeclaration.GenericsConstraintsClause => GenericsConstraintsClause;

    IReadOnlyGetterSetterBlock IReadOnlyGetterSetterBlockSubscriptDeclaration.GetterSetterBlock => GetterSetterBlock;

    public void SetSubscriptAttributesTo(IAttributeGroup? newSubscriptAttributes)
    {
        throw new NotImplementedException();
    }

    public void RemoveSubscriptAttributes()
    {
        throw new NotImplementedException();
    }

    public void SetDeclarationModifiersTo(IDeclarationModifierGroup? newDeclarationModifiers)
    {
        throw new NotImplementedException();
    }

    public void RemoveDeclarationModifiers()
    {
        throw new NotImplementedException();
    }

    public void SrtGenericsParameterClauseTo(IGenericParameterClause? newGenericsParameterClause)
    {
        throw new NotImplementedException();
    }

    public void RemoveGenericsParameterClause()
    {
        throw new NotImplementedException();
    }

    public void ChangeParameters(IParameterClause newParameters)
    {
        throw new NotImplementedException();
    }

    public void SetReturnTypeAttributesTo(IAttributeGroup? newReturnTypeAttributes)
    {
        throw new NotImplementedException();
    }

    public void RemoveReturnTypeAttributes()
    {
        throw new NotImplementedException();
    }

    public void ChangeReturnType(IType newReturnType)
    {
        throw new NotImplementedException();
    }

    public void SetGenericsConstraintsClauseTo(IGenericWhereClause? newGenericsConstraintsClause)
    {
        throw new NotImplementedException();
    }

    public void RemoveGenericsConstraintsClause()
    {
        throw new NotImplementedException();
    }

    public void ChangeGetterSetterBlock(IGetterSetterBlock newGetterSetterBlock)
    {
        throw new NotImplementedException();
    }
}
