using ReSharperPlugin.Swift.Language.Parser.Lexer.Tokens.Base;

namespace ReSharperPlugin.Swift.Language.Parser.Lexer.Tokens.Markers;

public abstract class MarkerToken(int index) : SwiftTokenNodeType(string.Empty, index)
{
    public override string TokenRepresentation => string.Empty;
}