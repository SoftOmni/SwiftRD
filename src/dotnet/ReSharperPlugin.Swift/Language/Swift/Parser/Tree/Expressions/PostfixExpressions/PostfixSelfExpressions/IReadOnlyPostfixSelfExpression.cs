using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.ISelfExpressions;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PostfixSelfExpressions;

public interface IReadOnlyPostfixSelfExpression : IReadOnlyPostfixExpression
{
    IReadOnlyPostfixExpression PostfixExpression { get; }
    
    Period Period { get; }
    
    SelfLowercase SelfLowercase { get; }
}
