using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.LeafNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.NodeTypes;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.Literals.ComposedLiterals.PlaygroundLiterals.Files;

public class ReservedFileLiteralKeyword : SwiftLeafNode<SwiftCompositeNode>, ISwiftKeywordNode<ReservedFileLiteralKeyword>
{
    public const string Keyword = "#fileLiteral";
    
    public ReservedFileLiteralKeyword()
        : base(new EditableBuffer(Keyword))
    { }
    
    internal ReservedFileLiteralKeyword(IEditableBuffer buffer)
        : base(buffer)
    { }

    public string KeywordValue => Keyword;

    public override NodeType NodeType => SwiftNodeTypes.ReservedFileLiteral;
}
