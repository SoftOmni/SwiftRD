using ReSharperPlugin.Swift.Language.Parser.Lexer.Tokens.Base;

namespace ReSharperPlugin.Swift.Language.Parser.Lexer.Tokens.WhitespaceAndComments;

public class BlockCommentContentToken() : SwiftTokenNodeType(SwiftTokens.BlockCommentStartId, SwiftTokens.BlockCommentContentIndex)
{
    public override string TokenRepresentation { get; } = SwiftTokens.BlockCommentContentId;
    
    public override bool IsComment => true;
}

public class BlockCommentBackingToken(string value) : BackerToken(value, SwiftTokens.BlockCommentContentIndex);