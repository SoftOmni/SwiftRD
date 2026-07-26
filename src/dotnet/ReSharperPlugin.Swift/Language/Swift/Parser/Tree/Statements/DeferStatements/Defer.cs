using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.LeafNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.NodeTypes;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.ControlTransferStatements.DeferStatements;

public class Defer : SwiftLeafNode<SwiftCompositeNode>, ISwiftKeywordNode<Defer>
{
    public const string Keyword = "defer";
    
    public Defer()
        : base(new EditableBuffer(Keyword))
    { }

    internal Defer(IEditableBuffer underlyingBuffer)
        : base(underlyingBuffer)
    { }

    public override NodeType NodeType => SwiftNodeTypes.Defer;

    public string KeywordValue => Keyword;

    public static Defer Create()
    {
        return new Defer();
    }
}
