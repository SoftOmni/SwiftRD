using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.LeafNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.NodeTypes;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.CompilerControlStatements.AvailabilityConditions;

public class ReservedUnavailableKeyword : SwiftLeafNode<SwiftCompositeNode>, ISwiftKeywordNode<ReservedUnavailableKeyword>
{
    public const string Keyword = "#unavailable";
    
    public ReservedUnavailableKeyword()
        : base(new EditableBuffer(Keyword))
    { }
    
    internal ReservedUnavailableKeyword(IEditableBuffer buffer)
        : base(buffer)
    { }

    public override NodeType NodeType => SwiftNodeTypes.ReservedUnavailable;

    public string KeywordValue => Keyword;

    public static ReservedUnavailableKeyword Create()
    {
        return new ReservedUnavailableKeyword();
    }
}