using System.Collections.Generic;
using JetBrains.Text;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.Literals;

public abstract class LiteralExpressionInternalNode : PrimaryExpressionInternalNode, ILiteralExpression<LiteralExpressionInternalNode>
{
    protected LiteralExpressionInternalNode(IEditableBuffer buffer, List<ISwiftNode> children)
        : base(buffer, children)
    { }

    protected LiteralExpressionInternalNode(IEditableBuffer buffer, IEnumerable<ISwiftNode> children)
        : base(buffer, children)
    { }

    protected LiteralExpressionInternalNode(ISwiftNode parent, IEditableBuffer buffer, List<ISwiftNode> nodes)
        : base(parent, buffer, nodes)
    { }

    protected LiteralExpressionInternalNode(ISwiftNode parent, IEditableBuffer buffer, IEnumerable<ISwiftNode> nodes)
        : base(parent, buffer, nodes)
    { }
}