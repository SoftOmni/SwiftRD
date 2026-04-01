using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.InternalNode;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PrefixExpressions;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.TryOperators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.InfixExpressions;

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

    public ConditionalOperatorInfixExpression(SwiftInternalNode parent, IEditableBuffer buffer, List<ISwiftNode> nodes)
        : base(parent, buffer, nodes)
    { }

    public ConditionalOperatorInfixExpression(SwiftInternalNode parent, IEditableBuffer buffer, IEnumerable<ISwiftNode> nodes)
        : base(parent, buffer, nodes)
    { }
}