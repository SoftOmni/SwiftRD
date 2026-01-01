using System.Collections.Generic;
using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Parser.Tree.Base.InternalNode;
using ReSharperPlugin.Swift.Language.Parser.Tree.Expressions.PrefixExpressions;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Expressions.InfixExpressions;

public class InfixOperatorExpression : InfixExpression
{
    public InfixOperator? InfixOperator { get; internal set; }
    
    public PrefixExpression? PrefixExpression { get; internal set; }
    
    public InfixOperatorExpression(IEditableBuffer buffer, List<ISwiftNode> children)
        : base(buffer, children)
    { }

    public InfixOperatorExpression(IEditableBuffer buffer, IEnumerable<ISwiftNode> children)
        : base(buffer, children)
    { }

    public InfixOperatorExpression(SwiftInternalNode parent, IEditableBuffer buffer, List<ISwiftNode> nodes)
        : base(parent, buffer, nodes)
    { }

    public InfixOperatorExpression(SwiftInternalNode parent, IEditableBuffer buffer, IEnumerable<ISwiftNode> nodes)
        : base(parent, buffer, nodes)
    { }
}