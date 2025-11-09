using System.Collections.Generic;
using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Parser.Tree.Expressions.PostfixExpressions;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Expressions.PrefixExpressions;

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

    public PrefixOperatorExpression(ISwiftNode parent, IEditableBuffer buffer, List<ISwiftNode> nodes)
        : base(parent, buffer, nodes)
    { }

    public PrefixOperatorExpression(ISwiftNode parent, IEditableBuffer buffer, IEnumerable<ISwiftNode> nodes)
        : base(parent, buffer, nodes)
    { }
}