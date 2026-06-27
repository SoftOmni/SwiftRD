using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.SelfExpressions;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.ClosureExpressions.CaptureLists;

public interface IReadOnlySelfExpressionCaptureListItem : IReadOnlyCaptureListItem
{
    IReadOnlySelfExpression SelfExpression { get; }
}
