using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.ParenthesizedExpressions;

public interface IReadOnlyParenthesizedExpression : IReadOnlyPrimaryExpression
{
    LeftParenthesis LeftParenthesis { get; }
    
    IReadOnlyExpression Expression { get; }
    
    RightParenthesis RightParenthesis { get; }
}