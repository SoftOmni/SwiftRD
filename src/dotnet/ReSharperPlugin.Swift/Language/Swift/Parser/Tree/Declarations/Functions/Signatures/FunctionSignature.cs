using System;
using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Functions.ParameterClauses;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Functions.Signatures;

public class FunctionSignature : SwiftCompositeNode, IFunctionSignature
{
    public IParameterClause ParameterClause { get; }

    public Async? AsynchronousKeyword { get; }

    public IFunctionResult? FunctionResult { get; }

    internal FunctionSignature(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        IParameterClause parameterClause)
        : base(buffer, children)
    {
        ParameterClause = parameterClause;
    }

    internal FunctionSignature(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        IParameterClause parameterClause, Async? asynchronousKeyword)
        : base(buffer, children)
    {
        ParameterClause = parameterClause;
        AsynchronousKeyword = asynchronousKeyword;
    }

    internal FunctionSignature(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        IParameterClause parameterClause, IFunctionResult functionResult)
        : base(buffer, children)
    {
        ParameterClause = parameterClause;
        FunctionResult = functionResult;
    }

    internal FunctionSignature(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        IParameterClause parameterClause, Async? asynchronousKeyword, IFunctionResult functionResult)
        : base(buffer, children)
    {
        ParameterClause = parameterClause;
        AsynchronousKeyword = asynchronousKeyword;
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
