using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Indirecterations;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.ContextSensitive;

public class IndirectKeywordToken : ContextSensitiveKeywordToken<Indirect>
{
    internal IndirectKeywordToken()
        : base(Indirect.Keyword, SwiftTokens.IndirectId, SwiftTokens.IndirectIndex)
    { }
}