using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Keywords;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.ExpressionsAndTypes;

public abstract class ExpressionAndTypeUsableKeywordToken<AstLeafNode>(string value, string tokenId, int index) :
    SwiftKeywordToken<AstLeafNode>(value, tokenId, index)
    where AstLeafNode : LeafElementBase, ISwiftKeywordNode<AstLeafNode>, new()
{
    public override bool ExpressionAndTypeUsable => true;
}