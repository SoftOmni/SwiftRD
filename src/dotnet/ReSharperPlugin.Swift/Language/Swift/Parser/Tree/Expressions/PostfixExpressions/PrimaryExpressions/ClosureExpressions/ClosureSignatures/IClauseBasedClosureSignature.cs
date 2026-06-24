using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Functions;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.ClosureExpressions.CaptureLists;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.ClosureExpressions.ClojureParameterLists;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.FunctionTypes.ThrowClauses;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.ClosureExpressions.ClosureSignatures;

public interface IClauseBasedClosureSignature : IReadOnlyClauseBasedClosureSignature, IClosureSignature
{
    new ICaptureList? CaptureList { get; }
    
    new IClosureParameterClause ClosureParameterClause { get; }
    
    new IThrowsClause? ThrowsClause { get; }
    
    new IFunctionResult? FunctionResult { get; }

    void SetCaptureListTo(ICaptureList? captureList);

    void RemoveCaptureList();

    void ChangeClosureParameterClause(IClosureParameterClause newClosureParameterClause);

    void SetThrowsClause(IThrowsClause? throwsClause);

    void RemoveThrowsClause();

    void SetFunctionResult(IFunctionResult? functionResult);

    void RemoveFunctionResult();
}
