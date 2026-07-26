using System;
using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PrefixExpressions;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.TryOperators;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.InfixExpressions.AssignmentExpressions;

public class AssignmentOperatorExpression : SwiftCompositeNode, IAssignmentOperatorExpression
{
    public Equal Equal { get; }

    public ITryExpression? AccompanyingTryExpression { get; }
    
    public IAwaitExpression? AccompanyingAwaitExpression { get; }
    
    public IPrefixExpression PrefixExpression { get; }

    internal AssignmentOperatorExpression(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        Equal equal,
        IPrefixExpression prefixExpression, ITryExpression? accompanyingTryExpression = null,
        IAwaitExpression? accompanyingAwaitExpression = null)
        : base(buffer, children)
    {
        Equal = equal;
        PrefixExpression = prefixExpression;
        AccompanyingTryExpression = accompanyingTryExpression;
        AccompanyingAwaitExpression = accompanyingAwaitExpression;
    }

    IReadOnlyTryExpression? IReadOnlyAssignmentOperatorExpression.AccompanyingTryExpression => AccompanyingTryExpression;

    IReadOnlyAwaitExpression? IReadOnlyAssignmentOperatorExpression.AccompanyingAwaitExpression => AccompanyingAwaitExpression;

    IReadOnlyPrefixExpression IReadOnlyAssignmentOperatorExpression.PrefixExpression => PrefixExpression;

    public IType ReturnType => PrefixExpression.ReturnType;

    IReadOnlyType IReadOnlyBaseExpression.ReturnType => ReturnType;

    public void SetTryExpressionTo(ITryExpression? newAccompanyingTryExpression)
    {
        throw new NotImplementedException();
    }

    public void SetTryExpressionTo(IReadOnlyTryExpression.ExpressionKind kind)
    {
        throw new NotImplementedException();
    }

    public void RemoveTryExpression()
    {
        throw new NotImplementedException();
    }

    public void MakeAwaiting()
    {
        throw new NotImplementedException();
    }

    public void MakeNonAwaiting()
    {
        AccompanyingAwaitExpression?.DetachFromParent();
    }
}
