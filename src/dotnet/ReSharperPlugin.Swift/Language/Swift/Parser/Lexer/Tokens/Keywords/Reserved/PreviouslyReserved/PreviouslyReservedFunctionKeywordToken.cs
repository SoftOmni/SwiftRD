using System;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Reserved;

public class PreviouslyReservedFunctionKeywordToken : PreviouslyReservedKeywordToken
{
    public PreviouslyReservedFunctionKeywordToken()
        : base("#function", SwiftTokens.PreviouslyReservedFunctionId, SwiftTokens.PreviouslyReservedFunctionIndex)
    { }

    public override Version RemovalVersion => new(5, 9);
}