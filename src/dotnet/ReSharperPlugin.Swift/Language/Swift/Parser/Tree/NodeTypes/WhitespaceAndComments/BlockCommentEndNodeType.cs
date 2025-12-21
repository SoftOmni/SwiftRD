using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Parser.Lexer.Tokens;
using ReSharperPlugin.Swift.Language.Parser.Tree.Comments;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.NodeTypes.WhitespaceAndComments;

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