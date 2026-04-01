using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.InternalNode;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions;

public class PrimaryExpressionLeafNode : PostfixExpressionLeafNode, IPrimaryExpression
{
    public PrimaryExpressionLeafNode(IEditableBuffer buffer, NodeType nodeType)
        : base(buffer, nodeType)
    { }

    public PrimaryExpressionLeafNode(SwiftInternalNode parent, IEditableBuffer buffer, NodeType nodeType)
        : base(parent, buffer, nodeType)
    { }
}