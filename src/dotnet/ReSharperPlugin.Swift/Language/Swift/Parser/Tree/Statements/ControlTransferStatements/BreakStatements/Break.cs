using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.LeafNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.NodeTypes;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.ControlTransferStatements.BreakStatements;

public class Break : SwiftLeafNode<SwiftCompositeNode>, ISwiftKeywordNode<Break>
{
    public const string Keyword = "break";
    
    public Break()
        : base(new EditableBuffer(Keyword))
    { }

    internal Break(IEditableBuffer underlyingBuffer)
        : base(underlyingBuffer)
    { }

    public override NodeType NodeType => SwiftNodeTypes.Break;

    public string KeywordValue => Keyword;

    public static Break Create()
    {
        return new Break();
    }
}
