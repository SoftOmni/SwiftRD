using System;

namespace ReSharperPlugin.Swift.Language.Parser.Lexer.Tokens.Reserved;

public class PreviouslyReservedFilePathKeywordToken()
    : PreviouslyReservedKeywordToken("#file", SwiftTokens.PreviouslyReservedFilePathId, SwiftTokens.PreviouslyReservedFilePathIndex)
{
    public override Version RemovalVersion => new(5, 9);
}