using ReSharperPlugin.Swift.Language.Parser.Lexer.Tokens.Keywords;

namespace ReSharperPlugin.Swift.Language.Parser.Lexer.Tokens.Reserved;

public abstract class ReservedKeywordToken(string value, string tokenId, int index) : SwiftKeywordToken(value, tokenId, index);
