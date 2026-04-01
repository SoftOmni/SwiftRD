using SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Base;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Markers;

public abstract class MarkerToken(string tokenId, int index) : SwiftTokenNodeType(string.Empty, index)
{
    public override string TokenRepresentation => string.Empty;
}