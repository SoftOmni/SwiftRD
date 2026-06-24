using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Protocols;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Declarations;

public class ProtocolLowercaseKeywordToken : DeclarationUsableKeywordToken<ProtocolLowercase>
{
    internal ProtocolLowercaseKeywordToken()
        : base(ProtocolLowercase.Keyword, SwiftTokens.ProtocolLowercaseId, SwiftTokens.ProtocolLowercaseIndex)
    { }
}