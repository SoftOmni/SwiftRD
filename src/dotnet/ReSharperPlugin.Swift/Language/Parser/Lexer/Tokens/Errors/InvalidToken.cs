namespace ReSharperPlugin.Swift.Language.Parser.Lexer.Tokens.Errors;

public class InvalidToken() : ErroneousToken(SwiftTokens.InvalidTokenId, SwiftTokens.InvalidTokenIndex);

public class BackerInvalidToken(char c) : BackingErroneousToken(c.ToString(), $"Invalid token '{c}'", SwiftTokens.InvalidTokenIndex);