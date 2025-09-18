namespace ReSharperPlugin.Swift.Language.Parser.Lexer.Tokens.Literals;

public class StringLiteralEndToken : StringLiteralBoundaryToken
{
    public StringLiteralEndToken()
        : this(SwiftTokens.SurroundedStringLiteralEndId,  SwiftTokens.SurroundedStringLiteralEndIndex)
    { }
    
    public StringLiteralEndToken(string tokenId, int index)
        : base(tokenId, index)
    { }
}