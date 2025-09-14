using ReSharperPlugin.Swift.Language.Parser.Lexer.Tokens.Base;

namespace ReSharperPlugin.Swift.Language.Parser.Lexer.Tokens.Punctuators;

public class PunctuatorToken(string punctuator, int index) : SwiftTokenNodeType(punctuator, index)
{
    public override string TokenRepresentation { get; } = punctuator;
}