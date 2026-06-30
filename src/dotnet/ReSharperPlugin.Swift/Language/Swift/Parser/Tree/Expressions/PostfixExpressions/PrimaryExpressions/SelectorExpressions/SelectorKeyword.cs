using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.LeafNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.NodeTypes;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.SelectorExpressions;

public class SelectorKeyword : SwiftLeafNode<SwiftCompositeNode>, ISwiftKeywordNode<SelectorKeyword>
{
    public const string Keyword = "#selector";
    
    public SelectorKeyword()
        : this(new EditableBuffer(Keyword))
    { }

    internal SelectorKeyword(IEditableBuffer buffer)
        : base(buffer)
    { }

    public override NodeType NodeType => SwiftNodeTypes.ReservedSelector;

    public string KeywordValue => Keyword;

    public static SelectorKeyword Create()
    {
        return new SelectorKeyword(new EditableBuffer(Keyword));
    }
}
