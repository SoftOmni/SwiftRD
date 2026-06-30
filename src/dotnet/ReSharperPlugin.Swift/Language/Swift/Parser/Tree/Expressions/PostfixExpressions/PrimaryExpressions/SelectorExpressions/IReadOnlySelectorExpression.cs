using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.FunctionCallExpressions.Arguments;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.SelectorExpressions;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Rider.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.SelectorExpressions;

public interface IReadOnlySelectorExpression : IReadOnlyPrimaryExpression
{
    SelectorKeyword SelectorKeyword { get; }
    
    IReadOnlyFunctionCallArgumentList Arguments { get; }
    
    LeftParenthesis ArgumentsStart { get; }
    
    RightParenthesis ArgumentsEnd { get; }
}
