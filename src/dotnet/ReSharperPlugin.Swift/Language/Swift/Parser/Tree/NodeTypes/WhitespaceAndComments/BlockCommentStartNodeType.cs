using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Comments;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Whitespace;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.NodeTypes.WhitespaceAndComments;

public class BlockCommentStartNodeType : CommentNodeType
{
    internal BlockCommentStartNodeType() : base(SwiftTokens.BlockCommentStartId, SwiftTokens.BlockCommentStartIndex)
    { }


    public override LeafElementBase Create(IEditableBuffer buffer, TreeOffset startOffset, TreeOffset endOffset)
    {
        return new BlockCommentStartNode(buffer);
    }

    public override string TokenRepresentation => SwiftTokens.BlockCommentStartRepresentation;
}