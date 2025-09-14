using ReSharperPlugin.Swift.Language.Parser.Lexer.Tokens.Base;

namespace ReSharperPlugin.Swift.Language.Parser.Lexer.Tokens.Operators.UserDefinedOperators;

public class OperatorToken(string @operator, int index) : SwiftTokenNodeType(@operator, index)
{
    public override string TokenRepresentation { get; } = @operator;
}
