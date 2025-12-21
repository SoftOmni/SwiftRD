using System.Diagnostics.CodeAnalysis;
using ReSharperPlugin.Swift.Language.Parser.Lexer.Tokens;

namespace ReSharperPlugin.Swift.Language.Parser.Lexer;

[SuppressMessage("ReSharper", "CanSimplifyStringEscapeSequence")]
public partial class SwiftLexer
{
    public const char HorizontalTab = '\u0009';
    public const char Space = '\u0020';
    
    public const char LineFeed = '\u000A';
    public const char CarriageReturn = '\u000D';
    
    private void LexWhitespace()
    {
        TokenStart = TokenEnd;
        TokenEnd++;

        while (TokenEnd < EOFPos && Buffer[TokenEnd].IsWhitespace())
        {
            TokenEnd++;
        }

        TokenType = SwiftTokens.WhitespaceToken;
    }

    private void LexLineBreak()
    {
        TokenStart = TokenEnd;
        TokenEnd++;

        if (Buffer[TokenStart] == LineFeed)
        {
            TokenType = SwiftTokens.NewlineToken;
            return;
        }

        TokenType = SwiftTokens.NewlineToken;
        if (TokenEnd < EOFPos && Buffer[TokenEnd] == LineFeed)
        {
            TokenEnd++;
        }
    }
}

internal static partial class SwiftLexerExtensions
{
    public static bool IsWhitespace(this char c)
    {
        return c is SwiftLexer.HorizontalTab or SwiftLexer.Space;
    }
    
    public static bool IsNewLine(this char c)
    {
        return c is SwiftLexer.LineFeed or SwiftLexer.CarriageReturn;
    }
}