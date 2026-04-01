using System;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Reserved;

public class PreviouslyReservedWarningKeywordToken()
    : PreviouslyReservedKeywordToken("#warning", SwiftTokens.PreviouslyReservedWarningId, SwiftTokens.PreviouslyReservedWarningIndex)
{
    public override Version RemovalVersion => new(5, 9);
}