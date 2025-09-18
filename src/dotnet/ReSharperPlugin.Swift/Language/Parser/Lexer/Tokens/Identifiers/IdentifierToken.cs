using ReSharperPlugin.Swift.Language.Parser.Lexer.Tokens;
using ReSharperPlugin.Swift.Language.Parser.Lexer.Tokens.Base;

namespace DefaultNamespace;

public class IdentifierToken() : SwiftTokenNodeType(SwiftTokens.IdentifierId, SwiftTokens.IdentifierIndex)
{
    public override string TokenRepresentation { get; } = SwiftTokens.IdentifierId;

    public override bool IsIdentifier => true;
}