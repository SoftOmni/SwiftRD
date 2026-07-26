using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Functions;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Functions.Signatures;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.ClosureExpressions.CaptureLists;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.ClosureExpressions.ClojureParameterLists;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.FunctionTypes.ThrowClauses;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.ClosureExpressions.ClosureSignatures;

public interface IReadOnlyClauseBasedClosureSignature : IReadOnlyClosureSignature
{
    IReadOnlyCaptureList? CaptureList { get; }
    
    IReadOnlyClosureParameterClause ClosureParameterClause { get; }
    
    Async? Async { get; }
    
    IReadOnlyThrowsClause? ThrowsClause { get; }
    
    IReadOnlyFunctionResult? FunctionResult { get; }
}
