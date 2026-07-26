using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.LeafNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.NodeTypes;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.ControlTransferStatements.ThrowStatements;

public class Throw : SwiftLeafNode<SwiftCompositeNode>, ISwiftKeywordNode<Throw>
{
    public const string Keyword = "throw";
    
    public Throw()
        : base(new EditableBuffer(Keyword))
    { }

    internal Throw(IEditableBuffer underlyingBuffer)
        : base(underlyingBuffer)
    { }

    public override NodeType NodeType => SwiftNodeTypes.Throw;

    public string KeywordValue => Keyword;

    public static Throw Create()
    {
        return new Throw();
    }
}
