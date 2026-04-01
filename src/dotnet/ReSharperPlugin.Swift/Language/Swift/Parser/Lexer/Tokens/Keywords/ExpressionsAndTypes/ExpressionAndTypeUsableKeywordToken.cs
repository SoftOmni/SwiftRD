using SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Keywords;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.ExpressionsAndTypes;

public abstract class ExpressionAndTypeUsableKeywordToken(string value, string tokenId, int index) : SwiftKeywordToken(value, tokenId, index)
{
    public override bool ExpressionAndTypeUsable => true;
}
