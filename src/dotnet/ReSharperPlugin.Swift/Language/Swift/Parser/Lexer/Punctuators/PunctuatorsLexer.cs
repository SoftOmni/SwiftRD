using System;
using SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer;

public partial class SwiftLexer
{
    private void LexPunctuators()
    {
        TokenStart = TokenEnd;
        TokenEnd++;

        TokenType = Buffer[TokenStart] switch
        {
            '@' => SwiftTokens.AtToken,
            '`' => SwiftTokens.BacktickToken,
            ':' => SwiftTokens.ColonToken,
            ',' => SwiftTokens.CommaToken,
            '.' => SwiftTokens.PeriodToken,
            '{' => SwiftTokens.LeftCurlyBraceToken,
            '(' => SwiftTokens.LeftParenthesisToken,
            '[' => SwiftTokens.LeftSquareBracketToken,
            '}' => SwiftTokens.RightCurlyBraceToken,
            ')' => SwiftTokens.RightParenthesisToken,
            ']' => SwiftTokens.RightSquareBracketToken,
            ';' => SwiftTokens.SemicolonToken,
            _ => throw new ArgumentOutOfRangeException()
        };
    }
}
