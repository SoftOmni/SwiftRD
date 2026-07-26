using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.LeafNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.NodeTypes;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.CompilerControlStatements.ConditionalCompilationBlock.Directives;

public class ElseIfDirective : SwiftLeafNode<SwiftCompositeNode>, ISwiftKeywordNode<ElseIfDirective>
{
    public const string Keyword = "#elseif";
    
    public ElseIfDirective()
        : base(new EditableBuffer(Keyword))
    { }
    
    internal ElseIfDirective(IEditableBuffer buffer)
        : base(buffer)
    { }

    public override NodeType NodeType => SwiftNodeTypes.ElseIfDirectiveDirective;

    public string KeywordValue => Keyword;

    public static ElseIfDirective Create()
    {
        return new ElseIfDirective();
    }
}