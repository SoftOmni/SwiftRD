using SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Keywords;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Patterns;

public abstract class PatternUsableKeywordToken(string value, string tokenId, int index) : SwiftKeywordToken(value, tokenId, index)
{
    public override bool PatternUsable => true;
}
