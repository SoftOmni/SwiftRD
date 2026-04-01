using System;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Reserved;

public class PreviouslyReservedFileIdKeywordToken() : PreviouslyReservedKeywordToken("#fileID",
    SwiftTokens.PreviouslyReservedFileIdId, SwiftTokens.PreviouslyReservedFileIdIndex)
{
    public override Version RemovalVersion => new(5, 9);
}