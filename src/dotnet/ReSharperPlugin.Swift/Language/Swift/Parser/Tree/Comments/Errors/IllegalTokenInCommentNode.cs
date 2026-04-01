using System;
using JetBrains.ReSharper.Psi.Parsing;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens;
using SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Base;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.ErrorNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;

namespace ReSharperPlugin.Swift.Language.Swift.Parser.Tree.Comments.Errors;

public class IllegalTokenInCommentNode : SwiftErrorLeafNode<SwiftCompositeNode>
{
    internal IllegalTokenInCommentNode(IEditableBuffer underlyingBuffer, TokenNodeType incorrectType)
        : base(underlyingBuffer, GenerateMessage(incorrectType))
    { }

    internal IllegalTokenInCommentNode(IEditableBuffer underlyingBuffer, SwiftCompositeNode parentNode, int parentIndex, int parentTextIndex,
        TokenNodeType incorrectType)
        : base(underlyingBuffer, parentNode, parentIndex, parentTextIndex, GenerateMessage(incorrectType))
    { }

    private static string GenerateMessage(TokenNodeType incorrectToken)
    {
        return $"Unexpected token (expected start ({SwiftTokens.BlockCommentStartRepresentation}), " +
               $"content ({SwiftTokens.BlockCommentContentToken}) or end ({SwiftTokens.BlockCommentEndToken}) tokens) " +
               $"{incorrectToken.TokenRepresentation} in a block comment's parsing.\n" +
               "If the lexer is properly written, this node should never be inserted " +
               "as it should be impossible to get a token other than aforementioned three.";
    }
}