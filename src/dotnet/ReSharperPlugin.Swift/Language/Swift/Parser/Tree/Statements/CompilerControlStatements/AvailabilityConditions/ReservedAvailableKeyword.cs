using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.LeafNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.NodeTypes;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.CompilerControlStatements.AvailabilityConditions;

public class AvailableKeyword : SwiftLeafNode<SwiftCompositeNode>, ISwiftKeywordNode<AvailableKeyword>
{
    public const string Keyword = "#available";
    
    public AvailableKeyword()
        : base(new EditableBuffer(Keyword))
    { }
    
    internal AvailableKeyword(IEditableBuffer buffer)
        : base(buffer)
    { }

    public override NodeType NodeType => SwiftNodeTypes.ReservedAvailable;

    public string KeywordValue => Keyword;

    public static AvailableKeyword Create()
    {
        return new AvailableKeyword();
    }
}
