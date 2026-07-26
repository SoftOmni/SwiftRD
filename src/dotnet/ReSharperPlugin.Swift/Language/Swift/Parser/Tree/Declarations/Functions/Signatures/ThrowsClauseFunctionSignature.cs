using System;
using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Functions.ParameterClauses;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.FunctionTypes.ThrowClauses;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Functions.Signatures;

public class ThrowsClauseFunctionSignature : SwiftCompositeNode, IThrowsClauseFunctionSignature
{
    public IParameterClause ParameterClause { get; }

    public Async? AsynchronousKeyword { get; }

    public IThrowsClause? ThrowsClause { get; }

    public IFunctionResult? FunctionResult { get; }

    internal ThrowsClauseFunctionSignature(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        IParameterClause parameterClause, IThrowsClause? throwsClause)
        : base(buffer, children)
    {
        ParameterClause = parameterClause;
        ThrowsClause = throwsClause;
    }

    internal ThrowsClauseFunctionSignature(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        IParameterClause parameterClause, Async? asynchronousKeyword, IThrowsClause? throwsClause)
        : base(buffer, children)
    {
        ParameterClause = parameterClause;
        AsynchronousKeyword = asynchronousKeyword;
        ThrowsClause = throwsClause;
    }

    internal ThrowsClauseFunctionSignature(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        IParameterClause parameterClause, IFunctionResult? functionResult)
        : base(buffer, children)
    {
        ParameterClause = parameterClause;
        FunctionResult = functionResult;
    }

    internal ThrowsClauseFunctionSignature(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        IParameterClause parameterClause, IThrowsClause? throwsClause, IFunctionResult? functionResult)
        : base(buffer, children)
    {
        ParameterClause = parameterClause;
        ThrowsClause = throwsClause;
        FunctionResult = functionResult;
    }

    internal ThrowsClauseFunctionSignature(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        IParameterClause parameterClause, Async? asynchronousKeyword, IFunctionResult? functionResult)
        : base(buffer, children)
    {
        ParameterClause = parameterClause;
        AsynchronousKeyword = asynchronousKeyword;
        FunctionResult = functionResult;
    }

    internal ThrowsClauseFunctionSignature(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        IParameterClause parameterClause, Async? asynchronousKeyword, IThrowsClause? throwsClause,
        IFunctionResult? functionResult)
        : base(buffer, children)
    {
        ParameterClause = parameterClause;
        AsynchronousKeyword = asynchronousKeyword;
        ThrowsClause = throwsClause;
        FunctionResult = functionResult;
    }

    IReadOnlyParameterClause IReadOnlyFunctionSignature.ParameterClause => ParameterClause;

    IReadOnlyThrowsClause? IReadOnlyThrowsClauseFunctionSignature.ThrowsClause => ThrowsClause;
    
    IReadOnlyFunctionResult? IReadOnlyFunctionSignature.FunctionResult => FunctionResult;

    public void ChangeParameterClause(IParameterClause newParameterClause)
    {
        throw new NotImplementedException();
    }

    public void SetThrowsClauseTo(IThrowsClause? newThrowsClause)
    {
        throw new NotImplementedException();
    }

    public void RemoveThrowsClause()
    {
        throw new NotImplementedException();
    }

    public void SetFunctionResultTo(IFunctionResult? newFunctionResult)
    {
        throw new NotImplementedException();
    }

    public void RemoveFunctionResult()
    {
        throw new NotImplementedException();
    }
}
