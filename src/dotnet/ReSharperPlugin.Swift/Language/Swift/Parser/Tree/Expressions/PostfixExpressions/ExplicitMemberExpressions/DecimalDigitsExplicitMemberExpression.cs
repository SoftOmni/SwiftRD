using System.Collections.Generic;
using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.Literals.Literals;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Expressions.PostfixExpressions.ExplicitMemberExpressions;

public class DecimalDigitsExplicitMemberExpression : ExplicitMemberExpression
{
    public IntegerLiteral? DecimalDigits { get; internal set; }
    
    public DecimalDigitsExplicitMemberExpression(IEditableBuffer buffer, List<ISwiftNode> children)
        : base(buffer, children)
    { }

    public DecimalDigitsExplicitMemberExpression(IEditableBuffer buffer, IEnumerable<ISwiftNode> children)
        : base(buffer, children)
    { }

    public DecimalDigitsExplicitMemberExpression(SwiftInternalNode parent, IEditableBuffer buffer, List<ISwiftNode> nodes)
        : base(parent, buffer, nodes)
    { }

    public DecimalDigitsExplicitMemberExpression(SwiftInternalNode parent, IEditableBuffer buffer, IEnumerable<ISwiftNode> nodes)
        : base(parent, buffer, nodes)
    { }
}