using ReSharperPlugin.Swift.Language.Parser.Lexer.Tokens.Base;

namespace ReSharperPlugin.Swift.Language.Parser.Lexer.Tokens.Errors;

public class ErroneousToken(string tokenId, int errorIndex) : SwiftTokenNodeType(tokenId, errorIndex)
{
    public override string TokenRepresentation { get; } = tokenId;
}

public class BackingErroneousToken(string value, string message, int errorIndex) : BackerToken(value, errorIndex)
{
    public string Message { get; } = message;
}