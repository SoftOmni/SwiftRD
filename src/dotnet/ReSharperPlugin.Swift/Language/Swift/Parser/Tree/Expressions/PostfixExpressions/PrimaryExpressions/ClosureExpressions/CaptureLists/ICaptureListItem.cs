using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.ClosureExpressions.CaptureLists.CaptureSpecifiers;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.ClosureExpressions.CaptureLists;

public interface ICaptureListItem : IReadOnlyCaptureListItem
{
    new ICaptureSpecifier? CaptureSpecifier { get; }

    void SetCaptureSpecifier(ICaptureSpecifier? newCaptureSpecifier);

    void MakeWeak();

    void MakeUnowned();

    void MakeUnownedSafe();

    void MakeUnownedUnsafe();

    void RemoveCaptureSpecifier();
}
