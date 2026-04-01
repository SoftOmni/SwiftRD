using JetBrains.DocumentModel.Impl;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.InternalNode;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.Literals.ComposedLiterals.Colors;

public class ColorLiteral : SwiftLeafNode, ISwiftKeyword
{
    public const string Keyword = "#colorLiteral";
    
    public Color? Color { get; internal set; }

    internal ColorLiteral(IEditableBuffer buffer) 
        : base(buffer, SwiftNodeTypes.ReservedColorLiteral)
    { }

    internal ColorLiteral(SwiftInternalNode parent, IEditableBuffer buffer)
        : base(parent, buffer, SwiftNodeTypes.ReservedColorLiteral)
    {
        if (parent is Color color)
        {
            Color = color;
        }
    }

    internal ColorLiteral(Color parent, IEditableBuffer buffer)
        : base(parent, buffer, SwiftNodeTypes.ReservedColorLiteral)
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