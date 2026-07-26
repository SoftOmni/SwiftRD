using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.LeafNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.NodeTypes;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.LoopStatements.ForInStatements;

public class For : SwiftLeafNode<SwiftCompositeNode>, ISwiftKeywordNode<For>
{
    public const string Keyword = "for";

    public For()
        : base(new EditableBuffer(Keyword))
    { }

    internal For(IEditableBuffer underlyingBuffer)
        : base(underlyingBuffer)
    { }

    public override NodeType NodeType => SwiftNodeTypes.For;

    public string KeywordValue => Keyword;

    public static For Create()
    {
        return new For(new EditableBuffer(Keyword));
    }
}
