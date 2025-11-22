using JetBrains.DocumentModel.Impl;
using JetBrains.Text;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Declarations.Subscripts;

public class SubscriptKeyword : SwiftLeafNode, ISwiftKeyword
{
    public const string Keyword = "subscriptKeyword";
    
    public Subscript? Subscript { get; internal set; }

    internal SubscriptKeyword(IEditableBuffer buffer) 
        : base(buffer, NodeTypes.NodeTypes.Subscript)
    { }

    internal SubscriptKeyword(SwiftInternalNode parent, IEditableBuffer buffer)
        : base(parent, buffer, NodeTypes.NodeTypes.Subscript)
    {
        if (parent is Subscript subscript)
        {
            Subscript = subscript;
        }
    }

    internal SubscriptKeyword(Subscript parent, IEditableBuffer buffer)
        : base(parent, buffer, NodeTypes.NodeTypes.Subscript)
    {
        Subscript = parent;
    }

    public string KeywordValue => Keyword;

    public static SubscriptKeyword Create()
    {
        return new SubscriptKeyword(new EditableBuffer(Keyword));
    }

    public static SubscriptKeyword Create(Subscript subscript)
    {
        return new SubscriptKeyword(subscript, new EditableBuffer(Keyword));
    }

    public static SubscriptKeyword CreateUnchecked(SwiftInternalNode parent)
    {
        return new SubscriptKeyword(parent, new EditableBuffer(Keyword));
    }
}