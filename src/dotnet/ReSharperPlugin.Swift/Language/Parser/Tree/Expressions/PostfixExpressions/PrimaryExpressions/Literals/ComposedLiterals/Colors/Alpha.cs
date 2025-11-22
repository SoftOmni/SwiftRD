using JetBrains.DocumentModel.Impl;
using JetBrains.Text;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.Literals.ComposedLiterals.Colors;

public class Alpha : SwiftLeafNode, ISwiftKeyword
{
    public const string Keyword = "alpha";
    
    public Color? Color { get; internal set; }

    internal Alpha(IEditableBuffer buffer) 
        : base(buffer, NodeTypes.NodeTypes.Alpha)
    { }

    internal Alpha(SwiftInternalNode parent, IEditableBuffer buffer)
        : base(parent, buffer, NodeTypes.NodeTypes.Alpha)
    {
        if (parent is Color color)
        {
            Color = color;
        }
    }

    internal Alpha(Color parent, IEditableBuffer buffer)
        : base(parent, buffer, NodeTypes.NodeTypes.Alpha)
    {
        Color = parent;
    }

    public string KeywordValue => Keyword;

    public static Alpha Create()
    {
        return new Alpha(new EditableBuffer(Keyword));
    }

    public static Alpha Create(Color color)
    {
        return new Alpha(color, new EditableBuffer(Keyword));
    }

    public static Alpha CreateUnchecked(SwiftInternalNode parent)
    {
        return new Alpha(parent, new EditableBuffer(Keyword));
    }
}