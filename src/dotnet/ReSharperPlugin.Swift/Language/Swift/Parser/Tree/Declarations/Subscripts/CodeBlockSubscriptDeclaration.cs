using System.Collections.Generic;
using JetBrains.Application.UI.Icons.CompiledIcons;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Attributes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.CodeBlocks;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Functions.ParameterClauses;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Generics.ParameterClauses;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Generics.WhereClauses;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types;
using SoftOmni.SwiftRd.Resources.Icons.Language;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Subscripts;

public class CodeBlockSubscriptDeclaration : SwiftCompositeNode,
    ICodeBlockSubscriptDeclaration
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

    public ICodeBlock CodeBlock { get; }


    internal CodeBlockSubscriptDeclaration(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        IAttributeGroup? attributes, IDeclarationModifierGroup? declarationModifiers, Subscript subscriptKeyword,
        IGenericParameterClause? genericParameterClause, IParameterClause parameters, Arrow returnTypeIntroducer,
        IAttributeGroup? returnTypeAttributes, IType returnType, IGenericWhereClause? genericsConstraintsClause,
        ICodeBlock codeBlock)
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
        CodeBlock = codeBlock;

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

    IReadOnlyCodeBlock IReadOnlyCodeBlockSubscriptDeclaration.CodeBlock => CodeBlock;

    public void SetSubscriptAttributesTo(IAttributeGroup? newSubscriptAttributes)
    {
        throw new System.NotImplementedException();
    }

    public void RemoveSubscriptAttributes()
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

    public void SrtGenericsParameterClauseTo(IGenericParameterClause? newGenericsParameterClause)
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

    public void SetReturnTypeAttributesTo(IAttributeGroup? newReturnTypeAttributes)
    {
        throw new System.NotImplementedException();
    }

    public void RemoveReturnTypeAttributes()
    {
        throw new System.NotImplementedException();
    }

    public void ChangeReturnType(IType newReturnType)
    {
        throw new System.NotImplementedException();
    }

    public void SetGenericsConstraintsClauseTo(IGenericWhereClause? newGenericsConstraintsClause)
    {
        throw new System.NotImplementedException();
    }

    public void RemoveGenericsConstraintsClause()
    {
        throw new System.NotImplementedException();
    }

    public void ChangeCodeBlock(ICodeBlock newCodeBlock)
    {
        throw new System.NotImplementedException();
    }
}
