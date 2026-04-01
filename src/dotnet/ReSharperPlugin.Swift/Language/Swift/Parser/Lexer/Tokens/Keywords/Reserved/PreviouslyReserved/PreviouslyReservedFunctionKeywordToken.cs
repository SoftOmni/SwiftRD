using System;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Reserved;

public class PreviouslyReservedFunctionKeywordToken()
    : PreviouslyReservedKeywordToken("#function", SwiftTokens.PreviouslyReservedFunctionId, SwiftTokens.PreviouslyReservedFunctionIndex)
{
    public override Version RemovalVersion => new(5, 9);
}