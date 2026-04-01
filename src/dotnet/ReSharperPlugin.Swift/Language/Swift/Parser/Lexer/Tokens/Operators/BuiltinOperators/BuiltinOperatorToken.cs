using SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Base;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Operators.BuiltinOperators;


public class BuiltinOperatorToken(string tokenId, int index) : SwiftTokenNodeType(tokenId, index)
{
    public override string TokenRepresentation { get; } = tokenId;
}
