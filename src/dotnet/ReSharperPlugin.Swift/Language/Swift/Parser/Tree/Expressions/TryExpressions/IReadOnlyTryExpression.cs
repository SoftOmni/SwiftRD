using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.TryOperators;

public interface IReadOnlyTryExpression : IReadOnlyBaseExpression
{
    public enum ExpressionKind
    {
        TryExpression,
        OptionalTryExpression,
        ForcedTryExpression
    }

    Try Try { get; }

    QuestionMark? QuestionMark { get; }

    ExclamationMark? ExclamationMark { get; }
    
    ExpressionKind Kind { get; }
    
    IReadOnlyExpression? TargetExpression { get; }
}
