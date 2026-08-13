using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.LeafNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.NodeTypes;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.PreviouslyReservedElements;

public class LegacyFilePath : SwiftLeafNode<SwiftCompositeNode>, ISwiftKeywordNode<LegacyFilePath>
{
    public const string Keyword = "#filePath";
    
    public LegacyFilePath()
        : base(new EditableBuffer(Keyword))
    { }
    
    internal LegacyFilePath(IEditableBuffer buffer)
        : base(buffer)
    { }

    public override NodeType NodeType => SwiftNodeTypes.PreviouslyReservedFilePath;

    public string KeywordValue => Keyword;

    public static LegacyFilePath Create()
    {
        return new LegacyFilePath();
    }
}
