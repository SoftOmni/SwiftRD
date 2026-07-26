using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.LeafNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.NodeTypes;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Generics.GenericWhereClauseClauses;

public class Where : SwiftLeafNode<SwiftCompositeNode>, ISwiftKeywordNode<Where>
{
    public const string Keyword = "where";

    public Where()
        : base(new EditableBuffer(Keyword))
    { }

    internal Where(IEditableBuffer buffer) 
        : base(buffer)
    { }

    public override NodeType NodeType => SwiftNodeTypes.Where;

    public string KeywordValue => Keyword;

    public static Where Create()
    {
        return new Where(new EditableBuffer(Keyword));
    }
}
