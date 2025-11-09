using System.Collections.Generic;
using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Parser.Tree.Expressions.PrefixExpressions;
using ReSharperPlugin.Swift.Language.Parser.Tree.Expressions.TryOperators;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Expressions.InfixExpressions;

public class ConditionalOperatorInfixExpression : InfixExpression
{
    public TernaryOperator? ConditionalOperator { get; internal set; }
    
    public TryOperator? TryOperator { get; internal set; }
    
    public Await? Await { get; internal set; }
    
    public PrefixExpression? PrefixExpression { get; internal set; }
    
    public ConditionalOperatorInfixExpression(IEditableBuffer buffer, List<ISwiftNode> children)
        : base(buffer, children)
    { }

    public ConditionalOperatorInfixExpression(IEditableBuffer buffer, IEnumerable<ISwiftNode> children)
        : base(buffer, children)
    { }

    public ConditionalOperatorInfixExpression(ISwiftNode parent, IEditableBuffer buffer, List<ISwiftNode> nodes)
        : base(parent, buffer, nodes)
    { }

    public ConditionalOperatorInfixExpression(ISwiftNode parent, IEditableBuffer buffer, IEnumerable<ISwiftNode> nodes)
        : base(parent, buffer, nodes)
    { }
}