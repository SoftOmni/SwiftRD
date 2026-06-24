using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Initializers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.ExplicitMemberExpressions.ArgumentNames;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.InitializerExpressions;

public interface IReadOnlyInitializerExpression : IReadOnlyPostfixExpression
{
    IReadOnlyPostfixExpression PostfixExpression { get; }
    
    Period Period { get; }
    
    Init Init { get; }
    
    LeftParenthesis? LeftParenthesis { get; }
    
    IReadOnlyArgumentNames? ArgumentNames { get; }
    
    RightParenthesis? RightParenthesis { get; }
}
