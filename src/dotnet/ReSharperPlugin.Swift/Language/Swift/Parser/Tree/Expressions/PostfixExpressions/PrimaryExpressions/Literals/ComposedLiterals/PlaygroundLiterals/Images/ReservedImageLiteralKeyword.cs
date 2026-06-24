using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.LeafNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.NodeTypes;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.Literals.ComposedLiterals.PlaygroundLiterals.Images;

public class ReservedImageLiteralKeyword : SwiftLeafNode<SwiftCompositeNode>, ISwiftKeywordNode<ReservedImageLiteralKeyword>
{
    public const string Keyword = "#imageLiteral";
    
    public ReservedImageLiteralKeyword()
        : base(new EditableBuffer(Keyword))
    { }
    
    internal ReservedImageLiteralKeyword(IEditableBuffer buffer)
        : base(buffer)
    { }

    public string KeywordValue => Keyword;

    public override NodeType NodeType => SwiftNodeTypes.ReservedFileLiteral;
}
