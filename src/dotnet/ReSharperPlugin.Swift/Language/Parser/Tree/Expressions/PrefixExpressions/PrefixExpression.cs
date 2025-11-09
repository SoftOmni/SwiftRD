using System.Collections.Generic;
using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Parser.Tree.Expressions.PostfixExpressions;
using ReSharperPlugin.Swift.Language.Parser.Tree.Types;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Expressions.PrefixExpressions;

public abstract class PrefixExpression : SwiftInternalNode
{
    public IType? Type { get; internal set; }
    
    public IPostfixExpression? PostfixExpression { get; internal set; }

    protected PrefixExpression(IEditableBuffer buffer, List<ISwiftNode> children)
        : base(buffer, children)
    { }

    protected PrefixExpression(IEditableBuffer buffer, IEnumerable<ISwiftNode> children)
        : base(buffer, children)
    { }

    protected PrefixExpression(ISwiftNode parent, IEditableBuffer buffer, List<ISwiftNode> nodes)
        : base(parent, buffer, nodes)
    { }

    protected PrefixExpression(ISwiftNode parent, IEditableBuffer buffer, IEnumerable<ISwiftNode> nodes)
        : base(parent, buffer, nodes)
    { }
}