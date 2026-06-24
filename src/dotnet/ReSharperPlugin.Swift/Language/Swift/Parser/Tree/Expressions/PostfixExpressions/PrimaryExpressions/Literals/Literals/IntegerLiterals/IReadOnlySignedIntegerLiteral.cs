using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Operators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.Literals.Literals.IntegerLiterals;

public interface IReadOnlySignedIntegerLiteral : IReadOnlyIntegerLiteral
{
    enum Sign
    {
        Positive,
        Negative
    }
    
    Sign CurrentSign { get; }
    
    IReadOnlyOperator? Operator { get; }
}