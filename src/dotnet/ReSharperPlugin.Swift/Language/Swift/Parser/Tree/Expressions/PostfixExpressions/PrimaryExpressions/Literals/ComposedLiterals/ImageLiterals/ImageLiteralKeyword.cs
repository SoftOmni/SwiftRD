using JetBrains.DocumentModel.Impl;
using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Parser.Tree.Base.InternalNode;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.Literals.ComposedLiterals.ImageLiterals;

public class ImageLiteralKeyword : SwiftLeafNode, ISwiftKeyword
{
    public const string Keyword = "#imageLiteral";
    
    public ImageLiteral? ImageLiteral { get; internal set; }

    internal ImageLiteralKeyword(IEditableBuffer buffer) 
        : base(buffer, NodeTypes.NodeTypes.ReservedImageLiteral)
    { }

    internal ImageLiteralKeyword(SwiftInternalNode parent, IEditableBuffer buffer)
        : base(parent, buffer, NodeTypes.NodeTypes.ReservedImageLiteral)
    {
        if (parent is ImageLiteral imageLiteral)
        {
            ImageLiteral = imageLiteral;
        }
    }

    internal ImageLiteralKeyword(ImageLiteral parent, IEditableBuffer buffer)
        : base(parent, buffer, NodeTypes.NodeTypes.ReservedImageLiteral)
    {
        ImageLiteral = parent;
    }

    public string KeywordValue => Keyword;

    public static ImageLiteralKeyword Create()
    {
        return new ImageLiteralKeyword(new EditableBuffer(Keyword));
    }

    public static ImageLiteralKeyword Create(ImageLiteral imageLiteral)
    {
        return new ImageLiteralKeyword(imageLiteral, new EditableBuffer(Keyword));
    }

    public static ImageLiteralKeyword CreateUnchecked(SwiftInternalNode parent)
    {
        return new ImageLiteralKeyword(parent, new EditableBuffer(Keyword));
    }
}