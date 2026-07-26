using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.LeafNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.NodeTypes;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.CompilerControlStatements.ConditionalCompilationBlock.Directives;

public class ElseDirective : SwiftLeafNode<SwiftCompositeNode>, ISwiftKeywordNode<ElseDirective>
{
    public const string Keyword = "#else";
    
    public ElseDirective()
        : base(new EditableBuffer(Keyword))
    { }
    
    internal ElseDirective(IEditableBuffer buffer)
        : base(buffer)
    { }

    public override NodeType NodeType => SwiftNodeTypes.ElseDirectiveDirective;

    public string KeywordValue => Keyword;

    public static ElseDirective Create()
    {
        return new ElseDirective();
    }
}