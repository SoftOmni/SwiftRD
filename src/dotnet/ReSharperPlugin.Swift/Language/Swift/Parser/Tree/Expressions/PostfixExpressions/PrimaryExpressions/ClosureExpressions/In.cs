using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.LeafNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.NodeTypes;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.ClosureExpressions;

public class In : SwiftLeafNode<SwiftCompositeNode>, ISwiftKeywordNode<In>
{
    public const string Keyword = "in";
    
    public In()
        : base(new EditableBuffer(Keyword))
    { }

    internal In(IEditableBuffer buffer) 
        : base(buffer)
    { }

    public string KeywordValue => Keyword;

    public override NodeType NodeType => SwiftNodeTypes.In;

    public static In Create()
    {
        return new In(new EditableBuffer(Keyword));
    }
}
