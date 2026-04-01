using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.InternalNode;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.Literals;

public abstract class LiteralExpressionInternalNode : PrimaryExpressionInternalNode, ILiteralExpression<LiteralExpressionInternalNode>
{
    protected LiteralExpressionInternalNode(IEditableBuffer buffer, List<ISwiftNode> children)
        : base(buffer, children)
    { }

    protected LiteralExpressionInternalNode(IEditableBuffer buffer, IEnumerable<ISwiftNode> children)
        : base(buffer, children)
    { }

    protected LiteralExpressionInternalNode(SwiftInternalNode parent, IEditableBuffer buffer, List<ISwiftNode> nodes)
        : base(parent, buffer, nodes)
    { }

    protected LiteralExpressionInternalNode(SwiftInternalNode parent, IEditableBuffer buffer, IEnumerable<ISwiftNode> nodes)
        : base(parent, buffer, nodes)
    { }
}