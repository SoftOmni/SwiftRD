using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Functions;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Declarations;

public class FuncKeywordToken : DeclarationUsableKeywordToken<Func>
{
    internal FuncKeywordToken()
        : base(Func.Keyword, SwiftTokens.FuncId, SwiftTokens.FuncIndex)
    { }
}
