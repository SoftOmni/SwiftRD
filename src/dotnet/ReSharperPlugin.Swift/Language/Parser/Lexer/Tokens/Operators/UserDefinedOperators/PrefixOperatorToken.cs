namespace ReSharperPlugin.Swift.Language.Parser.Lexer.Tokens.Operators.UserDefinedOperators;

public class PrefixOperatorToken(string @operator) : OperatorToken(@operator, SwiftTokens.PrefixOperatorIndex);