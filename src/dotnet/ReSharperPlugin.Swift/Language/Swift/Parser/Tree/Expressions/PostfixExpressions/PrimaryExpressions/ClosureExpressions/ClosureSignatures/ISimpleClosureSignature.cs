using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.ClosureExpressions.CaptureLists;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.ClosureExpressions.ClosureSignatures;

public interface ISimpleClosureSignature : IReadOnlySimpleClosureSignature, IClosureSignature
{
    new ICaptureList CaptureList { get; }

    void ChangeCaptureList(ICaptureList newCaptureList);
}
