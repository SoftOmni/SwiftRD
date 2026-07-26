using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.LeafNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.NodeTypes;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Subscripts;

public class Subscript : SwiftLeafNode<SwiftCompositeNode>, ISwiftKeywordNode<Subscript>
{
    public const string Keyword = "subscriptKeyword";

    public Subscript()
        : base(new EditableBuffer(Keyword))
    { }

    internal Subscript(IEditableBuffer buffer)
        : base(buffer)
    { }

    public override NodeType NodeType => SwiftNodeTypes.Subscript;

    public string KeywordValue => Keyword;

    public static Subscript Create()
    {
        return new Subscript(new EditableBuffer(Keyword));
    }
}
