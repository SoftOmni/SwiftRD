using System;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Reserved;

public class PreviouslyReservedDsoHandleKeywordToken : PreviouslyReservedKeywordToken
{
    public PreviouslyReservedDsoHandleKeywordToken()
        : base("#dsohandle", SwiftTokens.PreviouslyReservedDsoHandleId, SwiftTokens.PreviouslyReservedDsoHandleIndex)
    { }

    public override Version RemovalVersion => new(5, 9);
}