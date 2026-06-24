using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.LeafNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.NodeTypes;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.MetaTypes;

public class ProtocolUppercase : SwiftLeafNode<SwiftCompositeNode>, ISwiftKeywordNode<ProtocolUppercase>
{
    public const string Keyword = "Protocol";
    
    public ProtocolUppercase()
        : base(new EditableBuffer(Keyword))
    { }
    
    internal ProtocolUppercase(IEditableBuffer buffer) 
        : base(buffer)
    { }

    public override NodeType NodeType => SwiftNodeTypes.ProtocolUppercase;

    public string KeywordValue => Keyword;

    public static ProtocolUppercase Create()
    {
        return new ProtocolUppercase(new EditableBuffer(Keyword));
    }
}
