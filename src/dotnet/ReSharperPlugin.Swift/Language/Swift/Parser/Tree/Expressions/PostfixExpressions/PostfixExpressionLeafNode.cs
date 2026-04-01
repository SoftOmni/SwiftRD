using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.InternalNode;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions;

public abstract class PostfixExpressionLeafNode : SwiftLeafNode, IPostfixExpression
{
    protected PostfixExpressionLeafNode(IEditableBuffer buffer, NodeType nodeType)
        : base(buffer, nodeType)
    { }

    protected PostfixExpressionLeafNode(SwiftInternalNode parent, IEditableBuffer buffer, NodeType nodeType)
        : base(parent, buffer, nodeType)
    { }
}