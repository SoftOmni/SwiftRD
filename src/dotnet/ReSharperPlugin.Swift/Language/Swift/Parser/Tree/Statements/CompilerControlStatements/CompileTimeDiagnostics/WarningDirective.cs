using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.LeafNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.NodeTypes;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.CompilerControlStatements.CompileTimeDiagnostics;

public class WarningDirective : SwiftLeafNode<SwiftCompositeNode>, ISwiftKeywordNode<WarningDirective>
{
    public const string Keyword = "#warning";
    
    public WarningDirective()
        : base(new EditableBuffer(Keyword))
    { }
    
    internal WarningDirective(IEditableBuffer buffer)
        : base(buffer)
    { }

    public override NodeType NodeType => SwiftNodeTypes.PreviouslyReservedWarning;

    public string KeywordValue => Keyword;

    public static WarningDirective Create()
    {
        return new WarningDirective();
    }
}
