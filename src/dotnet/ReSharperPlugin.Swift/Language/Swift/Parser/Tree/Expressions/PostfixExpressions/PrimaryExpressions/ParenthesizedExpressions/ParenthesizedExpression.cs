using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.ParenthesizedExpressions;

public class ParenthesizedExpression : SwiftCompositeNode, IParenthesizedExpression
{
    public LeftParenthesis LeftParenthesis { get; }

    public IExpression Expression { get; }

    public RightParenthesis RightParenthesis { get; }

    internal ParenthesizedExpression(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children, 
        LeftParenthesis leftParenthesis, IExpression expression, RightParenthesis rightParenthesis)
        : base(buffer, children)
    {
        LeftParenthesis = leftParenthesis;
        Expression = expression;
        RightParenthesis = rightParenthesis;
        
        ReturnType = UnknownType.Instance;
    }

    IReadOnlyExpression IReadOnlyParenthesizedExpression.Expression => Expression;

    public IType ReturnType { get; }

    IReadOnlyType IReadOnlyBaseExpression.ReturnType => ReturnType;

    public void ChangeExpression(IExpression newExpression)
    {
        throw new System.NotImplementedException();
    }
}
