using JetBrains.DocumentModel.Impl;
using JetBrains.Text;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.SelectorExpressions;

public class SelectorKeyword : SwiftLeafNode, ISwiftKeywordNode
{
    public const string Keyword = "#selectorKeyword";
    
    public SelectorExpression? SelectorExpression { get; internal set; }

    internal SelectorKeyword(IEditableBuffer buffer) 
        : base(buffer, SwiftNodeTypes.ReservedSelector)
    { }

    internal SelectorKeyword(SwiftInternalNode parent, IEditableBuffer buffer)
        : base(parent, buffer, SwiftNodeTypes.ReservedSelector)
    {
        if (parent is SelectorExpression selectorExpression)
        {
            SelectorExpression = selectorExpression;
        }
    }

    internal SelectorKeyword(SelectorExpression parent, IEditableBuffer buffer)
        : base(parent, buffer, SwiftNodeTypes.ReservedSelector)
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