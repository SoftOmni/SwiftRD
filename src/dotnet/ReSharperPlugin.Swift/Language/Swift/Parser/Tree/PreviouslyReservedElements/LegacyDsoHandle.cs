using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.LeafNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.NodeTypes;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.PreviouslyReservedElements;

public class LegacyDsoHandle : SwiftLeafNode<SwiftCompositeNode>, ISwiftKeywordNode<LegacyDsoHandle>
{
    public const string Keyword = "#dsohandle";
    
    public LegacyDsoHandle()
        : base(new EditableBuffer(Keyword))
    { }
    
    internal LegacyDsoHandle(IEditableBuffer buffer)
        : base(buffer)
    { }

    public override NodeType NodeType => SwiftNodeTypes.PreviouslyReservedDsoHandle;

    public string KeywordValue => Keyword;

    public static LegacyDsoHandle Create()
    {
        return new LegacyDsoHandle();
    }
}
