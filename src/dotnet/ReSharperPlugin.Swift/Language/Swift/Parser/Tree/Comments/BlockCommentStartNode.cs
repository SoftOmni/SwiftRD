using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.LeafNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.NodeTypes;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Comments;

public class BlockCommentStartNode : SwiftLeafNode<SwiftCompositeNode>
{
    public BlockCommentNode? BlockCommentNode { get; internal set; }
    
    public BlockCommentEndNode? EndNode { get; internal set; }

    internal BlockCommentStartNode(IEditableBuffer underlyingBuffer, BlockCommentEndNode? endNode = null)
        : base(underlyingBuffer)
    {
        EndNode = endNode;
    }

    internal BlockCommentStartNode(IEditableBuffer underlyingBuffer, BlockCommentNode parentNode, int parentIndex, int parentTextIndex, BlockCommentEndNode? endNode = null)
        : base(underlyingBuffer, parentNode, parentIndex, parentTextIndex)
    {
        BlockCommentNode = parentNode;
        EndNode = endNode;
    }

    public override NodeType NodeType => SwiftNodeTypes.BlockCommentStart;

    public static BlockCommentStartNode Create()
    {
        return new BlockCommentStartNode(new EditableBuffer("/*"));
    }
}