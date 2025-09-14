using ReSharperPlugin.Swift.Language.Parser.Lexer.Tokens.Keywords;

namespace ReSharperPlugin.Swift.Language.Parser.Lexer.Tokens.Declarations;

public abstract class DeclarationUsableKeywordToken(string value, int index) : SwiftKeywordToken(value, index);