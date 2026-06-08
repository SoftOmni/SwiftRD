using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.Literals;

public abstract class LiteralExpressionLeafNode : PrimaryExpressionLeafNode, ILiteralExpression<LiteralExpressionLeafNode>
{
    protected LiteralExpressionLeafNode(IEditableBuffer underlyingBuffer)
        : base(underlyingBuffer)
    { }

    protected LiteralExpressionLeafNode(IEditableBuffer underlyingBuffer, SwiftCompositeNode parentNode, int parentIndex, int parentTextIndex)
        : base(underlyingBuffer, parentNode, parentIndex, parentTextIndex)
    { }
}