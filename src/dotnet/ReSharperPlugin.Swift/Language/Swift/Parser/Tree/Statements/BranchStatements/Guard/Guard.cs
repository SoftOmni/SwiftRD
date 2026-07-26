using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.LeafNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.NodeTypes;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.BranchStatements.Guard;

public class Guard : SwiftLeafNode<SwiftCompositeNode>, ISwiftKeywordNode<Guard>
{
    public const string Keyword = "guard";
    
    public Guard()
        : base(new EditableBuffer(Keyword))
    { }
    
    internal Guard(IEditableBuffer buffer) 
        : base(buffer)
    { }

    public override NodeType NodeType => SwiftNodeTypes.Guard;

    public string KeywordValue => Keyword;

    public static Guard Create()
    {
        return new Guard(new EditableBuffer(Keyword));
    }
}
