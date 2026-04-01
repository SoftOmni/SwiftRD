using System;
using SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Base;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.WhitespaceAndComments;

public class LineCommentToken()
    : SwiftTokenNodeType(SwiftTokens.LineCommentId, SwiftTokens.LineCommentIndex)
{
    public override string TokenRepresentation { get; } = SwiftTokens.LineCommentId;

    public override bool IsComment => true;
    
    public ReadOnlySpan<char> CommentText => TokenRepresentation.AsSpan().Slice(2);
}