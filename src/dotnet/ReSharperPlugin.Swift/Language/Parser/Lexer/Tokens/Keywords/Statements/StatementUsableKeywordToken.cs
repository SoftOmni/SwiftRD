using ReSharperPlugin.Swift.Language.Parser.Lexer.Tokens.Keywords;

namespace ReSharperPlugin.Swift.Language.Parser.Lexer.Tokens.Statements;

public abstract class StatementUsableKeywordToken(string value, int index) : SwiftKeywordToken(value, index)
{
    public override bool StatementUsable => true;
}
