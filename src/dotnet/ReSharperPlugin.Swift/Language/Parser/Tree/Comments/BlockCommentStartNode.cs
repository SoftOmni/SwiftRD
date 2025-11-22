using System.Collections;
using System.Collections.Generic;
using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Comments;

public class BlockCommentStartNode : SwiftLeafNode
{
    public BlockCommentEndNode? EndNode { get; internal set; }
    
    public BlockCommentContentNode? ContentNode { get; internal set; }
    
    internal BlockCommentStartNode(IEditableBuffer buffer) : base(buffer, NodeTypes.NodeTypes.BlockCommentStart)
    { }

    internal BlockCommentStartNode(SwiftInternalNode parent, IEditableBuffer buffer) : base(parent, buffer,
        NodeTypes.NodeTypes.BlockCommentStart)
    { }

    public static BlockCommentStartNode Create()
    {
        return new BlockCommentStartNode(new EditableBuffer("/*"));
    }

    public static BlockCommentStartNode Create(BlockCommentNode parent)
    {
        return new BlockCommentStartNode(parent, new EditableBuffer("/*"));
    }

    public static BlockCommentStartNode CreateUnchecked(SwiftInternalNode parent)
    {
        return new BlockCommentStartNode(parent, new EditableBuffer("/*"));
    }
}