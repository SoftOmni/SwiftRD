using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.LeafNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.NodeTypes;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.Literals.ComposedLiterals.PlaygroundLiterals.Colors;

public class ReservedColorLiteralKeyword : SwiftLeafNode<SwiftCompositeNode>, ISwiftKeywordNode<ReservedColorLiteralKeyword>
{
    public const string Keyword = "#colorLiteral";
    
    public ReservedColorLiteralKeyword()
        : base(new EditableBuffer(Keyword))
    { }
    
    internal ReservedColorLiteralKeyword(IEditableBuffer buffer)
        : base(buffer)
    { }

    public string KeywordValue => Keyword;

    public override NodeType NodeType => SwiftNodeTypes.ReservedColorLiteral;
}
