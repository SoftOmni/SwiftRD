using System;
using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PrefixExpressions;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.TryOperators;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.InfixExpressions.TernaryExpressions;

public class TernaryOperatorExpression : SwiftCompositeNode, ITernaryOperatorExpression
{
    public QuestionMark QuestionMark { get; }
    
    public IExpression Expression { get; }
    
    public Colon Colon { get; }
    
    public ITryExpression? AccompanyingTryExpression { get; }
    
    public IAwaitExpression? AccompanyingAwaitExpression { get; }
    
    public IPrefixExpression PrefixExpression { get; }

    internal TernaryOperatorExpression(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        QuestionMark questionMark, IExpression expression, Colon colon,
        IPrefixExpression prefixExpression, ITryExpression? accompanyingTryExpression = null,
        IAwaitExpression? accompanyingAwaitExpression = null)
        : base(buffer, children)
    {
        QuestionMark = questionMark;
        Expression = expression;
        Colon = colon;
        
        PrefixExpression = prefixExpression;
        AccompanyingTryExpression = accompanyingTryExpression;
        AccompanyingAwaitExpression = accompanyingAwaitExpression;
    }

    IReadOnlyExpression IReadOnlyTernaryOperatorExpression.Expression => Expression;

    IReadOnlyTryExpression? IReadOnlyTernaryOperatorExpression.AccompanyingTryExpression => AccompanyingTryExpression;

    IReadOnlyAwaitExpression? IReadOnlyTernaryOperatorExpression.AccompanyingAwaitExpression => AccompanyingAwaitExpression;

    IReadOnlyPrefixExpression IReadOnlyTernaryOperatorExpression.PrefixExpression => PrefixExpression;

    public IType ReturnType => PrefixExpression.ReturnType;

    IReadOnlyType IReadOnlyBaseExpression.ReturnType => ReturnType;

    public void ChangeExpression(IExpression newExpression)
    {
        throw new NotImplementedException();
    }

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
