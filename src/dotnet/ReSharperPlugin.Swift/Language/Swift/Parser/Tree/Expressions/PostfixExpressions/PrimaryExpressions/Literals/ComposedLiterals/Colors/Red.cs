using JetBrains.DocumentModel.Impl;
using JetBrains.Text;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.Literals.ComposedLiterals.Colors;

public class Red : SwiftLeafNode, ISwiftKeyword
{
    public const string Keyword = "red";
    
    public Color? Color { get; internal set; }

    internal Red(IEditableBuffer buffer) 
        : base(buffer, NodeTypes.NodeTypes.Red)
    { }

    internal Red(SwiftInternalNode parent, IEditableBuffer buffer)
        : base(parent, buffer, NodeTypes.NodeTypes.Red)
    {
        if (parent is Color color)
        {
            Color = color;
        }
    }

    internal Red(Color parent, IEditableBuffer buffer)
        : base(parent, buffer, NodeTypes.NodeTypes.Red)
    {
        Color = parent;
    }

    public string KeywordValue => Keyword;

    public static Red Create()
    {
        return new Red(new EditableBuffer(Keyword));
    }

    public static Red Create(Color color)
    {
        return new Red(color, new EditableBuffer(Keyword));
    }

    public static Red CreateUnchecked(SwiftInternalNode parent)
    {
        return new Red(parent, new EditableBuffer(Keyword));
    }
}