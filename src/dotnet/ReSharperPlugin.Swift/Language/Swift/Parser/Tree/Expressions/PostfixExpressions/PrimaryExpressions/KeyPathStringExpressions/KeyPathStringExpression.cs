using System.Collections.Generic;
using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Parser.Tree.Punctuators;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.KeyPathStringExpressions;

public class KeyPathStringExpression : PrimaryExpressionInternalNode
{
    public KeyPathKeyword? Keyword { get; internal set; }
    
    public LeftParenthesis? LeftParenthesis { get; internal set; }
    
    public Expression? Expression { get; internal set; }
    
    public RightParenthesis? RightParenthesis { get; internal set; }
    
    public KeyPathStringExpression(IEditableBuffer buffer, List<ISwiftNode> children)
        : base(buffer, children)
    { }

    public KeyPathStringExpression(IEditableBuffer buffer, IEnumerable<ISwiftNode> children)
        : base(buffer, children)
    { }

    public KeyPathStringExpression(SwiftInternalNode parent, IEditableBuffer buffer, List<ISwiftNode> nodes)
        : base(parent, buffer, nodes)
    { }

    public KeyPathStringExpression(SwiftInternalNode parent, IEditableBuffer buffer, IEnumerable<ISwiftNode> nodes)
        : base(parent, buffer, nodes)
    { }
}