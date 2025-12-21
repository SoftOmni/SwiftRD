using ReSharperPlugin.Swift.Language.Parser.Lexer.Tokens.Keywords;

namespace ReSharperPlugin.Swift.Language.Parser.Lexer.Tokens.Patterns;

public abstract class PatternUsableKeywordToken(string value, string tokenId, int index) : SwiftKeywordToken(value, tokenId, index)
{
    public override bool PatternUsable => true;
}
