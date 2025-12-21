using System.Collections.Generic;
using System.Drawing;
using JetBrains.Decompiler.Ast;
using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Parser.Tree.Identifiers;
using ReSharperPlugin.Swift.Language.Parser.Tree.Punctuators;
using ReSharperPlugin.Swift.Language.Semantics.Type;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.Literals.ComposedLiterals.ImageLiterals;

public class ImageLiteral : LiteralExpressionInternalNode, ILiteral<NSImage, Bitmap>, IPlaygroundLiteral
{
    public ImageLiteralKeyword? Keyword { get; internal set; }
    
    public LeftParenthesis? LeftParenthesis { get; internal set; }
    
    public Identifier? ResourceName { get; internal set; }
    
    public Colon? Colon { get; internal set; }
    
    public IExpression? Expression { get; internal set; }

    public ImageLiteral(IEditableBuffer buffer, List<ISwiftNode> children)
        : base(buffer, children)
    { }

    public ImageLiteral(IEditableBuffer buffer, IEnumerable<ISwiftNode> children)
        : base(buffer, children)
    { }

    public ImageLiteral(SwiftInternalNode parent, IEditableBuffer buffer, List<ISwiftNode> nodes)
        : base(parent, buffer, nodes)
    { }

    public ImageLiteral(SwiftInternalNode parent, IEditableBuffer buffer, IEnumerable<ISwiftNode> nodes)
        : base(parent, buffer, nodes)
    { }

    public NSImage Type { get; }
    public Bitmap Value { get; }
    public Bitmap GetValueCopy()
    {
        throw new System.NotImplementedException();
    }

    public void SetValue(Bitmap newValue)
    {
        throw new System.NotImplementedException();
    }
}