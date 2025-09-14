using System;

namespace ReSharperPlugin.Swift.Language.Parser.Lexer.Tokens.Reserved;

public class PreviouslyReservedFileIdKeywordToken() : PreviouslyReservedKeywordToken("#fileID",
    SwiftTokens.PreviouslyReservedFileIdIndex)
{
    public override Version RemovalVersion => new(5, 9);
}