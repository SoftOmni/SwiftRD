using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Attributes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Functions.ParameterClauses;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Functions.Signatures;

public class RethrowsClauseFunctionSignature : SwiftCompositeNode, IRethrowsClauseFunctionSignature
{
    public IParameterClause ParameterClause { get; }

    public Async? AsynchronousKeyword { get; }

    public Arrow? ReturnTypePresenter { get; }

    public IAttributeGroup? ReturnTypeAttributes { get; }

    public IType? ReturnType { get; }

    internal RethrowsClauseFunctionSignature(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        IParameterClause parameterClause)
        : base(buffer, children)
    {
        ParameterClause = parameterClause;
    }

    internal RethrowsClauseFunctionSignature(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        IParameterClause parameterClause, Async? asynchronousKeyword)
        : base(buffer, children)
    {
        ParameterClause = parameterClause;
        AsynchronousKeyword = asynchronousKeyword;
    }

    internal RethrowsClauseFunctionSignature(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        IParameterClause parameterClause, Arrow returnTypePresenter,
        IAttributeGroup? returnTypeAttributes, IType returnType)
        : base(buffer, children)
    {
        ParameterClause = parameterClause;
        ReturnTypePresenter = returnTypePresenter;
        ReturnTypeAttributes = returnTypeAttributes;
        ReturnType = returnType;
    }

    internal RethrowsClauseFunctionSignature(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        IParameterClause parameterClause, Async? asynchronousKeyword, Arrow returnTypePresenter,
        IAttributeGroup? returnTypeAttributes, IType returnType)
        : base(buffer, children)
    {
        ParameterClause = parameterClause;
        AsynchronousKeyword = asynchronousKeyword;
        ReturnTypePresenter = returnTypePresenter;
        ReturnTypeAttributes = returnTypeAttributes;
        ReturnType = returnType;
    }

    IReadOnlyParameterClause IReadOnlyFunctionSignature.ParameterClause => ParameterClause;

    IReadOnlyAttributeGroup? IReadOnlyFunctionSignature.ReturnTypeAttributes => ReturnTypeAttributes;

    IReadOnlyType? IReadOnlyFunctionSignature.ReturnType => ReturnType;

    public void ChangeParameterClause(IParameterClause newParameterClause)
    {
        throw new System.NotImplementedException();
    }

    public void SetReturnTypeAttributes(IAttributeGroup? newReturnTypeAttributes)
    {
        throw new System.NotImplementedException();
    }

    public void RemoveReturnTypeAttributes()
    {
        throw new System.NotImplementedException();
    }

    public void SetReturnType(IType? newReturnType)
    {
        throw new System.NotImplementedException();
    }

    public void RemoveReturnType()
    {
        throw new System.NotImplementedException();
    }
}