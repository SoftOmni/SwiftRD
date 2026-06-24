using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Macros;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Declarations;

public class MacroKeywordToken : DeclarationUsableKeywordToken<MacroKeyword>
{
    internal MacroKeywordToken()
        : base(MacroKeyword.Keyword, SwiftTokens.MacroId, SwiftTokens.MacroIndex)
    { }
}