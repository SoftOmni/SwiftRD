using JetBrains.DocumentModel.Impl;
using JetBrains.Text;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Declarations.Protocols;

public class ProtocolLowercase : SwiftLeafNode, ISwiftKeyword
{
    public const string Keyword = "protocol";
    
    public Protocol? Protocol { get; internal set; }

    internal ProtocolLowercase(IEditableBuffer buffer) 
        : base(buffer, NodeTypes.NodeTypes.ProtocolLowercase)
    { }

    internal ProtocolLowercase(ISwiftNode parent, IEditableBuffer buffer)
        : base(parent, buffer, NodeTypes.NodeTypes.ProtocolLowercase)
    {
        if (parent is Protocol protocol)
        {
            Protocol = protocol;
        }
    }

    internal ProtocolLowercase(Protocol parent, IEditableBuffer buffer)
        : base(parent, buffer, NodeTypes.NodeTypes.ProtocolLowercase)
    {
        Protocol = parent;
    }

    public string KeywordValue => Keyword;

    public static ProtocolLowercase Create()
    {
        return new ProtocolLowercase(new EditableBuffer(Keyword));
    }

    public static ProtocolLowercase Create(Protocol protocol)
    {
        return new ProtocolLowercase(protocol, new EditableBuffer(Keyword));
    }

    public static ProtocolLowercase CreateUnchecked(ISwiftNode parent)
    {
        return new ProtocolLowercase(parent, new EditableBuffer(Keyword));
    }
}