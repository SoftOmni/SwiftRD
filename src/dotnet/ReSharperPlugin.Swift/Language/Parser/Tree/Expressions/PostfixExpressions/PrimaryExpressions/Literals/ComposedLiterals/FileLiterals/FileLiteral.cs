using System;
using System.Collections.Generic;
using JetBrains.ReSharper.Psi.Tree;
using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Parser.Tree.Identifiers;
using ReSharperPlugin.Swift.Language.Parser.Tree.Punctuators;
using ReSharperPlugin.Swift.Language.Semantics.Type;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.Literals.ComposedLiterals.FileLiterals;

public class FileLiteral : LiteralExpressionInternalNode, ILiteral<URL, Uri>, IPlaygroundLiteral
{
    public FileLiteralKeyword Keyword { get; internal set; }
    
    public LeftParenthesis? LeftParenthesis { get; internal set; }
    
    public Identifier? ResourceName { get; internal set; }
    
    public Colon? Colon { get; internal set; }
    
    public IExpression? Expression { get; internal set; }

    public FileLiteral(IEditableBuffer buffer, List<ISwiftNode> children)
        : base(buffer, children)
    { }

    public FileLiteral(IEditableBuffer buffer, IEnumerable<ISwiftNode> children)
        : base(buffer, children)
    { }

    public FileLiteral(ISwiftNode parent, IEditableBuffer buffer, List<ISwiftNode> nodes)
        : base(parent, buffer, nodes)
    { }

    public FileLiteral(ISwiftNode parent, IEditableBuffer buffer, IEnumerable<ISwiftNode> nodes)
        : base(parent, buffer, nodes)
    { }

    public URL Type { get; }
    public Uri Value { get; }
    public Uri GetValueCopy()
    {
        throw new NotImplementedException();
    }

    public void SetValue(Uri newValue)
    {
        throw new NotImplementedException();
    }
}