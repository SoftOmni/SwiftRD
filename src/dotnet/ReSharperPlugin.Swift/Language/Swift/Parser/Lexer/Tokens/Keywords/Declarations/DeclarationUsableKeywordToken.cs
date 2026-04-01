using SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Keywords;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Declarations;

public abstract class DeclarationUsableKeywordToken(string value, string tokenId, int index) : SwiftKeywordToken(value, tokenId, index);