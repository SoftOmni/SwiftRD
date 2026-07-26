using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.LeafNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.NodeTypes;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.LoopStatements.WhileLoops;

public class While : SwiftLeafNode<SwiftCompositeNode>, ISwiftKeywordNode<While>
{
    public const string Keyword = "while";
    
    public While()
        : base(new EditableBuffer(Keyword))
    { }

    internal While(IEditableBuffer buffer) 
        : base(buffer)
    { }

    public override NodeType NodeType => SwiftNodeTypes.While;

    public string KeywordValue => Keyword;

    public static While Create()
    {
        return new While(new EditableBuffer(Keyword));
    }
}