using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.LeafNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.NodeTypes;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.PreviouslyReservedElements;

public class LegacyFile : SwiftLeafNode<SwiftCompositeNode>, ISwiftKeywordNode<LegacyFile>
{
    public const string Keyword = "#file";
    
    public LegacyFile()
        : base(new EditableBuffer(Keyword))
    { }
    
    internal LegacyFile(IEditableBuffer buffer)
        : base(buffer)
    { }

    public override NodeType NodeType => SwiftNodeTypes.PreviouslyReservedFile;

    public string KeywordValue => Keyword;

    public static LegacyFile Create()
    {
        return new LegacyFile();
    }
}
