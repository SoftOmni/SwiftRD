using JetBrains.DocumentModel.Impl;
using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Parser.Tree.Base.InternalNode;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.Literals.ComposedLiterals.Colors;

public class Green : SwiftLeafNode, ISwiftKeyword
{
    public const string Keyword = "green";
    
    public Color? Color { get; internal set; }

    internal Green(IEditableBuffer buffer) 
        : base(buffer, NodeTypes.NodeTypes.Green)
    { }

    internal Green(SwiftInternalNode parent, IEditableBuffer buffer)
        : base(parent, buffer, NodeTypes.NodeTypes.Green)
    {
        if (parent is Color color)
        {
            Color = color;
        }
    }

    internal Green(Color parent, IEditableBuffer buffer)
        : base(parent, buffer, NodeTypes.NodeTypes.Green)
    {
        Color = parent;
    }

    public string KeywordValue => Keyword;

    public static Green Create()
    {
        return new Green(new EditableBuffer(Keyword));
    }

    public static Green Create(Color color)
    {
        return new Green(color, new EditableBuffer(Keyword));
    }

    public static Green CreateUnchecked(SwiftInternalNode parent)
    {
        return new Green(parent, new EditableBuffer(Keyword));
    }
}