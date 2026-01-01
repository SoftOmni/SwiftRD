using JetBrains.DocumentModel.Impl;
using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Parser.Tree.Base.InternalNode;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Types.MetaTypes;

public class Protocol : SwiftLeafNode, ISwiftKeyword
{
    public const string Keyword = "Protocol";
    
    public ProtocolMetaType? ProtocolMetaType { get; internal set; }

    internal Protocol(IEditableBuffer buffer) 
        : base(buffer, NodeTypes.NodeTypes.ProtocolUppercase)
    { }

    internal Protocol(SwiftInternalNode parent, IEditableBuffer buffer)
        : base(parent, buffer, NodeTypes.NodeTypes.ProtocolUppercase)
    {
        if (parent is ProtocolMetaType protocolMetaType)
        {
            ProtocolMetaType = protocolMetaType;
        }
    }

    internal Protocol(ProtocolMetaType parent, IEditableBuffer buffer)
        : base(parent, buffer, NodeTypes.NodeTypes.ProtocolUppercase)
    {
        ProtocolMetaType = parent;
    }

    public string KeywordValue => Keyword;

    public static Protocol Create()
    {
        return new Protocol(new EditableBuffer(Keyword));
    }

    public static Protocol Create(ProtocolMetaType protocolMetaType)
    {
        return new Protocol(protocolMetaType, new EditableBuffer(Keyword));
    }

    public static Protocol CreateUnchecked(SwiftInternalNode parent)
    {
        return new Protocol(parent, new EditableBuffer(Keyword));
    }
}