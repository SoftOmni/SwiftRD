using System;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Reserved;

public class PreviouslyReservedFileIdKeywordToken : PreviouslyReservedKeywordToken
{
    public PreviouslyReservedFileIdKeywordToken()
        : base("#fileID",
            SwiftTokens.PreviouslyReservedFileIdId, SwiftTokens.PreviouslyReservedFileIdIndex)
    { }

    public override Version RemovalVersion => new(5, 9);
}