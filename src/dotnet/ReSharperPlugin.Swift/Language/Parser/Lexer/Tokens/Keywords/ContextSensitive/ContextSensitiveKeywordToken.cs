using ReSharperPlugin.Swift.Language.Parser.Lexer.Tokens.Keywords;

namespace ReSharperPlugin.Swift.Language.Parser.Lexer.Tokens.ContextSensitive;

public abstract class ContextSensitiveKeywordToken(string value, int index) : SwiftKeywordToken(value, index)
{
    public override bool ContentSensitive => true;
}
