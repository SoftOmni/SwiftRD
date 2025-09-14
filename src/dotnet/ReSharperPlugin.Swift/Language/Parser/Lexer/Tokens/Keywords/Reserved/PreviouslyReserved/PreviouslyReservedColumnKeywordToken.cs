using System;

namespace ReSharperPlugin.Swift.Language.Parser.Lexer.Tokens.Reserved;

public class PreviouslyReservedColumnKeywordToken() : PreviouslyReservedKeywordToken("#column", SwiftTokens.PreviouslyReservedColumnIndex)
{
    public override Version RemovalVersion => new(5, 9);
}