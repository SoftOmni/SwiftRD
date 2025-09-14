using System;
using ReSharperPlugin.Swift.Language.Parser.Lexer.Tokens.Keywords;

namespace ReSharperPlugin.Swift.Language.Parser.Lexer.Tokens.Reserved;

public abstract class PreviouslyReservedKeywordToken(string value, int index) : SwiftKeywordToken(value, index)
{
    public abstract override Version RemovalVersion { get; }
}
