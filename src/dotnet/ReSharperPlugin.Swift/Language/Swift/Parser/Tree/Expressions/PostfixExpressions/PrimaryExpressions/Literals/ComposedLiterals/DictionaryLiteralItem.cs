using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.InternalNode;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.Literals.ComposedLiterals;

public class DictionaryLiteralItem : SwiftInternalNode
{
    public Expression? KeyExpression { get; internal set; }
    
    public Colon? Colon { get; internal set; }
    
    public Expression? ValueExpression { get; internal set; }

    public DictionaryLiteralItem(IEditableBuffer buffer, List<ISwiftNode> children)
        : base(buffer, children)
    { }

    public DictionaryLiteralItem(IEditableBuffer buffer, IEnumerable<ISwiftNode> children)
        : base(buffer, children)
    { }

    public DictionaryLiteralItem(SwiftInternalNode parent, IEditableBuffer buffer, List<ISwiftNode> nodes)
        : base(parent, buffer, nodes)
    { }

    public DictionaryLiteralItem(SwiftInternalNode parent, IEditableBuffer buffer, IEnumerable<ISwiftNode> nodes)
        : base(parent, buffer, nodes)
    { }
}