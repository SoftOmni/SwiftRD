using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.LeafNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.NodeTypes;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.DoStatements;

public class Do : SwiftLeafNode<SwiftCompositeNode>, ISwiftKeywordNode<Do>
{
    public const string Keyword = "do";
    
    public Do()
        : base(new EditableBuffer(Keyword))
    { }

    internal Do(IEditableBuffer buffer) 
        : base(buffer)
    { }

    public override NodeType NodeType => SwiftNodeTypes.Do;

    public string KeywordValue => Keyword;

    public static Do Create()
    {
        return new Do(new EditableBuffer(Keyword));
    }
}
