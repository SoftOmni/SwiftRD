using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.ErrorNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Comments.Errors;

public class NotEndedBlockCommentNode : SwiftErrorLeafNode<SwiftCompositeNode>
{
    internal NotEndedBlockCommentNode(IEditableBuffer underlyingBuffer, int levelOfRecursion)
        : base(underlyingBuffer, GenerateMessage(levelOfRecursion))
    { }

    internal NotEndedBlockCommentNode(IEditableBuffer underlyingBuffer, SwiftCompositeNode parentNode, int parentIndex, int parentTextIndex,
        int levelOfRecursion)
        : base(underlyingBuffer, parentNode, parentIndex, parentTextIndex, GenerateMessage(levelOfRecursion))
    { }

    private static string GenerateMessage(int levelOfRecursion)
    {
        return $"Not closed block comment ({levelOfRecursion}) unclosed block comments";
    }
}