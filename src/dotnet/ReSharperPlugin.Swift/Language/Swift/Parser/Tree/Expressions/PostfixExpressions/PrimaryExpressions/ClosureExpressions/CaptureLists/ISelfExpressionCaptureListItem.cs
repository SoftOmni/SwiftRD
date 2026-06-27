using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.SelfExpressions;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.ClosureExpressions.CaptureLists;

public interface ISelfExpressionCaptureListItem : IReadOnlySelfExpressionCaptureListItem, ICaptureListItem
{
    new ISelfExpression SelfExpression { get; }

    void ChangeSelfExpression(ISelfExpression newSelfExpression);
}
