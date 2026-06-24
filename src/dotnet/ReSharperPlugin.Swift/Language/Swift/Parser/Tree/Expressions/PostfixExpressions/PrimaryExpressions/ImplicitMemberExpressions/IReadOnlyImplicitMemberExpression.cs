using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Identifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.ImplicitMemberExpressions;

public interface IReadOnlyImplicitMemberExpression : IReadOnlyPrimaryExpression
{
    Period Period { get; }
    
    IReadOnlyIdentifier Member { get; }
    
    Period? FollowedUpPostfixExpressionAccess { get; }
    
    IReadOnlyPostfixExpression? FollowedUpPostfixExpression { get; }
}
