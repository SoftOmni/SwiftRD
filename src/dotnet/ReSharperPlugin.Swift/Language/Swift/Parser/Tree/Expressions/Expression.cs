using System.Collections.Generic;
using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Parser.Tree.Base.InternalNode;
using ReSharperPlugin.Swift.Language.Parser.Tree.Expressions.InfixExpressions;
using ReSharperPlugin.Swift.Language.Parser.Tree.Expressions.PrefixExpressions;
using ReSharperPlugin.Swift.Language.Parser.Tree.Expressions.TryOperators;
using ReSharperPlugin.Swift.Language.Parser.Tree.Statements;
using ReSharperPlugin.Swift.Language.Parser.Tree.Types;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Expressions;

public class Expression : StatementInternalNode
{
    public TryOperator? TryOperator { get; internal set; }
    
    public Await? Await { get; internal set; }
    
    public PrefixExpression? PrefixExpression { get; internal set; }
    
    public InfixExpressionGroup? InfixExpression { get; internal set; }
    
    public IType? Type { get; internal set; }

    public Expression(IEditableBuffer buffer, List<ISwiftNode> children)
        : base(buffer, children)
    { }

    public Expression(IEditableBuffer buffer, IEnumerable<ISwiftNode> children)
        : base(buffer, children)
    { }

    public Expression(SwiftInternalNode parent, IEditableBuffer buffer, List<ISwiftNode> nodes)
        : base(parent, buffer, nodes)
    { }

    public Expression(SwiftInternalNode parent, IEditableBuffer buffer, IEnumerable<ISwiftNode> nodes)
        : base(parent, buffer, nodes)
    { }
}