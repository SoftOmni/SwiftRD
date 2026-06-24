using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Generics.ArgumentClauses;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Identifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.ExplicitMemberExpressions;

public class ExplicitMemberExpressionStandardMemberAccess
    : SwiftCompositeNode, IExplicitMemberExpressionStandardMemberAccess
{
    public IPostfixExpression PostfixExpression { get; }

    public Period Period { get; }

    public IIdentifier MemberName { get; }

    public IGenericArgumentClause GenericArgumentClause { get; }

    internal ExplicitMemberExpressionStandardMemberAccess(IEditableBuffer buffer,
        IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        IPostfixExpression postfixExpression, Period period,
        IIdentifier memberName, IGenericArgumentClause genericArgumentClause)
        : base(buffer, children)
    {
        PostfixExpression = postfixExpression;
        Period = period;
        MemberName = memberName;
        GenericArgumentClause = genericArgumentClause;

        ReturnType = UnknownType.Instance;
    }

    IReadOnlyPostfixExpression IReadOnlyExplicitMemberExpression.PostfixExpression => PostfixExpression;

    IReadOnlyIdentifier IReadOnlyExplicitMemberExpressionStandardMemberAccess.MemberName => MemberName;

    IReadOnlyGenericArgumentClause IReadOnlyExplicitMemberExpressionStandardMemberAccess.GenericArgumentClause =>
        GenericArgumentClause;

    public IType ReturnType { get; }

    IReadOnlyType IReadOnlyBaseExpression.ReturnType => ReturnType;

    public void ChangePostfixExpression(IPostfixExpression newPostfixExpression)
    {
        throw new System.NotImplementedException();
    }

    public void ChangeMember(IIdentifier newMemberToReference)
    {
        throw new System.NotImplementedException();
    }

    public void ChangeGenericArgumentClause(IGenericArgumentClause newGenericArgumentClause)
    {
        throw new System.NotImplementedException();
    }
}
