using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Rider.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.KeyPathExpressions.Components.KeyPathPostfixes;

public interface IReadOnlyQuestionMarkKeyPathPostfix : IReadOnlyKeyPathPostfix
{
    QuestionMark QuestionMark { get; }
}
