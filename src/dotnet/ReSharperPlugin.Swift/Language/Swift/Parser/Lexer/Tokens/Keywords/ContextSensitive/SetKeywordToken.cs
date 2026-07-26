using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Variables.GetterSetterBlocks;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.ContextSensitive;

public class SetKeywordToken : ContextSensitiveKeywordToken<Set>
{
    internal SetKeywordToken()
        : base(Set.Keyword, SwiftTokens.SetId, SwiftTokens.SetIndex)
    { }
}
