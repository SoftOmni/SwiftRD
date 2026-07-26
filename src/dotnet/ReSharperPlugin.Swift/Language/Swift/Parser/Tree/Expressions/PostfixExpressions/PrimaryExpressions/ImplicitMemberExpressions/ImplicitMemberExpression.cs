using System;
using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Identifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.ImplicitMemberExpressions;

public class ImplicitMemberExpression : SwiftCompositeNode, IImplicitMemberExpression
{
    public Period Period { get; }
    
    public IIdentifier Member { get; }
    
    public Period? FollowedUpPostfixExpressionAccess { get; }
    
    public IPostfixExpression? FollowedUpPostfixExpression { get; }

    internal ImplicitMemberExpression(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children, Period period, 
        IIdentifier member, Period? followedUpPostfixExpressionAccess = null, IPostfixExpression? followedUpPostfixExpression = null)
        : base(buffer, children)
    {
        Period = period;
        Member = member;
        FollowedUpPostfixExpressionAccess = followedUpPostfixExpressionAccess;
        FollowedUpPostfixExpression = followedUpPostfixExpression;

        ReturnType = UnknownType.Instance;
    }

    IReadOnlyIdentifier IReadOnlyImplicitMemberExpression.Member => Member;

    IReadOnlyPostfixExpression? IReadOnlyImplicitMemberExpression.FollowedUpPostfixExpression => FollowedUpPostfixExpression;

    public IType ReturnType { get; }

    IReadOnlyType IReadOnlyBaseExpression.ReturnType => ReturnType;

    public void ChangeMember(IIdentifier newMember)
    {
        throw new NotImplementedException();
    }

    public void SetFollowupPostfixExpressionTo(IPostfixExpression? postfixExpression)
    {
        throw new NotImplementedException();
    }

    public void RemoveFollowupPostfixExpression()
    {
        throw new NotImplementedException();
    }
}
