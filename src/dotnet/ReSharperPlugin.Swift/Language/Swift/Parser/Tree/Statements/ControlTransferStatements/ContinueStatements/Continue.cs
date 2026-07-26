using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.LeafNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.NodeTypes;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.ControlTransferStatements.ContinueStatements;

public class Continue : SwiftLeafNode<SwiftCompositeNode>, ISwiftKeywordNode<Continue>
{
    public const string Keyword = "continue";
    
    public Continue()
        : base(new EditableBuffer(Keyword))
    { }

    internal Continue(IEditableBuffer underlyingBuffer)
        : base(underlyingBuffer)
    { }

    public override NodeType NodeType => SwiftNodeTypes.Continue;

    public string KeywordValue => Keyword;

    public static Continue Create()
    {
        return new Continue();
    }
}
