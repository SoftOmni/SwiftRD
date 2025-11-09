using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Parser.Lexer.Tokens;
using ReSharperPlugin.Swift.Language.Parser.Tree.Comments;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.NodeTypes.WhitespaceAndComments;

public class LineCommentNodeType : CommentNodeType
{
    internal LineCommentNodeType() : base(SwiftTokens.LineCommentId, SwiftTokens.LineCommentIndex)
    { }

    public override LeafElementBase Create(IEditableBuffer buffer, TreeOffset startOffset, TreeOffset endOffset)
    {
        return new LineCommentNode(buffer);
    }

    public override string TokenRepresentation => SwiftTokens.LineCommentId;
}