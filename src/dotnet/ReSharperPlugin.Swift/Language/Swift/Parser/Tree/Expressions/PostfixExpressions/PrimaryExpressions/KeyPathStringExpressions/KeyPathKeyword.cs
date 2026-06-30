using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.LeafNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.NodeTypes;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.KeyPathStringExpressions;

public class KeyPathKeyword : SwiftLeafNode<SwiftCompositeNode>, ISwiftKeywordNode<KeyPathKeyword>
{
    public const string Keyword = "#keyPath";
    
    public KeyPathKeyword()
        : base(new EditableBuffer(Keyword))
    { }

    internal KeyPathKeyword(IEditableBuffer buffer) 
        : base(buffer)
    { }

    public override NodeType NodeType => SwiftNodeTypes.ReservedKeyPath;

    public string KeywordValue => Keyword;

    public static KeyPathKeyword Create()
    {
        return new KeyPathKeyword(new EditableBuffer(Keyword));
    }
}
