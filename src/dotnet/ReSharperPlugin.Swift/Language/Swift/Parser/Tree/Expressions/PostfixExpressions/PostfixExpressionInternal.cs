using System.Collections.Generic;
using JetBrains.Text;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Expressions.PostfixExpressions;

public abstract class PostfixExpressionInternalNode : SwiftInternalNode, IPostfixExpression
{
    protected PostfixExpressionInternalNode(IEditableBuffer buffer, List<ISwiftNode> children)
        : base(buffer, children)
    { }

    protected PostfixExpressionInternalNode(IEditableBuffer buffer, IEnumerable<ISwiftNode> children)
        : base(buffer, children)
    { }

    protected PostfixExpressionInternalNode(SwiftInternalNode parent, IEditableBuffer buffer, List<ISwiftNode> nodes)
        : base(parent, buffer, nodes)
    { }

    protected PostfixExpressionInternalNode(SwiftInternalNode parent, IEditableBuffer buffer, IEnumerable<ISwiftNode> nodes)
        : base(parent, buffer, nodes)
    { }
}