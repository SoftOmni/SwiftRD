using ReSharperPlugin.Swift.Language.Parser.Lexer.Tokens.Keywords;

namespace ReSharperPlugin.Swift.Language.Parser.Lexer.Tokens.Patterns;

public abstract class PatternUsableKeywordToken(string value, int index) : SwiftKeywordToken(value, index)
{
    public override bool PatternUsable => true;
}
