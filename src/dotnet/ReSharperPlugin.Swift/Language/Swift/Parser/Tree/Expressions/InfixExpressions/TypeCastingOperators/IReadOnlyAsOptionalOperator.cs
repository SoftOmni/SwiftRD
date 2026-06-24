using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.InfixExpressions.TypeCastingOperators;

public interface IReadOnlyAsOptionalOperator : IReadOnlyTypeCastingOperator
{
    As As { get; }
    
    QuestionMark QuestionMark { get; }
}
