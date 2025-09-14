using ReSharperPlugin.Swift.Language.Parser.Lexer.Tokens;
using ReSharperPlugin.Swift.Language.Parser.Lexer.Tokens.Base;

namespace DefaultNamespace;

public class IdentifierToken(string identifier) : SwiftTokenNodeType(identifier, SwiftTokens.IdentifierIndex)
{
    public override string TokenRepresentation { get; } = identifier;

    public override bool IsIdentifier => true;
}