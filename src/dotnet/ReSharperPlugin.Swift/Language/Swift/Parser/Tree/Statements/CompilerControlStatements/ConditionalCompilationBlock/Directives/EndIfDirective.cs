using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.LeafNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.NodeTypes;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.CompilerControlStatements.ConditionalCompilationBlock.Directives;

public class EndIfDirective : SwiftLeafNode<SwiftCompositeNode>, ISwiftKeywordNode<EndIfDirective>
{
    public const string Keyword = "#endif";
    
    public EndIfDirective()
        : base(new EditableBuffer(Keyword))
    { }
    
    internal EndIfDirective(IEditableBuffer buffer)
        : base(buffer)
    { }

    public override NodeType NodeType => SwiftNodeTypes.EndIfDirectiveDirective;

    public string KeywordValue => Keyword;

    public static EndIfDirective Create()
    {
        return new EndIfDirective();
    }
}