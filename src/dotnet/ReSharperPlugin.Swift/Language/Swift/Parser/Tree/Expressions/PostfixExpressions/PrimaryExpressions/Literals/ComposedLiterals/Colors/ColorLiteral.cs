using JetBrains.DocumentModel.Impl;
using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Parser.Tree.Base.InternalNode;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.Literals.ComposedLiterals.Colors;

public class ColorLiteral : SwiftLeafNode, ISwiftKeyword
{
    public const string Keyword = "#colorLiteral";
    
    public Color? Color { get; internal set; }

    internal ColorLiteral(IEditableBuffer buffer) 
        : base(buffer, NodeTypes.NodeTypes.ReservedColorLiteral)
    { }

    internal ColorLiteral(SwiftInternalNode parent, IEditableBuffer buffer)
        : base(parent, buffer, NodeTypes.NodeTypes.ReservedColorLiteral)
    {
        if (parent is Color color)
        {
            Color = color;
        }
    }

    internal ColorLiteral(Color parent, IEditableBuffer buffer)
        : base(parent, buffer, NodeTypes.NodeTypes.ReservedColorLiteral)
    {
        Color = parent;
    }

    public string KeywordValue => Keyword;

    public static ColorLiteral Create()
    {
        return new ColorLiteral(new EditableBuffer(Keyword));
    }

    public static ColorLiteral Create(Color color)
    {
        return new ColorLiteral(color, new EditableBuffer(Keyword));
    }

    public static ColorLiteral CreateUnchecked(SwiftInternalNode parent)
    {
        return new ColorLiteral(parent, new EditableBuffer(Keyword));
    }
}