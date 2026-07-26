using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Operators;
using IOperator = SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Operators.Usages.IOperator;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.Literals.Literals.IntegerLiterals;

public interface ISignedIntegerLiteral : IIntegerLiteral, IReadOnlySignedIntegerLiteral
{
    void MakePositive();

    void MakeNegative();

    new IOperator? Operator { get; }
}