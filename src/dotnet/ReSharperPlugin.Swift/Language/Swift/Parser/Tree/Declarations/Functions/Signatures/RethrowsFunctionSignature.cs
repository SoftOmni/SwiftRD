using System;
using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Functions.ParameterClauses;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Functions.Signatures;

public class RethrowsFunctionSignature : SwiftCompositeNode, IRethrowsFunctionSignature
{
    public IParameterClause ParameterClause { get; }

    public Async? AsynchronousKeyword { get; }

    public Rethrows? Rethrows { get; }

    public IFunctionResult? FunctionResult { get; }

    internal RethrowsFunctionSignature(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        IParameterClause parameterClause, Rethrows? rethrows)
        : base(buffer, children)
    {
        ParameterClause = parameterClause;
        Rethrows = rethrows;
    }

    internal RethrowsFunctionSignature(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        IParameterClause parameterClause, Async? asynchronousKeyword, Rethrows? rethrows)
        : base(buffer, children)
    {
        ParameterClause = parameterClause;
        AsynchronousKeyword = asynchronousKeyword;
        Rethrows = rethrows;
    }

    internal RethrowsFunctionSignature(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        IParameterClause parameterClause, IFunctionResult? functionResult)
        : base(buffer, children)
    {
        ParameterClause = parameterClause;
        FunctionResult = functionResult;
    }

    internal RethrowsFunctionSignature(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        IParameterClause parameterClause, Rethrows? rethrows, IFunctionResult? functionResult)
        : base(buffer, children)
    {
        ParameterClause = parameterClause;
        Rethrows = rethrows;
        FunctionResult = functionResult;
    }

    internal RethrowsFunctionSignature(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        IParameterClause parameterClause, Async? asynchronousKeyword, IFunctionResult? functionResult)
        : base(buffer, children)
    {
        ParameterClause = parameterClause;
        AsynchronousKeyword = asynchronousKeyword;
        FunctionResult = functionResult;
    }

    internal RethrowsFunctionSignature(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        IParameterClause parameterClause, Async? asynchronousKeyword, Rethrows? rethrows, IFunctionResult? functionResult)
        : base(buffer, children)
    {
        ParameterClause = parameterClause;
        AsynchronousKeyword = asynchronousKeyword;
        Rethrows = rethrows;
        FunctionResult = functionResult;
    }

    IReadOnlyParameterClause IReadOnlyFunctionSignature.ParameterClause => ParameterClause;

    IReadOnlyFunctionResult? IReadOnlyFunctionSignature.FunctionResult => FunctionResult;

    public void ChangeParameterClause(IParameterClause newParameterClause)
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
