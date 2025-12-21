using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Parser.Lexer.Tokens;
using ReSharperPlugin.Swift.Language.Parser.Tree.Comments;
using ReSharperPlugin.Swift.Language.Parser.Tree.Whitespace;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.NodeTypes.WhitespaceAndComments;

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