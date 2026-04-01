using SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Base;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Operators.UserDefinedOperators;

public class OperatorToken(string tokenId, int index) : SwiftTokenNodeType(tokenId, index)
{
    public override string TokenRepresentation { get; } = tokenId;
}
