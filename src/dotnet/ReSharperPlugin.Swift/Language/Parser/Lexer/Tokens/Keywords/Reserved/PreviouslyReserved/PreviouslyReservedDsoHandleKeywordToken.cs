using System;

namespace ReSharperPlugin.Swift.Language.Parser.Lexer.Tokens.Reserved;

public class PreviouslyReservedDsoHandleKeywordToken() : PreviouslyReservedKeywordToken("#dsohandle", SwiftTokens.PreviouslyReservedDsoHandleId, SwiftTokens.PreviouslyReservedDsoHandleIndex)
{
    public override Version RemovalVersion => new(5, 9);
}