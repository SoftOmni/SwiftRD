using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.LeafNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.NodeTypes;
using SoftOmni.SwiftRd.Technology;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.Wildcards;

public class Wildcard : SwiftLeafNode<SwiftCompositeNode>, ISwiftKeywordNode<Wildcard>
{
    public const string Keyword = "_";
    
    public Wildcard()
        : base(new EditableBuffer(Keyword))
    { }

    internal Wildcard(IEditableBuffer buffer)
        : base(buffer)
    { }

    public override NodeType NodeType => SwiftNodeTypes.Underscore;

    public string KeywordValue => Keyword;

    public static Wildcard Create()
    {
        return new Wildcard(new EditableBuffer(Keyword));
    }

    public static IWildcardExpression CreateWithExpression()
    {
        IEditableBuffer wildcardExpressionBuffer = new EditableBuffer(Keyword);
        IEditableBuffer wildcardLeafTokenBuffer = new SubEditableBuffer(wildcardExpressionBuffer, 0, Keyword.Length);

        Wildcard wildcard = new(wildcardLeafTokenBuffer);
        return new WildcardExpression(wildcardExpressionBuffer, [wildcard], wildcard);
    }
}
