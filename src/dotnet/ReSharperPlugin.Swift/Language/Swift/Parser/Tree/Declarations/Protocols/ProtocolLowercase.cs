using JetBrains.DocumentModel.Impl;
using JetBrains.Text;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Protocols;

public class ProtocolLowercase : SwiftLeafNode, ISwiftKeywordNode
{
    public const string Keyword = "protocol";
    
    public Protocol? Protocol { get; internal set; }

    internal ProtocolLowercase(IEditableBuffer buffer) 
        : base(buffer, SwiftNodeTypes.ProtocolLowercase)
    { }

    internal ProtocolLowercase(SwiftInternalNode parent, IEditableBuffer buffer)
        : base(parent, buffer, SwiftNodeTypes.ProtocolLowercase)
    {
        if (parent is Protocol protocol)
        {
            Protocol = protocol;
        }
    }

    internal ProtocolLowercase(Protocol parent, IEditableBuffer buffer)
        : base(parent, buffer, SwiftNodeTypes.ProtocolLowercase)
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

    public static ProtocolLowercase CreateUnchecked(SwiftInternalNode parent)
    {
        return new ProtocolLowercase(parent, new EditableBuffer(Keyword));
    }
}