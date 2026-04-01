using SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Keywords;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.ContextSensitive;

public abstract class ContextSensitiveKeywordToken(string value, string tokenId, int index) : SwiftKeywordToken(value, tokenId, index)
{
    public override bool ContentSensitive => true;
}
