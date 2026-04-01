using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Comments;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.NodeTypes.WhitespaceAndComments;

public class BlockCommentEndNodeType : CommentNodeType
{
    internal BlockCommentEndNodeType() : base(SwiftTokens.BlockCommentEndId, SwiftTokens.BlockCommentEndIndex)
    { }

    public override LeafElementBase Create(IEditableBuffer buffer, TreeOffset startOffset, TreeOffset endOffset)
    {
        return new BlockCommentEndNode(buffer);
    }

    public override string TokenRepresentation => SwiftTokens.BlockCommentEndRepresentation;
}