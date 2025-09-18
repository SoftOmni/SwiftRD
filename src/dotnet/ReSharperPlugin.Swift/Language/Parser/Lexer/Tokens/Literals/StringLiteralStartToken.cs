namespace ReSharperPlugin.Swift.Language.Parser.Lexer.Tokens.Literals;

public class StringLiteralStartToken : StringLiteralBoundaryToken
{
    public StringLiteralStartToken() : this(SwiftTokens.SurroundedStringLiteralStartId, SwiftTokens.StringLiteralStartIndex)
    { }
    
    protected StringLiteralStartToken(string tokenId, int index)
        : base(tokenId, index)
    { }
}