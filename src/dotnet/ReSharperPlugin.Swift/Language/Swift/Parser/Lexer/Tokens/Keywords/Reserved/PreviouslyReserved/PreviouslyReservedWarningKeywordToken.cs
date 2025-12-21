using System;

namespace ReSharperPlugin.Swift.Language.Parser.Lexer.Tokens.Reserved;

public class PreviouslyReservedWarningKeywordToken()
    : PreviouslyReservedKeywordToken("#warning", SwiftTokens.PreviouslyReservedWarningId, SwiftTokens.PreviouslyReservedWarningIndex)
{
    public override Version RemovalVersion => new(5, 9);
}