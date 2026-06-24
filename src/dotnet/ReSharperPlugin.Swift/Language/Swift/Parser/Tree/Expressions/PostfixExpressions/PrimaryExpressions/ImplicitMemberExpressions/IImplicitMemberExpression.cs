using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Identifiers;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.ImplicitMemberExpressions;

public interface IImplicitMemberExpression : IReadOnlyImplicitMemberExpression, IPrimaryExpression
{
    new IIdentifier Member { get; }
    
    new IPostfixExpression? FollowedUpPostfixExpression { get; }

    void ChangeMember(IIdentifier newMember);

    void SetFollowupPostfixExpressionTo(IPostfixExpression? postfixExpression);

    void RemoveFollowupPostfixExpression();
}
