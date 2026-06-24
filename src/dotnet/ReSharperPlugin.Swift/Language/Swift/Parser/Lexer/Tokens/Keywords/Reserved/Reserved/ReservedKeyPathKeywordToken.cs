namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Reserved;

public class ReservedKeyPathKeywordToken : ReservedKeywordToken
{
    public ReservedKeyPathKeywordToken()
        : base("#keyPath", SwiftTokens.ReservedKeyPathId, SwiftTokens.ReservedKeyPathIndex)
    { }
}