using ReSharperPlugin.Swift.Language.Parser.Lexer.Tokens.Base;

namespace ReSharperPlugin.Swift.Language.Parser.Lexer.Tokens.Operators.BuiltinOperators;


public class BuiltinOperatorToken(string value, int index) : SwiftTokenNodeType(value, index)
{
    public override string TokenRepresentation { get; } = value;
}
