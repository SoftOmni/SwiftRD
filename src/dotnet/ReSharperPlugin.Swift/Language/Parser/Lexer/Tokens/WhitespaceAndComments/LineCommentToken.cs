using System;
using ReSharperPlugin.Swift.Language.Parser.Lexer.Tokens.Base;

namespace ReSharperPlugin.Swift.Language.Parser.Lexer.Tokens.WhitespaceAndComments;

public class LineCommentToken(string lineComment)
    : SwiftTokenNodeType(lineComment, SwiftTokens.LineCommentIndex)
{
    public override string TokenRepresentation { get; } = lineComment;

    public override bool IsComment => true;
    
    public ReadOnlySpan<char> CommentText => TokenRepresentation.AsSpan().Slice(2);
}