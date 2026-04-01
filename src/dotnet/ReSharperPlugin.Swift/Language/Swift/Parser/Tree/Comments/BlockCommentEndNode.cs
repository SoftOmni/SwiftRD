using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.LeafNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.NodeTypes;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Comments;

public class BlockCommentEndNode : SwiftLeafNode<SwiftCompositeNode>
{
    public BlockCommentStartNode? StartNode { get; internal set; }
    
    public BlockCommentNode? BlockCommentNode { get; internal set; }

    internal BlockCommentEndNode(IEditableBuffer underlyingBuffer, BlockCommentStartNode? startNode = null)
        : base(underlyingBuffer)
    {
        StartNode = startNode;
    }

    internal BlockCommentEndNode(IEditableBuffer underlyingBuffer, BlockCommentNode parentNode, int parentIndex, int parentTextIndex,
        BlockCommentStartNode? startNode = null)
        : base(underlyingBuffer, parentNode, parentIndex, parentTextIndex)
    {
        BlockCommentNode = parentNode;
        StartNode = startNode;
    }

    public override NodeType NodeType => SwiftNodeTypes.BlockCommentEnd;

    public static BlockCommentEndNode Create()
    {
        return new BlockCommentEndNode(new EditableBuffer("*/"));
    }
}