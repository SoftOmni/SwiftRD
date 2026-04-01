using JetBrains.DocumentModel.Impl;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.InternalNode;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.MetaTypes;

public class Protocol : SwiftLeafNode, ISwiftKeyword
{
    public const string Keyword = "Protocol";
    
    public ProtocolMetaType? ProtocolMetaType { get; internal set; }

    internal Protocol(IEditableBuffer buffer) 
        : base(buffer, SwiftNodeTypes.ProtocolUppercase)
    { }

    internal Protocol(SwiftInternalNode parent, IEditableBuffer buffer)
        : base(parent, buffer, SwiftNodeTypes.ProtocolUppercase)
    {
        if (parent is ProtocolMetaType protocolMetaType)
        {
            ProtocolMetaType = protocolMetaType;
        }
    }

    internal Protocol(ProtocolMetaType parent, IEditableBuffer buffer)
        : base(parent, buffer, SwiftNodeTypes.ProtocolUppercase)
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