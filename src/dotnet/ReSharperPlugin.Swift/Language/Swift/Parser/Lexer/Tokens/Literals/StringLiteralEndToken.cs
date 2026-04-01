namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Literals;

public class StringLiteralEndToken : StringLiteralBoundaryToken
{
    public StringLiteralEndToken()
        : this(SwiftTokens.SurroundedStringLiteralEndId,  SwiftTokens.StringLiteralEndIndex)
    { }
    
    public StringLiteralEndToken(string tokenId, int index)
        : base(tokenId, index)
    { }
}