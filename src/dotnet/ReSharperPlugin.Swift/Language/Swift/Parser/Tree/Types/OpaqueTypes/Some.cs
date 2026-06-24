using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.LeafNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.NodeTypes;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.OpaqueTypes;

public class Some : SwiftLeafNode<SwiftCompositeNode>, ISwiftKeywordNode<Some>
{
    public const string Keyword = "some";
    
    public Some()
        : base(new EditableBuffer(Keyword))
    { }

    internal Some(IEditableBuffer buffer) 
        : base(buffer)
    { }

    public override NodeType NodeType => SwiftNodeTypes.Some;

    public string KeywordValue => Keyword;

    public static Some Create()
    {
        return new Some(new EditableBuffer(Keyword));
    }
}