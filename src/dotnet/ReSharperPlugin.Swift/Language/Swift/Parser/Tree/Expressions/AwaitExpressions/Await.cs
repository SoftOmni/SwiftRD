using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.LeafNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.NodeTypes;
using SoftOmni.SwiftRd.Technology;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions;

public class Await : SwiftLeafNode<SwiftCompositeNode>, ISwiftKeywordNode<Await>
{
    public const string Keyword = "await";
    
    public IReadOnlyAwaitExpression? Expression { get; internal set; }
    
    public Await()
        : base(new EditableBuffer(Keyword))
    { }

    internal Await(IEditableBuffer buffer) 
        : base(buffer)
    { }

    public override NodeType NodeType => SwiftNodeTypes.Await;

    public string KeywordValue => Keyword;

    public static Await Create()
    {
        return new Await(new EditableBuffer(Keyword));
    }

    public static IAwaitExpression CreateWithExpression()
    {
        IEditableBuffer awaitExpressionBuffer = new EditableBuffer(Keyword);
        IEditableBuffer awaitKeywordBuffer = new SubEditableBuffer(awaitExpressionBuffer, 0, Keyword.Length);
        Await await = new(awaitKeywordBuffer);

        return new AwaitExpression(awaitKeywordBuffer, [await], await);
    }
}
