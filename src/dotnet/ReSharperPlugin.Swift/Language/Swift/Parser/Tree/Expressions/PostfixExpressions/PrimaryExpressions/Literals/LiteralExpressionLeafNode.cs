using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.InternalNode;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.Literals;

public abstract class LiteralExpressionLeafNode : PrimaryExpressionLeafNode, ILiteralExpression<LiteralExpressionLeafNode>
{
    protected LiteralExpressionLeafNode(IEditableBuffer buffer, NodeType nodeType)
        : base(buffer, nodeType)
    { }

    protected LiteralExpressionLeafNode(SwiftInternalNode parent, IEditableBuffer buffer, NodeType nodeType)
        : base(parent, buffer, nodeType)
    { }
}