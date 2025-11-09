using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions;

public class PrimaryExpressionLeafNode : PostfixExpressionLeafNode, IPrimaryExpression
{
    public PrimaryExpressionLeafNode(IEditableBuffer buffer, NodeType nodeType)
        : base(buffer, nodeType)
    { }

    public PrimaryExpressionLeafNode(ISwiftNode parent, IEditableBuffer buffer, NodeType nodeType)
        : base(parent, buffer, nodeType)
    { }
}