using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.LeafNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.NodeTypes;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.BranchStatements.Ifs;

public class Else : SwiftLeafNode<SwiftCompositeNode>, ISwiftKeywordNode<Else>
{
    public const string Keyword = "else";

    public Else()
        : base(new EditableBuffer(Keyword))
    { }

    internal Else(IEditableBuffer buffer)
        : base(buffer)
    { }

    public override NodeType NodeType => SwiftNodeTypes.Else;

    public string KeywordValue => Keyword;

    public static Else Create()
    {
        return new Else(new EditableBuffer(Keyword));
    }
}
