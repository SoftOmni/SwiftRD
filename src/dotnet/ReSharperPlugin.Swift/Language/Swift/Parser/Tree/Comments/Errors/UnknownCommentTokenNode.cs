using JetBrains.ReSharper.Psi.Parsing;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.ErrorNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;

namespace ReSharperPlugin.Swift.Language.Swift.Parser.Tree.Comments.Errors;

public class UnknownCommentTokenNode : SwiftErrorLeafNode<SwiftCompositeNode>
{
    internal UnknownCommentTokenNode(IEditableBuffer underlyingBuffer, TokenNodeType unknownCommentTokenType)
        : base(underlyingBuffer, GenerateMessage(unknownCommentTokenType))
    { }

    internal UnknownCommentTokenNode(IEditableBuffer underlyingBuffer, SwiftCompositeNode parentNode, int parentIndex, int parentTextIndex,
        TokenNodeType unknownCommentTokenType)
        : base(underlyingBuffer, parentNode, parentIndex, parentTextIndex, GenerateMessage(unknownCommentTokenType))
    { }

    private static string GenerateMessage(TokenNodeType unknownCommentTokenType)
    {
        return $"The comment token type '{unknownCommentTokenType.TokenRepresentation}' is an unknown comment token.\n" +
               $"A correctly written swift lexer should have never have returned it. This is an active comment.";
    }
}