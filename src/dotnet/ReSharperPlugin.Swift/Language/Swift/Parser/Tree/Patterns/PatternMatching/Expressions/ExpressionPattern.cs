using System;
using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Patterns.PatternMatching.Expressions;

public class ExpressionPattern : SwiftCompositeNode, IExpressionPattern
{
    public IExpression Expression { get; }

    internal ExpressionPattern(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        IExpression expression)
        : base(buffer, children)
    {
        Expression = expression;
    }

    IReadOnlyExpression IReadOnlyExpressionPattern.Expression => Expression;

    public void SetExpression(IExpression expression)
    {
        throw new NotImplementedException();
    }
}