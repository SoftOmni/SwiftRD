using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.LeafNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.NodeTypes;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.ISelfExpressions;

public class SelfLowercase : SwiftLeafNode<SwiftCompositeNode>, ISwiftKeywordNode<SelfLowercase>
{
    public const string Keyword = "self";

    public SelfLowercase()
        : base(new EditableBuffer(Keyword))
    { }
    
    internal SelfLowercase(IEditableBuffer buffer)
        : base(buffer)
    { }

    public override NodeType NodeType => SwiftNodeTypes.SelfLowercase;

    public string KeywordValue => Keyword;

    public static SelfLowercase Create()
    {
        return new SelfLowercase(new EditableBuffer(Keyword));
    }
}
