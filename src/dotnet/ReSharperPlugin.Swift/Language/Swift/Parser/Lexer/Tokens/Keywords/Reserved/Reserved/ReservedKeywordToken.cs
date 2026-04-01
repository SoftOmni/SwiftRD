using SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Keywords;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Reserved;

public abstract class ReservedKeywordToken(string value, string tokenId, int index) : SwiftKeywordToken(value, tokenId, index);
