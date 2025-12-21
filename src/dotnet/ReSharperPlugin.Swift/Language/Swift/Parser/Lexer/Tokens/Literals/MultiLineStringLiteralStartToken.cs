namespace ReSharperPlugin.Swift.Language.Parser.Lexer.Tokens.Literals;

public class MultiLineStringLiteralStartToken : StringLiteralBoundaryToken
{
    public MultiLineStringLiteralStartToken() : this(SwiftTokens.MultiLineStringLiteralStartId, SwiftTokens.MultiLineStringLiteralStartIndex)
    { }
    
    protected MultiLineStringLiteralStartToken(string tokenId, int index)
        : base(tokenId, index)
    { }
}