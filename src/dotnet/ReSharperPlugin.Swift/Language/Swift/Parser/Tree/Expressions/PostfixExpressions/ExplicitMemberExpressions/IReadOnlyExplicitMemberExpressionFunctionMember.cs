using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.ExplicitMemberExpressions.ArgumentNames;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Identifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.ExplicitMemberExpressions;

public interface IReadOnlyExplicitMemberExpressionFunctionMember : IReadOnlyExplicitMemberExpression
{
    Period Period { get; }
    
    IReadOnlyIdentifier FunctionName { get; }
    
    LeftParenthesis LeftParenthesis { get; }
    
    IReadOnlyArgumentNames ArgumentNames { get; }
    
    RightParenthesis RightParenthesis { get; }
}

