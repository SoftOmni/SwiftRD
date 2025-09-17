using System;

namespace ReSharperPlugin.Swift.Language.Parser.Lexer.Tokens.Reserved;

public class PreviouslyReservedFileKeywordToken() : PreviouslyReservedKeywordToken("#file", SwiftTokens.PreviouslyReservedFileId, SwiftTokens.PreviouslyReservedFileIndex)
{
    public override Version RemovalVersion => new(5, 9);
}