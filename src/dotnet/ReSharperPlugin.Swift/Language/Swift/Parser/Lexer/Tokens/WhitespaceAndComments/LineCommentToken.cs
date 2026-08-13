using System;
using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Base;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.WhitespaceAndComments;

public class LineCommentToken()
    : SwiftTokenNodeType(SwiftTokens.LineCommentId, SwiftTokens.LineCommentIndex)
{
    public override string TokenRepresentation { get; } = SwiftTokens.LineCommentId;

    public override bool IsComment => true;
    
    public ReadOnlySpan<char> CommentText => TokenRepresentation.AsSpan().Slice(2);

    public override LeafElementBase Create(IBuffer buffer, TreeOffset startOffset, TreeOffset endOffset)
    {
        throw new NotImplementedException();
    }
}
