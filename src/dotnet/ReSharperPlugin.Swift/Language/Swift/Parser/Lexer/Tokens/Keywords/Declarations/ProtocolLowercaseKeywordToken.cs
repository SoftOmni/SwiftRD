using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Protocols;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Declarations;

public class ProtocolLowercaseKeywordToken : DeclarationUsableKeywordToken<Protocol>
{
    internal ProtocolLowercaseKeywordToken()
        : base(Protocol.Keyword, SwiftTokens.ProtocolLowercaseId, SwiftTokens.ProtocolLowercaseIndex)
    { }
}
