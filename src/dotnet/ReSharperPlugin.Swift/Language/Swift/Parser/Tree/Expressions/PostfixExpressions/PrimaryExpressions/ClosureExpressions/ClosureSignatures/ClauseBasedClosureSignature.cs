using System;
using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Functions;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Functions.Signatures;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.ClosureExpressions.CaptureLists;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.ClosureExpressions.ClojureParameterLists;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.FunctionTypes.ThrowClauses;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.ClosureExpressions.ClosureSignatures;

public class ClauseBasedClosureSignature : SwiftCompositeNode, IClauseBasedClosureSignature
{
    public ICaptureList? CaptureList { get; }

    public IClosureParameterClause ClosureParameterClause { get; }
    
    public Async? Async { get; }

    public IThrowsClause? ThrowsClause { get; }

    public IFunctionResult? FunctionResult { get; }

    public In In { get; }

    internal ClauseBasedClosureSignature(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        ICaptureList captureList, IClosureParameterClause closureParameterClause, Async? async,
        IThrowsClause? throwsClause,
        IFunctionResult? functionResult, In @in)
        : base(buffer, children)
    {
        CaptureList = captureList;
        ClosureParameterClause = closureParameterClause;

        Async = async;
        ThrowsClause = throwsClause;
        FunctionResult = functionResult;

        In = @in;
    }

    internal ClauseBasedClosureSignature(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        IClosureParameterClause closureParameterClause, Async? async,
        IThrowsClause? throwsClause,
        IFunctionResult? functionResult, In @in)
        : base(buffer, children)
    {
        CaptureList = null;
        ClosureParameterClause = closureParameterClause;

        Async = async;
        ThrowsClause = throwsClause;
        FunctionResult = functionResult;

        In = @in;
    }

    IReadOnlyCaptureList? IReadOnlyClauseBasedClosureSignature.CaptureList => CaptureList;
    
    IReadOnlyClosureParameterClause IReadOnlyClauseBasedClosureSignature.ClosureParameterClause => ClosureParameterClause;

    IReadOnlyThrowsClause? IReadOnlyClauseBasedClosureSignature.ThrowsClause => ThrowsClause;

    IReadOnlyFunctionResult? IReadOnlyClauseBasedClosureSignature.FunctionResult => FunctionResult;

    public void SetCaptureListTo(ICaptureList? captureList)
    {
        throw new NotImplementedException();
    }

    public void RemoveCaptureList()
    {
        throw new NotImplementedException();
    }

    public void ChangeClosureParameterClause(IClosureParameterClause newClosureParameterClause)
    {
        throw new NotImplementedException();
    }

    public void SetThrowsClause(IThrowsClause? throwsClause)
    {
        throw new NotImplementedException();
    }

    public void RemoveThrowsClause()
    {
        throw new NotImplementedException();
    }

    public void SetFunctionResult(IFunctionResult? functionResult)
    {
        throw new NotImplementedException();
    }

    public void RemoveFunctionResult()
    {
        throw new NotImplementedException();
    }
}
