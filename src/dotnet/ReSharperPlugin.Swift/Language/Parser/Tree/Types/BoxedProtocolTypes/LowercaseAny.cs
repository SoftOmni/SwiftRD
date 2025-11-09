using JetBrains.DocumentModel.Impl;
using JetBrains.Text;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Types.BoxedProtocolTypes;

public class LowercaseAny : SwiftLeafNode, ISwiftKeyword
{
    public const string Keyword = "any";
    
    public BoxedProtocolType? BoxedProtocolType { get; internal set; }

    internal LowercaseAny(IEditableBuffer buffer) 
        : base(buffer, NodeTypes.NodeTypes.AnyLowercase)
    { }

    internal LowercaseAny(ISwiftNode parent, IEditableBuffer buffer)
        : base(parent, buffer, NodeTypes.NodeTypes.AnyLowercase)
    {
        if (parent is BoxedProtocolType boxedProtocolType)
        {
            BoxedProtocolType = boxedProtocolType;
        }
    }

    internal LowercaseAny(BoxedProtocolType parent, IEditableBuffer buffer)
        : base(parent, buffer, NodeTypes.NodeTypes.AnyLowercase)
    {
        BoxedProtocolType = parent;
    }

    public string KeywordValue => Keyword;

    public static LowercaseAny Create()
    {
        return new LowercaseAny(new EditableBuffer(Keyword));
    }

    public static LowercaseAny Create(BoxedProtocolType boxedProtocolType)
    {
        return new LowercaseAny(boxedProtocolType, new EditableBuffer(Keyword));
    }

    public static LowercaseAny CreateUnchecked(ISwiftNode parent)
    {
        return new LowercaseAny(parent, new EditableBuffer(Keyword));
    }
}