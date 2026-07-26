using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.LeafNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.NodeTypes;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.ControlTransferStatements.ReturnStatements;

public class Return : SwiftLeafNode<SwiftCompositeNode>, ISwiftKeywordNode<Return>
{
    public const string Keyword = "return";
    
    public Return()
        : base(new EditableBuffer(Keyword))
    { }

    internal Return(IEditableBuffer underlyingBuffer)
        : base(underlyingBuffer)
    { }

    public override NodeType NodeType => SwiftNodeTypes.Return;

    public string KeywordValue => Keyword;

    public static Return Create()
    {
        return new Return();
    }
}
