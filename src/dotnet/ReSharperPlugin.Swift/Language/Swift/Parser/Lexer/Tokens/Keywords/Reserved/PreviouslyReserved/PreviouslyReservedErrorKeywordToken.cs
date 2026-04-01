using System;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Reserved;

public class PreviouslyReservedErrorKeywordToken() : PreviouslyReservedKeywordToken("#error", SwiftTokens.PreviouslyReservedErrorId, SwiftTokens.PreviouslyReservedErrorIndex)
{
    public override Version RemovalVersion => new(5, 9);
}