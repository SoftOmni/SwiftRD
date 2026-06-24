using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.ClosureExpressions;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Identifiers;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.FunctionCallExpressions.Closures;

public interface ILabeledTrailingExpression : IReadOnlyLabeledTrailingExpression
{
    new IIdentifier Label { get; }
    
    new IClosureExpression LabeledTrailingClosureExpression { get; }
    
    void ChangeLabel(IIdentifier newIdentifier);

    void ChangeLabeledTrailingClosure(IClosureExpression newClosure);
}
