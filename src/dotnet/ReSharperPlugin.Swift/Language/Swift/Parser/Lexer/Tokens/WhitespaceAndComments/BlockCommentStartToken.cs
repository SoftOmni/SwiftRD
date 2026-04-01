using SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Base;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.WhitespaceAndComments;

public class BlockCommentStartToken() : SwiftTokenNodeType(SwiftTokens.BlockCommentStartId, SwiftTokens.BlockCommentStartIndex)
{
    public override string TokenRepresentation => Representation;

    public override bool IsComment => true;

    private const string Representation = "/*";
}