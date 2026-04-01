using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.InternalNode;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PrefixExpressions;

public class PrefixOperatorExpression : PrefixExpression
{
    public PrefixOperator? PrefixOperator { get; internal set; }
    
    public PostfixExpressionInternalNode? PostfixExpression { get; internal set; }

    public PrefixOperatorExpression(IEditableBuffer buffer, List<ISwiftNode> children)
        : base(buffer, children)
    { }

    public PrefixOperatorExpression(IEditableBuffer buffer, IEnumerable<ISwiftNode> children)
        : base(buffer, children)
    { }

    public PrefixOperatorExpression(SwiftInternalNode parent, IEditableBuffer buffer, List<ISwiftNode> nodes)
        : base(parent, buffer, nodes)
    { }

    public PrefixOperatorExpression(SwiftInternalNode parent, IEditableBuffer buffer, IEnumerable<ISwiftNode> nodes)
        : base(parent, buffer, nodes)
    { }
}