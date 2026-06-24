using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Variables;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Declarations;

public class VarKeywordToken : DeclarationUsableKeywordToken<Var>
{
    internal VarKeywordToken()
        : base(Var.Keyword, SwiftTokens.VarId, SwiftTokens.VarIndex)
    { }
}
