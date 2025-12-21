using ReSharperPlugin.Swift.Language.Parser.Lexer.Tokens.Base;

namespace ReSharperPlugin.Swift.Language.Parser.Lexer.Tokens.Literals;

public class StringEscapeSequenceToken()
    : SwiftTokenNodeType(SwiftTokens.StringEscapeSequenceId, SwiftTokens.StringEscapeSequenceIndex)
{
    public override string TokenRepresentation => SwiftTokens.StringEscapeSequenceId;
}