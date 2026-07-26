using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.LeafNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.NodeTypes;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.BranchStatements.Ifs;

public class If : SwiftLeafNode<SwiftCompositeNode>, ISwiftKeywordNode<If>
{
    public const string Keyword = "if";
    
    public If()
        : base(new EditableBuffer(Keyword))
    { }

    internal If(IEditableBuffer buffer)
        : base(buffer)
    { }

    public override NodeType NodeType => SwiftNodeTypes.If;

    public string KeywordValue => Keyword;

    public static If Create()
    {
        return new If(new EditableBuffer(Keyword));
    }
}