using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.LeafNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.NodeTypes;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.CompilerControlStatements.ConditionalCompilationBlock.Directives;

public class IfDirective : SwiftLeafNode<SwiftCompositeNode>, ISwiftKeywordNode<IfDirective>
{
    public const string Keyword = "#if";
    
    public IfDirective()
        : base(new EditableBuffer(Keyword))
    { }
    
    internal IfDirective(IEditableBuffer buffer)
        : base(buffer)
    { }

    public override NodeType NodeType => SwiftNodeTypes.IfDirectiveDirective;

    public string KeywordValue => Keyword;

    public static IfDirective Create()
    {
        return new IfDirective();
    }
}
