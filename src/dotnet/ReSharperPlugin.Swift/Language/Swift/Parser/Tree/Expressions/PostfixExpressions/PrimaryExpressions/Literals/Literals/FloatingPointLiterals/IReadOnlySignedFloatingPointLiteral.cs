using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Operators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.Literals.Literals.FloatingPointLiterals;

public interface IReadOnlySignedFloatingPointLiteral : IReadOnlyFloatingPointLiteral
{
    Sign CurrentSign { get; }
    
    IReadOnlyOperator? Operator { get; }
}