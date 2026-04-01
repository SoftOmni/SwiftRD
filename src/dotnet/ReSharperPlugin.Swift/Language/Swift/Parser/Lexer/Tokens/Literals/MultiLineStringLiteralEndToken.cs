namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Literals;

public class MultiLineStringLiteralEndToken : StringLiteralBoundaryToken
{
    public MultiLineStringLiteralEndToken()
    : this(SwiftTokens.MultiLineStringLiteralEndId,
        SwiftTokens.MultiLineStringLiteralEndIndex)
    { }
    
    protected MultiLineStringLiteralEndToken(string tokenId, int index)
        : base(tokenId, index)
    { }
}