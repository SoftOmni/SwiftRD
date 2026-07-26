using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.LeafNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.NodeTypes;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.CompilerControlStatements.AvailabilityConditions;

public class ReservedAvailableKeyword : SwiftLeafNode<SwiftCompositeNode>, ISwiftKeywordNode<ReservedAvailableKeyword>
{
    public const string Keyword = "#available";
    
    public ReservedAvailableKeyword()
        : base(new EditableBuffer(Keyword))
    { }
    
    internal ReservedAvailableKeyword(IEditableBuffer buffer)
        : base(buffer)
    { }

    public override NodeType NodeType => SwiftNodeTypes.ReservedAvailable;

    public string KeywordValue => Keyword;

    public static ReservedAvailableKeyword Create()
    {
        return new ReservedAvailableKeyword();
    }
}
