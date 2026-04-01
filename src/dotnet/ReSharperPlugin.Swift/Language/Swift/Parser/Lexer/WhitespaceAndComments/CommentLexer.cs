using SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer;

public partial class SwiftLexer
{
    public const char Slash = '/';
    public const char Star = '*';
    
    private void LexSingleLineComment()
    {
        while (TokenEnd < EOFPos && !Buffer[TokenEnd].IsNewLine())
        {
            TokenEnd++;
        }

        TokenType = SwiftTokens.LineCommentToken;
    }

    private void AdvanceMultLineComment()
    {
        const char multiLineCommentEndStart = Star;
        const char multiLineCommentEndEnd = Slash;

        TokenStart = TokenEnd;

        while (TokenEnd < EOFPos)
        {
            if (Buffer[TokenEnd] == multiLineCommentEndStart && TokenEnd + 1 < EOFPos &&
                Buffer[TokenEnd + 1] == multiLineCommentEndEnd) // End of comment
            {
                DealWithCommentEnd();
                return;
            }
            else if (Buffer[TokenEnd] == multiLineCommentEndEnd && TokenEnd + 1 < EOFPos &&
                     Buffer[TokenEnd + 1] == multiLineCommentEndStart)
            {
                DealWithCommentStart();
                return;
            }

            TokenEnd++;
        }
        
        // We have reached the end of the file, but we still have a comment to lex
        // This means that the comment is not closed, therefore, we will lex the content

        TokenType = SwiftTokens.BlockCommentContentToken;
    }

    private void DealWithCommentStart()
    {
        if (TokenStart == TokenEnd)
        {
            // We had an immediate new comment opening which means the content if there was some was already lexed
            TokenEnd += 2;

            TokenType = SwiftTokens.BlockCommentStartToken;
            CommentLevel += 1;
            return;
        }
        
        // We hit a sub-multiline starting comment, but there is also some content, therefore,
        // we will only lex the content and the start will be lexed by the previous call to Advance

        TokenType = SwiftTokens.BlockCommentContentToken;
    }
    
    private void DealWithCommentEnd()
    {
        if (TokenStart == TokenEnd)
        {
            // We had an immediate ending comment which means the content if there was some was already lexed
            TokenEnd += 2;

            TokenType = SwiftTokens.BlockCommentEndToken;
            CommentLevel -= 1;
            LexerStateEx = CommentLevel > 0 ? 1u : 0u;
            return;
        }
            
        // We hit a multiline ending comment, but there is also some content, therefore,
        // we will only lex the content and the end will be lexed by the previous call to Advance

        TokenType = SwiftTokens.BlockCommentContentToken;
    }
}