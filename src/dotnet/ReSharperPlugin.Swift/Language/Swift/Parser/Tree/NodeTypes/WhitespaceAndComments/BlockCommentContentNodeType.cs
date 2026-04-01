using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Comments;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.NodeTypes.WhitespaceAndComments;

public class BlockCommentContentNodeType : CommentNodeType
{
    internal BlockCommentContentNodeType() : base(SwiftTokens.BlockCommentContentId, SwiftTokens.BlockCommentContentIndex)
    { }

    public override LeafElementBase Create(IEditableBuffer buffer, TreeOffset startOffset, TreeOffset endOffset)
    {
        return new BlockCommentContentNode(buffer);
    }

    public override string TokenRepresentation => SwiftTokens.BlockCommentContentId;
}