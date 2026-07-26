using System;
using System.Collections.Generic;
using JetBrains.Application.UI.Icons.CompiledIcons;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Attributes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.CodeBlocks;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Functions.Signatures;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Generics.ParameterClauses;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Generics.WhereClauses;
using SoftOmni.SwiftRd.Resources.Icons.Language;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Functions;

public class FunctionDeclaration : SwiftCompositeNode, IFunctionDeclaration
{
    public IAttributeGroup? Attributes { get; }

    public IDeclarationModifierGroup? DeclarationModifiers { get; }

    public Func FunctionKeyword { get; }

    public IFunctionName Name { get; }

    public IGenericParameterClause? GenericParameterClause { get; }

    public IFunctionSignature Signature { get; }

    public IGenericWhereClause? GenericWhereClause { get; }

    public ICodeBlock? Body { get; }

    internal FunctionDeclaration(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        IAttributeGroup? attributes, IDeclarationModifierGroup? declarationModifiers, Func functionKeyword,
        IFunctionName name, IGenericParameterClause? genericParameterClause, IFunctionSignature signature,
        IGenericWhereClause? genericWhereClause, ICodeBlock? body)
        : base(buffer, children)
    {
        Attributes = attributes;
        DeclarationModifiers = declarationModifiers;
        FunctionKeyword = functionKeyword;
        Name = name;
        GenericParameterClause = genericParameterClause;
        Signature = signature;
        GenericWhereClause = genericWhereClause;
        Body = body;

        Icon = SwiftIcons.ConstantIcon; // TODO: change
    }

    public AnyCompiledIconClass Icon { get; }
    
    IReadOnlyAttributeGroup? IReadOnlyFunctionDeclaration.Attributes => Attributes;

    IReadOnlyDeclarationModifierGroup? IReadOnlyFunctionDeclaration.DeclarationModifiers => DeclarationModifiers;

    IReadOnlyFunctionName IReadOnlyFunctionDeclaration.Name => Name;

    IReadOnlyGenericParameterClause? IReadOnlyFunctionDeclaration.GenericParameterClause => GenericParameterClause;

    IReadOnlyFunctionSignature IReadOnlyFunctionDeclaration.Signature => Signature;

    IReadOnlyGenericWhereClause? IReadOnlyFunctionDeclaration.GenericWhereClause => GenericWhereClause;

    IReadOnlyCodeBlock? IReadOnlyFunctionDeclaration.Body => Body;

    public void SetAttributesTo(IAttributeGroup? newAttributes)
    {
        throw new NotImplementedException();
    }

    public void RemoveAttributes()
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

    public void ChangeFunctionName(IFunctionName newFunctionName)
    {
        throw new NotImplementedException();
    }

    public void SetGenericParameterClauseTo(IGenericParameterClause? newGenericParameterClause)
    {
        throw new NotImplementedException();
    }

    public void RemoveGenericParameterClause()
    {
        throw new NotImplementedException();
    }

    public void ChangeFunctionSignature(IFunctionSignature newSignature)
    {
        throw new NotImplementedException();
    }

    public void SetGenericWhereClauseTo(IGenericWhereClause? newGenericWhereClause)
    {
        throw new NotImplementedException();
    }

    public void RemoveGenericWhereClause()
    {
        throw new NotImplementedException();
    }

    public void SetBodyTo(ICodeBlock? newBody)
    {
        throw new NotImplementedException();
    }

    public void RemoveBody()
    {
        throw new NotImplementedException();
    }
}