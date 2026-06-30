using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.FunctionCallExpressions.Arguments;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.KeyPathStringExpressions;

public interface IReadOnlyKeyPathStringExpression : IReadOnlyPrimaryExpression
{
    KeyPathKeyword KeyPathKeyword { get; }
    
    LeftParenthesis LeftParenthesis { get; }
    
    IReadOnlyExpression Expression { get; }
    
    RightParenthesis RightParenthesis { get; }

    IFunctionCallArgumentList GenerateEquivalentFunctionCallArgumentList();
}
