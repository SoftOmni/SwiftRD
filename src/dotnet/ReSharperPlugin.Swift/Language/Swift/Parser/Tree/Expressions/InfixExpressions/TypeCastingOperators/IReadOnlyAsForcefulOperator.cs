using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.InfixExpressions.TypeCastingOperators;

public interface IReadOnlyAsForcefulOperator : IReadOnlyTypeCastingOperator
{
    As As { get; }
    
    ExclamationMark ExclamationMark { get; }
}