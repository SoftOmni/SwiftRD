using JetBrains.DocumentModel.Impl;
using JetBrains.Text;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.SelectorExpressions;

public class SelectorKeyword : SwiftLeafNode, ISwiftKeyword
{
    public const string Keyword = "#selectorKeyword";
    
    public SelectorExpression? SelectorExpression { get; internal set; }

    internal SelectorKeyword(IEditableBuffer buffer) 
        : base(buffer, NodeTypes.NodeTypes.ReservedSelector)
    { }

    internal SelectorKeyword(SwiftInternalNode parent, IEditableBuffer buffer)
        : base(parent, buffer, NodeTypes.NodeTypes.ReservedSelector)
    {
        if (parent is SelectorExpression selectorExpression)
        {
            SelectorExpression = selectorExpression;
        }
    }

    internal SelectorKeyword(SelectorExpression parent, IEditableBuffer buffer)
        : base(parent, buffer, NodeTypes.NodeTypes.ReservedSelector)
    {
        SelectorExpression = parent;
    }

    public string KeywordValue => Keyword;

    public static SelectorKeyword Create()
    {
        return new SelectorKeyword(new EditableBuffer(Keyword));
    }

    public static SelectorKeyword Create(SelectorExpression selectorExpression)
    {
        return new SelectorKeyword(selectorExpression, new EditableBuffer(Keyword));
    }

    public static SelectorKeyword CreateUnchecked(SwiftInternalNode parent)
    {
        return new SelectorKeyword(parent, new EditableBuffer(Keyword));
    }
}