using ReSharperPlugin.Swift.Language.Parser.Lexer.Tokens.Base;

namespace ReSharperPlugin.Swift.Language.Parser.Lexer.Tokens.WhitespaceAndComments;

public class BlockCommentEndToken() : SwiftTokenNodeType(SwiftTokens.BlockCommentEndId, SwiftTokens.BlockCommentEndIndex)
{
    public override string TokenRepresentation => Representation;

    public override bool IsComment => true;

    private const string Representation = "*/";
}