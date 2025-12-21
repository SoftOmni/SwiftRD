using System.Collections.Generic;
using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Parser.Tree.Identifiers;
using ReSharperPlugin.Swift.Language.Parser.Tree.Punctuators;
using ReSharperPlugin.Swift.Language.Semantics.Type;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.Literals.ComposedLiterals.Colors;

public class Color : LiteralExpressionInternalNode, ILiteral<NSColor, Color>, IPlaygroundLiteral
// TODO: Adjust fundamental red blue green
{
    public ColorLiteral? ColorLiteral { get; internal set; }

    public LeftParenthesis? LeftParenthesis { get; internal set; }

    public Identifier? Red { get; internal set; }

    public Colon? RedColon { get; internal set; }

    public Expression? RedExpression { get; internal set; }

    public Comma? RedToGreenComma { get; internal set; }

    public Identifier? Green { get; internal set; }

    public Colon? GreenColon { get; internal set; }

    public Expression? GreenExpression { get; internal set; }

    public Comma? GreenToBlueComma { get; internal set; }

    public Identifier? Blue { get; internal set; }

    public Colon? BlueColon { get; internal set; }

    public Expression? BlueExpression { get; internal set; }

    public Comma? BlueToAlphaComma { get; internal set; }

    public Identifier? Alpha { get; internal set; }

    public Colon? AlphaColon { get; internal set; }

    public Expression? AlphaExpression { get; internal set; }

    public RightParenthesis? RightParenthesis { get; internal set; }

    public Color(IEditableBuffer buffer, List<ISwiftNode> children)
        : base(buffer, children)
    { }

    public Color(IEditableBuffer buffer, IEnumerable<ISwiftNode> children)
        : base(buffer, children)
    { }

    public Color(SwiftInternalNode parent, IEditableBuffer buffer, List<ISwiftNode> nodes)
        : base(parent, buffer, nodes)
    { }

    public Color(SwiftInternalNode parent, IEditableBuffer buffer, IEnumerable<ISwiftNode> nodes)
        : base(parent, buffer, nodes)
    { }

    public NSColor Type { get; }
    public Color Value { get; }
    public Color GetValueCopy()
    {
        throw new System.NotImplementedException();
    }

    public void SetValue(Color newValue)
    {
        throw new System.NotImplementedException();
    }
}