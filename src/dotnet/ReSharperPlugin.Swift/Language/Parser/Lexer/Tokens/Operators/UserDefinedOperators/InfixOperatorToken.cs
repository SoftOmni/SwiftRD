namespace ReSharperPlugin.Swift.Language.Parser.Lexer.Tokens.Operators.UserDefinedOperators;


public class InfixOperatorToken(string @operator) : OperatorToken(@operator, SwiftTokens.InfixOperatorIndex);