using ReSharperPlugin.Swift.Language.Parser.Lexer.Tokens.Keywords;

namespace ReSharperPlugin.Swift.Language.Parser.Lexer.Tokens.Reserved;

public abstract class ReservedKeywordToken(string value, int index) : SwiftKeywordToken(value, index);
