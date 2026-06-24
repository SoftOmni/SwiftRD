using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.MetaTypes;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.ContextSensitive;

public class ProtocolUppercaseKeywordToken : ContextSensitiveKeywordToken<ProtocolUppercase>
{
    internal ProtocolUppercaseKeywordToken()
        : base(ProtocolUppercase.Keyword, SwiftTokens.ProtocolUppercaseId, SwiftTokens.ProtocolUppercaseIndex)
    { }
}