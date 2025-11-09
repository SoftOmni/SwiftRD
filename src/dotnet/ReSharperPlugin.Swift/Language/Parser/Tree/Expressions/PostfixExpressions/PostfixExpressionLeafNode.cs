using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Expressions.PostfixExpressions;

public abstract class PostfixExpressionLeafNode : SwiftLeafNode, IPostfixExpression
{
    protected PostfixExpressionLeafNode(IEditableBuffer buffer, NodeType nodeType)
        : base(buffer, nodeType)
    { }

    protected PostfixExpressionLeafNode(ISwiftNode parent, IEditableBuffer buffer, NodeType nodeType)
        : base(parent, buffer, nodeType)
    { }
}