using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.InfixExpressions.TypeCastingOperators;

public interface IReadOnlyTypeCastingOperatorExpression : IReadOnlyInfixExpression
{
    IReadOnlyTypeCastingOperator TypeCastingOperator { get; }
    
    IReadOnlyType Type { get; }
}