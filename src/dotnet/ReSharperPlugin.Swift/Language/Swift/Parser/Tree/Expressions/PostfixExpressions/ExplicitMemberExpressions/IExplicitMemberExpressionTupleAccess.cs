using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.Literals.Literals.IntegerLiterals;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.ExplicitMemberExpressions;

public interface IExplicitMemberExpressionTupleAccess : IReadOnlyExplicitMemberExpressionTupleAccess, IExplicitMemberExpression
{
    new IIntegerLiteral FieldNumber { get; }

    void ChangeFieldNumber(IIntegerLiteral fieldNumber);
}
