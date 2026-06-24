using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Identifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.TupleExpressions;

public class TupleExpressionElement : SwiftCompositeNode, ITupleExpressionElement
{
    public IIdentifier Identifier { get; private set; }

    public Colon Colon { get; }

    public IExpression Expression { get; private set; }

    internal TupleExpressionElement(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        IIdentifier identifier, Colon colon, Expression expression)
        : base(buffer, children)
    {
        Identifier = identifier;
        Colon = colon;
        Expression = expression;
    }

    IReadOnlyIdentifier IReadOnlyTupleExpressionElement.Identifier => Identifier;

    IReadOnlyExpression IReadOnlyTupleExpressionElement.Expression => Expression;

    public void SetIdentifier(IIdentifier identifier)
    {
        int parentIndexOfIdentifier = Identifier.ParentIndex;
        Identifier.DetachFromParent();
        
        identifier.AttachToParent(this, parentIndexOfIdentifier);
        Identifier = identifier;
    }

    public void SetExpression(IExpression expression)
    {
        int parentIndexOfExpression = Expression.ParentIndex;
        Expression.DetachFromParent();
        
        expression.AttachToParent(this, parentIndexOfExpression);
        Expression = expression;
    }
}