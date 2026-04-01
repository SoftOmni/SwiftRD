using SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Base;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Identifiers;

public class IdentifierToken() : SwiftTokenNodeType(SwiftTokens.IdentifierId, SwiftTokens.IdentifierIndex)
{
    public override string TokenRepresentation { get; } = SwiftTokens.IdentifierId;

    public override bool IsIdentifier => true;
}