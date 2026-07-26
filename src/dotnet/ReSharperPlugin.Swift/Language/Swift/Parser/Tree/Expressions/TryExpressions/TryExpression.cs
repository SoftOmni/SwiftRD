using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.OptionalTypes;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.TryOperators;

public class TryExpression : SwiftCompositeNode, ITryExpression
{
    public Try Try { get; }
    
    public QuestionMark? QuestionMark { get; private set; }
    
    public ExclamationMark? ExclamationMark { get; private set; }

    public IReadOnlyTryExpression.ExpressionKind Kind { get; private set; }

    public IExpression? TargetExpression { get; internal set; } = null;

    internal TryExpression(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        Try @try)
        : base(buffer, children)
    {
        Try = @try;
        Kind = IReadOnlyTryExpression.ExpressionKind.TryExpression;
    }

    internal TryExpression(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        Try @try, QuestionMark questionMark)
        : base(buffer, children)
    {
        Try = @try;
        QuestionMark = questionMark;
        Kind = IReadOnlyTryExpression.ExpressionKind.OptionalTryExpression;
    }

    internal TryExpression(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        Try @try, ExclamationMark exclamationMark)
        : base(buffer, children)
    {
        Try = @try;
        ExclamationMark = exclamationMark;
        Kind = IReadOnlyTryExpression.ExpressionKind.ForcedTryExpression;
    }
    
    IReadOnlyExpression? IReadOnlyTryExpression.TargetExpression => TargetExpression;

    public IType ReturnType
    {
        get
        {
            if (TargetExpression is null)
            {
                return UnknownType.Instance;
            }
            
            return Kind switch
            {
                IReadOnlyTryExpression.ExpressionKind.TryExpression => TargetExpression.ReturnType,
                IReadOnlyTryExpression.ExpressionKind.OptionalTryExpression => OptionalType.OptionalOf(TargetExpression.ReturnType),
                IReadOnlyTryExpression.ExpressionKind.ForcedTryExpression => TargetExpression.ReturnType,
                _ => null! // TODO: Log case that should never happen
            };
        }
    }

    IReadOnlyType IReadOnlyBaseExpression.ReturnType => ReturnType;

    public void MakeSimpleTryExpression()
    {
        QuestionMark?.DetachFromParent();
        ExclamationMark?.DetachFromParent();

        Kind = IReadOnlyTryExpression.ExpressionKind.TryExpression;
    }

    public void MakeOptionalTryExpression()
    {
        if (QuestionMark is not null)
        {
            return;
        }
        
        ExclamationMark?.DetachFromParent();
        QuestionMark questionMark = QuestionMark.Create();
        
        questionMark.AttachToParent(this, NumberOfChildren);
        Kind = IReadOnlyTryExpression.ExpressionKind.OptionalTryExpression;
        QuestionMark = questionMark;
    }

    public void MakeForcedTryExpression()
    {
        if (ExclamationMark is not null)
        {
            return;
        }
        
        QuestionMark?.DetachFromParent();
        ExclamationMark exclamationMark = ExclamationMark.Create();
        
        exclamationMark.AttachToParent(this, NumberOfChildren);
        Kind = IReadOnlyTryExpression.ExpressionKind.ForcedTryExpression;
        ExclamationMark = exclamationMark;
    }
}
