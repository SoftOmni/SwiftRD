using SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer;

public partial class SwiftLexer
{
    private void LexExclamationMark()
    {
        if (PreviousTokenType is not null && PreviousTokenType.IsWhitespace)
        {
            TokenType = SwiftTokens.QuestionMarkPostfixOperatorToken;
            return;
        }

        TokenType = SwiftTokens.QuestionMarkToken;
    }
}