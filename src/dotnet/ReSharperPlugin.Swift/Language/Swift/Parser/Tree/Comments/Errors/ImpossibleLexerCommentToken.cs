using JetBrains.ReSharper.Psi.Parsing;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.ErrorNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;

namespace ReSharperPlugin.Swift.Language.Swift.Parser.Tree.Comments.Errors;

public class ImpossibleLexerCommentToken : SwiftErrorLeafNode<SwiftCompositeNode>
{
    internal ImpossibleLexerCommentToken(IEditableBuffer underlyingBuffer, TokenNodeType impossibleTokenType)
        : base(underlyingBuffer, GenerateMessage(impossibleTokenType))
    { }

    internal ImpossibleLexerCommentToken(IEditableBuffer underlyingBuffer, SwiftCompositeNode parentNode, int parentIndex, int parentTextIndex,
        TokenNodeType impossibleTokenType)
        : base(underlyingBuffer, parentNode, parentIndex, parentTextIndex, GenerateMessage(impossibleTokenType))
    { }
    
    private static string GenerateMessage(TokenNodeType tokenType) =>
        $"Impossible lexer token type {tokenType.TokenRepresentation} (expected a comment token according to parser logic)";
}