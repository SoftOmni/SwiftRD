using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.LeafNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.NodeTypes;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.ISuperClassExpressions;

public class Super : SwiftLeafNode<SwiftCompositeNode>, ISwiftKeywordNode<Super>
{
    public const string Keyword = "super";

    public Super()
        : base(new EditableBuffer(Keyword))
    { }
    
    internal Super(IEditableBuffer buffer)
        : base(buffer)
    { }

    public override NodeType NodeType => SwiftNodeTypes.SelfLowercase;

    public string KeywordValue => Keyword;

    public static Super Create()
    {
        return new Super(new EditableBuffer(Keyword));
    }
}
