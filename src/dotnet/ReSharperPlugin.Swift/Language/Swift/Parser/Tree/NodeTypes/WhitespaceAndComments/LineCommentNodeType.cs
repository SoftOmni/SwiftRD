using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Comments;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.NodeTypes.WhitespaceAndComments;

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