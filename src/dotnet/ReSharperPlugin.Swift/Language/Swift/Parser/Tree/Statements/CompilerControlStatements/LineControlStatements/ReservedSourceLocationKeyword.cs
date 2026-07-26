using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.LeafNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.NodeTypes;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.CompilerControlStatements.LineControlStatements;

public class ReservedSourceLocationKeyword : SwiftLeafNode<SwiftCompositeNode>, ISwiftKeywordNode<ReservedSourceLocationKeyword>
{
    public const string Keyword = "#sourceLocation";
    
    public ReservedSourceLocationKeyword()
        : base(new EditableBuffer(Keyword))
    { }
    
    internal ReservedSourceLocationKeyword(IEditableBuffer buffer)
        : base(buffer)
    { }

    public override NodeType NodeType => SwiftNodeTypes.ReservedSourceLocation;

    public string KeywordValue => Keyword;

    public static ReservedSourceLocationKeyword Create()
    {
        return new ReservedSourceLocationKeyword();
    }
}
