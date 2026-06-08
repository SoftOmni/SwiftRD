using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Operators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.Literals.Literals.FloatingPointLiterals;

public interface ISignedFloatingPointLiteral : IFloatingPointLiteral, IReadOnlySignedFloatingPointLiteral
{
    void MakePositive();

    void MakeNegative();
    
    new IOperator? Operator { get; }
}
