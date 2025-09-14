using System;

namespace ReSharperPlugin.Swift.Language.Parser.Lexer.Tokens.Reserved;

public class PreviouslyReservedFunctionKeywordToken()
    : PreviouslyReservedKeywordToken("#function", SwiftTokens.PreviouslyReservedFunctionIndex)
{
    public override Version RemovalVersion => new(5, 9);
}