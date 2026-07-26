using System;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Reserved;

public class PreviouslyReservedLineKeywordToken : PreviouslyReservedKeywordToken
{
    public PreviouslyReservedLineKeywordToken()
        : base("#line", SwiftTokens.PreviouslyReservedLineId, SwiftTokens.PreviouslyReservedLineIndex)
    { }

    public override Version RemovalVersion => new(5, 9);
}