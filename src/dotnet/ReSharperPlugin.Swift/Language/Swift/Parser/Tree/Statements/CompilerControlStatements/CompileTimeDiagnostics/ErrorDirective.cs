using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.LeafNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.NodeTypes;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.CompilerControlStatements.CompileTimeDiagnostics;

public class ErrorDirective : SwiftLeafNode<SwiftCompositeNode>, ISwiftKeywordNode<ErrorDirective>
{
    public const string Keyword = "#error";
    
    public ErrorDirective()
        : base(new EditableBuffer(Keyword))
    { }
    
    internal ErrorDirective(IEditableBuffer buffer)
        : base(buffer)
    { }

    public override NodeType NodeType => SwiftNodeTypes.PreviouslyReservedError;

    public string KeywordValue => Keyword;

    public static ErrorDirective Create()
    {
        return new ErrorDirective();
    }
}
