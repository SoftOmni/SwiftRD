using JetBrains.DocumentModel.Impl;
using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Parser.Tree.Base.InternalNode;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.Literals.ComposedLiterals.Colors;

public class Blue : SwiftLeafNode, ISwiftKeyword
{
    public const string Keyword = "blue";
    
    public Color? Color { get; internal set; }

    internal Blue(IEditableBuffer buffer) 
        : base(buffer, NodeTypes.NodeTypes.Blue)
    { }

    internal Blue(SwiftInternalNode parent, IEditableBuffer buffer)
        : base(parent, buffer, NodeTypes.NodeTypes.Blue)
    {
        if (parent is Color color)
        {
            Color = color;
        }
    }

    internal Blue(Color parent, IEditableBuffer buffer)
        : base(parent, buffer, NodeTypes.NodeTypes.Blue)
    {
        Color = parent;
    }

    public string KeywordValue => Keyword;

    public static Blue Create()
    {
        return new Blue(new EditableBuffer(Keyword));
    }

    public static Blue Create(Color color)
    {
        return new Blue(color, new EditableBuffer(Keyword));
    }

    public static Blue CreateUnchecked(SwiftInternalNode parent)
    {
        return new Blue(parent, new EditableBuffer(Keyword));
    }
}