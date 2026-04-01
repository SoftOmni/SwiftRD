using SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Base;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Literals;

public class StringEscapeSequenceToken()
    : SwiftTokenNodeType(SwiftTokens.StringEscapeSequenceId, SwiftTokens.StringEscapeSequenceIndex)
{
    public override string TokenRepresentation => SwiftTokens.StringEscapeSequenceId;
}