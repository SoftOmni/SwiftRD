namespace ReSharperPlugin.Swift.Language.Parser.Lexer.Tokens.Errors;

public class InvalidToken(char c) : ErroneousToken(SwiftTokens.InvalidTokenId, string.Empty, $"Invalid token '{c}'", SwiftTokens.ErroneousCharacterIndex);