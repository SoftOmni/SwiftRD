using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.LeafNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.NodeTypes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.LoopStatements.RepeatWhileStatements;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.LoopStatements.WhileLoops;

public class While : SwiftLeafNode<SwiftCompositeNode>, ISwiftKeywordNode
{
    public const string Keyword = "while";
    
    public WhileStatement? WhileStatement { get; internal set; }
    
    public RepeatWhileStatement? RepeatWhileStatement { get; internal set; }

    internal While(IEditableBuffer buffer) 
        : base(buffer)
    { }

    internal While(SwiftCompositeNode parent, int parentIndex, int parentTextIndex, IEditableBuffer buffer)
        : base(buffer, parent, parentIndex, parentTextIndex)
    {
        if (parent is WhileStatement whileStatement)
        {
            WhileStatement = whileStatement;
        }
        else if (parent is RepeatWhileStatement repeatWhileStatement)
        {
            RepeatWhileStatement = repeatWhileStatement;
        }
    }

    public override NodeType NodeType => SwiftNodeTypes.While;

    public string KeywordValue => Keyword;

    public static While Create()
    {
        return new While(new EditableBuffer(Keyword));
    }
}