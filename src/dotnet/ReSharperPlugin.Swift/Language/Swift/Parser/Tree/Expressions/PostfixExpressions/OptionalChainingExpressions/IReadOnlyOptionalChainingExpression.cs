using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.OptionalChainingExpressions;

public interface IReadOnlyOptionalChainingExpression : IReadOnlyPostfixExpression
{
    IReadOnlyPostfixExpression PostfixExpression { get; }
    
    QuestionMark QuestionMark { get; }
}
