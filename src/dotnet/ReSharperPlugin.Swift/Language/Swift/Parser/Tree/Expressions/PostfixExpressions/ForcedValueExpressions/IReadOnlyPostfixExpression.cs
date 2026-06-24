using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.ForcedValueExpressions;

public interface IReadOnlyForcedValueExpression : IReadOnlyPostfixExpression
{
    IReadOnlyPostfixExpression PostfixExpression { get; }
    
    ExclamationMark ExclamationMark { get; }
}
