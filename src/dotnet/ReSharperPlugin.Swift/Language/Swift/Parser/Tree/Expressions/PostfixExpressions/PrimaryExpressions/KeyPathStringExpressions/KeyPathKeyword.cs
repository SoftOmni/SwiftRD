using JetBrains.DocumentModel.Impl;
using JetBrains.Text;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.KeyPathStringExpressions;

public class KeyPathKeyword : SwiftLeafNode, ISwiftKeywordNode
{
    public const string Keyword = "#keyPath";
    
    public KeyPathStringExpression? KeyPathStringExpression { get; internal set; }

    internal KeyPathKeyword(IEditableBuffer buffer) 
        : base(buffer, SwiftNodeTypes.ReservedKeyPath)
    { }

    internal KeyPathKeyword(SwiftInternalNode parent, IEditableBuffer buffer)
        : base(parent, buffer, SwiftNodeTypes.ReservedKeyPath)
    {
        if (parent is KeyPathStringExpression keyPathStringExpression)
        {
            KeyPathStringExpression = keyPathStringExpression;
        }
    }

    internal KeyPathKeyword(KeyPathStringExpression parent, IEditableBuffer buffer)
        : base(parent, buffer, SwiftNodeTypes.ReservedKeyPath)
    {
        KeyPathStringExpression = parent;
    }

    public string KeywordValue => Keyword;

    public static KeyPathKeyword Create()
    {
        return new KeyPathKeyword(new EditableBuffer(Keyword));
    }

    public static KeyPathKeyword Create(KeyPathStringExpression keyPathStringExpression)
    {
        return new KeyPathKeyword(keyPathStringExpression, new EditableBuffer(Keyword));
    }

    public static KeyPathKeyword CreateUnchecked(SwiftInternalNode parent)
    {
        return new KeyPathKeyword(parent, new EditableBuffer(Keyword));
    }
}