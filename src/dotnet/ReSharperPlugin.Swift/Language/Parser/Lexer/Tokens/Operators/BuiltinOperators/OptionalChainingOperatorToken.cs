using ReSharperPlugin.Swift.Language.Parser.Lexer.Tokens.Operators.UserDefinedOperators;

namespace ReSharperPlugin.Swift.Language.Parser.Lexer.Tokens.Operators.BuiltinOperators;

public class OptionalChainingOperatorToken(string op) : OperatorToken(op, SwiftTokens.OptionalChainingOperatorIndex);