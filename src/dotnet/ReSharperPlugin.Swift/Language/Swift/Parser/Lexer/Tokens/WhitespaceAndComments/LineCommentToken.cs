using System;
using ReSharperPlugin.Swift.Language.Parser.Lexer.Tokens.Base;

namespace ReSharperPlugin.Swift.Language.Parser.Lexer.Tokens.WhitespaceAndComments;

public class LineCommentToken()
    : SwiftTokenNodeType(SwiftTokens.LineCommentId, SwiftTokens.LineCommentIndex)
{
    public override string TokenRepresentation { get; } = SwiftTokens.LineCommentId;

    public override bool IsComment => true;
    
    public ReadOnlySpan<char> CommentText => TokenRepresentation.AsSpan().Slice(2);
}