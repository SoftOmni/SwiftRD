using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.LeafNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.NodeTypes;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.PreviouslyReservedElements;

public class LegacyLine : SwiftLeafNode<SwiftCompositeNode>, ISwiftKeywordNode<LegacyLine>
{
    public const string Keyword = "#line";
    
    public LegacyLine()
        : base(new EditableBuffer(Keyword))
    { }
    
    internal LegacyLine(IEditableBuffer buffer)
        : base(buffer)
    { }

    public override NodeType NodeType => SwiftNodeTypes.PreviouslyReservedLine;

    public string KeywordValue => Keyword;

    public static LegacyLine Create()
    {
        return new LegacyLine();
    }
}
