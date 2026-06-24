namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Reserved;

public class ReservedSelectorKeywordToken : ReservedKeywordToken
{
    public ReservedSelectorKeywordToken()
        : base("#selector", SwiftTokens.ReservedSelectorId, SwiftTokens.ReservedSelectorIndex)
    { }
}