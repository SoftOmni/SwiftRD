using JetBrains.DocumentModel.Impl;
using JetBrains.Text;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Comments;

public class BlockCommentEndNode : SwiftLeafNode
{
    public BlockCommentStartNode? StartNode { get; internal set; }
    
    public BlockCommentContentNode? ContentNode { get; internal set; }
    
    internal BlockCommentEndNode(IEditableBuffer buffer) : base(buffer, NodeTypes.NodeTypes.BlockCommentEnd)
    { }

    internal BlockCommentEndNode(SwiftInternalNode parent, IEditableBuffer buffer) : base(parent, buffer, NodeTypes.NodeTypes.BlockCommentEnd)
    { }
    
    public static BlockCommentEndNode Create()
    {
        return new BlockCommentEndNode(new EditableBuffer("*/"));
    }

    public static BlockCommentEndNode Create(BlockCommentNode parent)
    {
        return new BlockCommentEndNode(parent, new EditableBuffer("*/"));
    }

    public static BlockCommentEndNode CreateUnchecked(SwiftInternalNode parent)
    {
        return new BlockCommentEndNode(parent, new EditableBuffer("*/"));
    }
}