using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Attributes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.CodeBlocks;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Functions;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Functions.ParameterClauses;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Initializers.Inits;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Generics.WhereClauses;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.FunctionTypes.ThrowClauses;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Initializers;

public class ThrowsClauseInitializerDeclaration : SwiftCompositeNode, IThrowsClauseInitializerDeclaration
{
    public IAttributeGroup? Attributes { get; }

    public IDeclarationModifierGroup? DeclarationModifiers { get; }

    public IInit InitKeyword { get; }

    public IParameterClause Parameters { get; }

    public Async? AsyncKeyword { get; }

    public IGenericWhereClause? GenericsConstraintClause { get; }

    public ICodeBlock CodeBlock { get; }

    public IThrowsClause? ThrowsClause { get; }

    internal ThrowsClauseInitializerDeclaration(IEditableBuffer buffer,
        IEnumerable<ISwiftNode<SwiftCompositeNode>> children, IAttributeGroup? attributes,
        IDeclarationModifierGroup? declarationModifiers, IInit initKeyword, IParameterClause parameters,
        Async? asyncKeyword, IGenericWhereClause? genericsConstraintClause, ICodeBlock codeBlock,
        IThrowsClause? throwsClause)
        : base(buffer, children)
    {
        Attributes = attributes;
        DeclarationModifiers = declarationModifiers;
        InitKeyword = initKeyword;
        Parameters = parameters;
        AsyncKeyword = asyncKeyword;
        GenericsConstraintClause = genericsConstraintClause;
        CodeBlock = codeBlock;
        ThrowsClause = throwsClause;
    }

    IReadOnlyAttributeGroup? IReadOnlyInitializerDeclaration.Attributes => Attributes;

    IReadOnlyDeclarationModifierGroup? IReadOnlyInitializerDeclaration.DeclarationModifiers => DeclarationModifiers;

    IReadOnlyInit IReadOnlyInitializerDeclaration.InitKeyword => InitKeyword;

    IReadOnlyParameterClause IReadOnlyInitializerDeclaration.Parameters => Parameters;

    IReadOnlyGenericWhereClause? IReadOnlyInitializerDeclaration.GenericsConstraintClause => GenericsConstraintClause;

    IReadOnlyCodeBlock IReadOnlyInitializerDeclaration.CodeBlock => CodeBlock;

    IReadOnlyThrowsClause? IReadOnlyThrowsClauseInitializerDeclaration.ThrowsClause => ThrowsClause;

    public void SetAttributesTo(IAttributeGroup? newAttributeGroups)
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

    public void ChangeInitKeywordGroup(IInit newInitGroup)
    {
        throw new System.NotImplementedException();
    }

    public void ChangeParameters(IParameterClause newParameters)
    {
        throw new System.NotImplementedException();
    }

    public void SetGenericsConstraintClauseTo(IGenericWhereClause? newGenericsConstraintClause)
    {
        throw new System.NotImplementedException();
    }

    public void RemoveGenericsConstraintClause()
    {
        throw new System.NotImplementedException();
    }

    public void ChangeCodeBlock(ICodeBlock newCodeBlock)
    {
        throw new System.NotImplementedException();
    }

    public void SetThrowsClauseTo(IThrowsClause? newThrowsClause)
    {
        throw new System.NotImplementedException();
    }

    public void RemoveThrowsClause()
    {
        throw new System.NotImplementedException();
    }
}
