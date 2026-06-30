using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.FunctionCallExpressions.Arguments;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.
    KeyPathStringExpressions;

public class KeyPathStringExpression : SwiftCompositeNode, IKeyPathStringExpression
{
    public KeyPathKeyword KeyPathKeyword { get; }

    public LeftParenthesis LeftParenthesis { get; }

    public IExpression Expression { get; }

    public RightParenthesis RightParenthesis { get; }

    internal KeyPathStringExpression(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        KeyPathKeyword keyPathKeyword, LeftParenthesis leftParenthesis, IExpression expression,
        RightParenthesis rightParenthesis)
        : base(buffer, children)
    {
        KeyPathKeyword = keyPathKeyword;
        LeftParenthesis = leftParenthesis;
        Expression = expression;
        RightParenthesis = rightParenthesis;
        
        ReturnType = UnknownType.Instance;
    }

    IReadOnlyExpression IReadOnlyKeyPathStringExpression.Expression => Expression;

    public IType ReturnType { get; }

    IReadOnlyType IReadOnlyBaseExpression.ReturnType => ReturnType;

    public IFunctionCallArgumentList GenerateEquivalentFunctionCallArgumentList()
    {
        throw new System.NotImplementedException();
    }

    public void ChangeExpression(IExpression newExpression)
    {
        throw new System.NotImplementedException();
    }
}
