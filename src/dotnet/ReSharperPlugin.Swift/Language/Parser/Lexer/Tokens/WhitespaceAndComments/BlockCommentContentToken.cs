using ReSharperPlugin.Swift.Language.Parser.Lexer.Tokens.Base;

namespace ReSharperPlugin.Swift.Language.Parser.Lexer.Tokens.WhitespaceAndComments;

public class BlockCommentContentToken(string value) : SwiftTokenNodeType(SwiftTokens.BlockCommentStartId, SwiftTokens.BlockCommentContentIndex)
{
    public override string TokenRepresentation { get; } = value;
    
    public override bool IsComment => true;
}