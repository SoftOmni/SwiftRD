using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.LeafNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.NodeTypes;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Protocols;

public class Protocol : SwiftLeafNode<SwiftCompositeNode>, ISwiftKeywordNode<Protocol>
{
    public const string Keyword = "protocol";
    
    public Protocol()
        : base(new EditableBuffer())
    { }

    internal Protocol(IEditableBuffer buffer) 
        : base(buffer)
    { }

    public override NodeType NodeType => SwiftNodeTypes.ProtocolLowercase;

    public string KeywordValue => Keyword;

    public static Protocol Create()
    {
        return new Protocol(new EditableBuffer(Keyword));
    }
}
