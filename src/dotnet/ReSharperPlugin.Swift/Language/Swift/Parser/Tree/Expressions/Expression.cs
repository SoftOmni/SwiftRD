using System;
using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.InfixExpressions;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PrefixExpressions;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.TryOperators;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions;

public class Expression : SwiftCompositeNode, IExpression
{
    public ITryExpression? AccompanyingTryExpression { get; private set; }

    public IAwaitExpression? AwaitExpression { get; internal set; }

    public IPrefixExpression PrefixExpression { get; internal set; }

    public IInfixExpressionGroup InfixExpressionGroup { get; internal set; }

    public IType ReturnType { get; }

    protected Expression(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        IPrefixExpression prefixExpression, IInfixExpressionGroup infixExpressionGroup,
        ITryExpression? accompanyingTryExpression = null, IAwaitExpression? awaitExpression = null)
        : base(buffer, children)
    {
        AccompanyingTryExpression = accompanyingTryExpression;
        AwaitExpression = awaitExpression;

        PrefixExpression = prefixExpression;
        InfixExpressionGroup = infixExpressionGroup;
        
        ReturnType = UnknownType.Instance;
    }

    public virtual bool CanHaveMultipleOnOneLineSeparatedBySemicolons => true;

    IReadOnlyTryExpression? IReadOnlyExpression.AccompanyingTryExpression => AccompanyingTryExpression;
    
    IReadOnlyType IReadOnlyBaseExpression.ReturnType => ReturnType;

    IReadOnlyAwaitExpression? IReadOnlyExpression.AwaitExpression => AwaitExpression;

    IReadOnlyInfixExpressionGroup IReadOnlyExpression.InfixExpressionGroup => InfixExpressionGroup;

    public bool AddTryExpression(IReadOnlyTryExpression.ExpressionKind kind)
    {
        if (AccompanyingTryExpression is not null)
        {
            ChangeTryExpression(kind);
            return false;
        }

        ITryExpression tryExpression = Try.CreateExpression(kind);
        AttachChild(0, tryExpression);
        AccompanyingTryExpression = tryExpression;
        return true;
    }

    public bool AddTryExpression(ITryExpression tryExpression)
    {
        if (AccompanyingTryExpression is not null)
        {
            ChangeTryExpression(tryExpression.Kind);
            return false;
        }

        AttachChild(0, tryExpression);
        AccompanyingTryExpression = tryExpression;
        return true;
    }

    private void ChangeTryExpression(IReadOnlyTryExpression.ExpressionKind kind)
    {
        if (AccompanyingTryExpression is null || kind == AccompanyingTryExpression.Kind)
        {
            return;
        }

        switch (kind)
        {
            case IReadOnlyTryExpression.ExpressionKind.TryExpression:
                AccompanyingTryExpression.MakeSimpleTryExpression();
                break;
            case IReadOnlyTryExpression.ExpressionKind.OptionalTryExpression:
                AccompanyingTryExpression.MakeOptionalTryExpression();
                break;
            case IReadOnlyTryExpression.ExpressionKind.ForcedTryExpression:
                AccompanyingTryExpression.MakeForcedTryExpression();
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(kind));
        }
    }

    public void RemoveTryExpression()
    {
        AccompanyingTryExpression?.DetachFromParent();
        AccompanyingTryExpression = null;
    }

    public void MakeExpressionAwaitable()
    {
        throw new NotImplementedException();
    }

    public void MakeExpressionNonAwaitable()
    {
        throw new NotImplementedException();
    }

    public void ChangePrefixExpression(IPrefixExpression prefixExpression)
    {
        throw new NotImplementedException();
    }
}
