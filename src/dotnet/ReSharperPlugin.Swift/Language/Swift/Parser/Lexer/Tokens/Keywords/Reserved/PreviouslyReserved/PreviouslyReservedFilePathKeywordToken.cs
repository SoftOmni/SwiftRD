using System;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Reserved;

public class PreviouslyReservedFilePathKeywordToken : PreviouslyReservedKeywordToken
{
    public PreviouslyReservedFilePathKeywordToken()
        : base("#file", SwiftTokens.PreviouslyReservedFilePathId, SwiftTokens.PreviouslyReservedFilePathIndex)
    { }

    public override Version RemovalVersion => new(5, 9);
}