using SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Keywords;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Statements;

public abstract class StatementUsableKeywordToken(string value, string tokenId, int index) : SwiftKeywordToken(value, tokenId, index)
{
    public override bool StatementUsable => true;
}
