using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.LeafNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.NodeTypes;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.PreviouslyReservedElements;

public class LegacyFileId : SwiftLeafNode<SwiftCompositeNode>, ISwiftKeywordNode<LegacyFileId>
{
    public const string Keyword = "#fileID";
    
    public LegacyFileId()
        : base(new EditableBuffer(Keyword))
    { }
    
    internal LegacyFileId(IEditableBuffer buffer)
        : base(buffer)
    { }

    public override NodeType NodeType => SwiftNodeTypes.PreviouslyReservedFileId;

    public string KeywordValue => Keyword;

    public static LegacyFileId Create()
    {
        return new LegacyFileId();
    }
}
