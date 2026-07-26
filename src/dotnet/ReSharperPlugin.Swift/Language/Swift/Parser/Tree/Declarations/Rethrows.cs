using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.LeafNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.NodeTypes;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations;

public class Rethrows : SwiftLeafNode<SwiftCompositeNode>, ISwiftKeywordNode<Rethrows>
{
    public const string Keyword = "rethrows";
    
    public Rethrows()
        : base(new EditableBuffer(Keyword))
    { }

    internal Rethrows(IEditableBuffer buffer)
        : base(buffer)
    { }

    public override NodeType NodeType => SwiftNodeTypes.Rethrows;

    public string KeywordValue => Keyword;

    public static Rethrows Create()
    {
        return new Rethrows(new EditableBuffer(Keyword));
    }
}
