using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.LeafNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.NodeTypes;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.PreviouslyReservedElements;

public class LegacyColumn : SwiftLeafNode<SwiftCompositeNode>, ISwiftKeywordNode<LegacyColumn>
{
    public const string Keyword = "#column";
    
    public LegacyColumn()
        : base(new EditableBuffer(Keyword))
    { }
    
    internal LegacyColumn(IEditableBuffer buffer)
        : base(buffer)
    { }

    public override NodeType NodeType => SwiftNodeTypes.PreviouslyReservedColumn;

    public string KeywordValue => Keyword;

    public static LegacyColumn Create()
    {
        return new LegacyColumn();
    }
}
