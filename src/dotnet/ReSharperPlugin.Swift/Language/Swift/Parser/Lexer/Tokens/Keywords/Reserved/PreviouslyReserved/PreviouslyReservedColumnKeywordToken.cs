using System;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Reserved;

public class PreviouslyReservedColumnKeywordToken : PreviouslyReservedKeywordToken
{
    public PreviouslyReservedColumnKeywordToken()
        : base("#column", SwiftTokens.PreviouslyReservedColumnId, SwiftTokens.PreviouslyReservedColumnIndex)
    { }

    public override Version RemovalVersion => new(5, 9);
}