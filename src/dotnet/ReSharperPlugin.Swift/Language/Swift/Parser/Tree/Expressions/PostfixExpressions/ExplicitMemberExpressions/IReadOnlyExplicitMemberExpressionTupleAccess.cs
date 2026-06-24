using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.Literals.Literals.IntegerLiterals;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.ExplicitMemberExpressions;

public interface IReadOnlyExplicitMemberExpressionTupleAccess : IReadOnlyExplicitMemberExpression
{
    Period Period { get; }
    
    IReadOnlyIntegerLiteral FieldNumber { get; }
}
