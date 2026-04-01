using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Macros;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Declarations;

public class MacroKeywordToken : DeclarationUsableKeywordToken
{
    internal MacroKeywordToken()
        : base(MacroKeyword.Keyword, SwiftTokens.MacroId, SwiftTokens.MacroIndex)
    { }
}