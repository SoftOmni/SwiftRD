namespace ReSharperPlugin.Swift.Language.Parser.Lexer.Tokens.Operators.UserDefinedOperators;

public class PostfixOperatorToken(string @operator) : OperatorToken(@operator, SwiftTokens.PostfixOperatorIndex);