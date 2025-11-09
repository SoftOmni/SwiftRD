using System.Collections.Generic;
using JetBrains.Text;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Expressions.PostfixExpressions.FunctionCallExpressions.Arguments;

public class ExpressionCallArgument : CallArgument
{
    public Expression? Expression { get; internal set; }

    public ExpressionCallArgument(IEditableBuffer buffer, List<ISwiftNode> children)
        : base(buffer, children)
    { }

    public ExpressionCallArgument(IEditableBuffer buffer, IEnumerable<ISwiftNode> children)
        : base(buffer, children)
    { }

    public ExpressionCallArgument(ISwiftNode parent, IEditableBuffer buffer, List<ISwiftNode> nodes)
        : base(parent, buffer, nodes)
    { }

    public ExpressionCallArgument(ISwiftNode parent, IEditableBuffer buffer, IEnumerable<ISwiftNode> nodes)
        : base(parent, buffer, nodes)
    { }
}