using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.ISuperClassExpressions;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.SuperClassExpressions;

public interface IReadOnlySuperClassExpression : IReadOnlyPrimaryExpression
{ 
    Super Super { get; }
}
