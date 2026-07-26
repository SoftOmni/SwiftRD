using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.LeafNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.NodeTypes;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.CompilerControlStatements.AvailabilityConditions;

public class UnavailableKeyword : SwiftLeafNode<SwiftCompositeNode>, ISwiftKeywordNode<UnavailableKeyword>
{
    public const string Keyword = "#unavailable";
    
    public UnavailableKeyword()
        : base(new EditableBuffer(Keyword))
    { }
    
    internal UnavailableKeyword(IEditableBuffer buffer)
        : base(buffer)
    { }

    public override NodeType NodeType => SwiftNodeTypes.ReservedUnavailable;

    public string KeywordValue => Keyword;

    public static UnavailableKeyword Create()
    {
        return new UnavailableKeyword();
    }
}