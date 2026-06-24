using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.ISelfExpressions;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.SelfExpressions;

public interface IReadOnlySelfExpression : IReadOnlyPrimaryExpression
{ 
    SelfLowercase SelfLowercase { get; }
}
