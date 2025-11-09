using ReSharperPlugin.Swift.Language.Parser.Tree.Declarations.Macros;

namespace ReSharperPlugin.Swift.Language.Parser.Lexer.Tokens.Declarations;

public class MacroKeywordToken : DeclarationUsableKeywordToken
{
    internal MacroKeywordToken()
        : base(MacroKeyword.Keyword, SwiftTokens.MacroId, SwiftTokens.MacroIndex)
    { }
}