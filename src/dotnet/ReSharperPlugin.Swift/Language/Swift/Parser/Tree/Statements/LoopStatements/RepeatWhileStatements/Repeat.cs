using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.LeafNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.NodeTypes;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.LoopStatements.RepeatWhileStatements;

public class Repeat : SwiftLeafNode<SwiftCompositeNode>, ISwiftKeywordNode<Repeat>
{
    public const string Keyword = "repeat";
    
    public RepeatWhileStatement? RepeatWhileStatement { get; internal set; }

    public Repeat()
        : base(new EditableBuffer(Keyword))
    { }
    
    internal Repeat(IEditableBuffer buffer) 
        : base(buffer)
    { }

    public override NodeType NodeType => SwiftNodeTypes.Repeat;

    public string KeywordValue => Keyword;

    public static Repeat Create()
    {
        return new Repeat(new EditableBuffer(Keyword));
    }
}
