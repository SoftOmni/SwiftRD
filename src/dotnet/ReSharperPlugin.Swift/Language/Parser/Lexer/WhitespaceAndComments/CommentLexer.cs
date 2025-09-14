using JetBrains.Util;
using ReSharperPlugin.Swift.Language.Parser.Lexer.Tokens.WhitespaceAndComments;

namespace ReSharperPlugin.Swift.Language.Parser.Lexer;

public partial class SwiftLexer
{
    private void LexSingleLineComment()
    {
        while (TokenEnd < EOFPos && !Buffer[TokenEnd].IsNewLine())
        {
            TokenEnd++;
        }

        string commentText = Buffer.GetText(new TextRange(TokenStart, TokenEnd));
        TokenType = new LineCommentToken(commentText);
    }

    private void AdvanceMultLineComment()
    {
        const char multiLineCommentEndStart = '*';
        const char multiLineCommentEndEnd = '/';

        TokenStart = TokenEnd;

        while (TokenEnd < EOFPos)
        {
            if (Buffer[TokenEnd] == multiLineCommentEndStart && TokenEnd + 1 < EOFPos &&
                Buffer[TokenEnd + 1] == multiLineCommentEndEnd) // End of comment
            {
                DealWithCommentEnd();
            }

            TokenEnd++;
        }
        
        // We have reached the end of the file, but we still have a comment to lex
        // This means that the comment is not closed, therefore, we will lex the content

        string content = GetCurrentText();
        TokenType = new BlockCommentContentToken(content);
    }
    
    private void DealWithCommentEnd()
    {
        if (TokenStart == TokenEnd)
        {
            // We had an immediate ending comment which means the content if there was some was already lexed
            TokenEnd += 2;
                
            TokenType = new BlockCommentEndToken();
            CommentLevel -= 1;
            LexerStateEx = 0;
            return;
        }
            
        // We hit a multiline ending comment, but there is also some content, therefore,
        // we will only lex the content and the end will be lexed by the previous call to Advance

        string content = GetCurrentText();
        TokenType = new BlockCommentContentToken(content);
    }
}