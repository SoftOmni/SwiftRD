using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using JetBrains.ReSharper.Feature.Services.CSharp.CompleteStatement;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Comments;

public class BlockCommentNode : SwiftInternalNode, ICommentNode
{
    public bool IsRootComment => ImmediateParentNode is null;

    public int OffsetFromParentComment { get; internal set; }

    public int ChildOffsetFromParentComment { get; internal set; }

    public int OffsetFromRootComment { get; internal set; }

    public BlockCommentStartNode? BlockCommentStartNode { get; }

    public BlockCommentEndNode? BlockCommentEndNode { get; }

    private readonly List<BlockCommentContentNode> _blockCommentContentNodes = [];

    private readonly List<BlockCommentNode> _childrenCommentNodes = [];

    public IReadOnlyList<BlockCommentContentNode> BlockCommentContentNodes => _blockCommentContentNodes;

    private List<CommentChildType> _childTypes = [];

    public IReadOnlyList<CommentChildType> ChildTypes => _childTypes;

    public BlockCommentNode? ImmediateParentNode { get; internal set; }

    public BlockCommentNode? RootParentNode { get; internal set; }

    public enum CommentChildType
    {
        Content,
        BlockComment
    }

    internal BlockCommentNode(IEditableBuffer buffer, List<ISwiftNode> children) : base(buffer, children)
    { }

    internal BlockCommentNode(IEditableBuffer buffer, IEnumerable<ISwiftNode> children) : base(buffer, children)
    { }

    internal BlockCommentNode(ISwiftNode parent, IEditableBuffer buffer, List<ISwiftNode> nodes) : base(parent, buffer,
        nodes)
    {
        SetupCommentNode();
    }

    internal BlockCommentNode(ISwiftNode parent, IEditableBuffer buffer, IEnumerable<ISwiftNode> nodes) : base(parent,
        buffer, nodes)
    {
        SetupCommentNode();
    }

    private void SetupCommentNode()
    {
        if (Parent is BlockCommentNode blockCommentNode)
        {
            ImmediateParentNode = blockCommentNode;
        }

        for (int i = 0; i < _children.Count; i++)
        {
            ISwiftNode child = _children[i];

            if (child is BlockCommentNode childBlockCommentNode)
            {
                _childrenCommentNodes.Add(childBlockCommentNode);
                _childTypes.Add(CommentChildType.BlockComment);

                childBlockCommentNode.ImmediateParentNode = this;
                childBlockCommentNode.RootParentNode = GetRootParent();
            }
            else if (child is BlockCommentContentNode commentContentNode)
            {
                _blockCommentContentNodes.Add(commentContentNode);
                _childTypes.Add(CommentChildType.Content);
            }
        }
    }

    private BlockCommentNode? GetRootParent()
    {
        BlockCommentNode? cursor = ImmediateParentNode;
        if (cursor is null)
        {
            return null;
        }
        
        while (cursor.ImmediateParentNode is not null)
        {
            cursor = cursor.ImmediateParentNode;
        }

        return cursor;
    }

    public static BlockCommentNode Create(string value)
    {
        throw new NotImplementedException();
    }


    public IEnumerator<char> GetEnumerator()
    {
        throw new NotImplementedException();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public int CommentValueLength { get; }
    
    public string GetCommentValue()
    {
        throw new NotImplementedException();
    }

    public string GetCommentSubstring(int start, int length)
    {
        throw new NotImplementedException();
    }

    public ReadOnlySpan<char> AsCommentValue()
    {
        throw new NotImplementedException();
    }

    public ReadOnlySpan<char> AsCommentValue(int start, int length)
    {
        throw new NotImplementedException();
    }

    public bool SetCommentValue(StringBuilder value)
    {
        throw new NotImplementedException();
    }

    public bool SetCommentValue(StringBuilder value, int start)
    {
        throw new NotImplementedException();
    }

    public bool SetCommentValue(StringBuilder value, int start, int count)
    {
        throw new NotImplementedException();
    }

    public bool SetCommentValue(string value)
    {
        throw new NotImplementedException();
    }

    public bool SetCommentValue(string value, int start)
    {
        throw new NotImplementedException();
    }

    public bool SetCommentValue(string value, int start, int count)
    {
        throw new NotImplementedException();
    }

    public bool SetCommentValue(IBuffer value)
    {
        throw new NotImplementedException();
    }

    public bool SetCommentValue(IBuffer value, int start)
    {
        throw new NotImplementedException();
    }

    public bool SetCommentValue(IBuffer value, int start, int count)
    {
        throw new NotImplementedException();
    }

    public bool SetCommentValue(ReadOnlySpan<char> value)
    {
        throw new NotImplementedException();
    }

    public bool SetCommentValue(ReadOnlySpan<char> value, int start)
    {
        throw new NotImplementedException();
    }

    public bool SetCommentValue(ReadOnlySpan<char> value, int start, int count)
    {
        throw new NotImplementedException();
    }

    public bool AppendToCommentValue(StringBuilder value)
    {
        throw new NotImplementedException();
    }

    public bool AppendToCommentValue(StringBuilder value, int start)
    {
        throw new NotImplementedException();
    }

    public bool AppendToCommentValue(StringBuilder value, int start, int count)
    {
        throw new NotImplementedException();
    }

    public bool AppendToCommentValue(string value)
    {
        throw new NotImplementedException();
    }

    public bool AppendToCommentValue(string value, int start)
    {
        throw new NotImplementedException();
    }

    public bool AppendToCommentValue(string value, int start, int count)
    {
        throw new NotImplementedException();
    }

    public bool AppendToCommentValue(IBuffer value)
    {
        throw new NotImplementedException();
    }

    public bool AppendToCommentValue(IBuffer value, int start)
    {
        throw new NotImplementedException();
    }

    public bool AppendToCommentValue(IBuffer value, int start, int count)
    {
        throw new NotImplementedException();
    }

    public bool AppendToCommentValue(ReadOnlySpan<char> value)
    {
        throw new NotImplementedException();
    }

    public bool AppendToCommentValue(ReadOnlySpan<char> value, int start)
    {
        throw new NotImplementedException();
    }

    public bool AppendToCommentValue(ReadOnlySpan<char> value, int start, int count)
    {
        throw new NotImplementedException();
    }

    public bool PrependToCommentValue(StringBuilder value)
    {
        throw new NotImplementedException();
    }

    public bool PrependToCommentValue(StringBuilder value, int start)
    {
        throw new NotImplementedException();
    }

    public bool PrependToCommentValue(StringBuilder value, int start, int count)
    {
        throw new NotImplementedException();
    }

    public bool PrependToCommentValue(string value)
    {
        throw new NotImplementedException();
    }

    public bool PrependToCommentValue(string value, int start)
    {
        throw new NotImplementedException();
    }

    public bool PrependToCommentValue(string value, int start, int count)
    {
        throw new NotImplementedException();
    }

    public bool PrependToCommentValue(IBuffer value)
    {
        throw new NotImplementedException();
    }

    public bool PrependToCommentValue(IBuffer value, int start)
    {
        throw new NotImplementedException();
    }

    public bool PrependToCommentValue(IBuffer value, int start, int count)
    {
        throw new NotImplementedException();
    }

    public bool PrependToCommentValue(ReadOnlySpan<char> value)
    {
        throw new NotImplementedException();
    }

    public bool PrependToCommentValue(ReadOnlySpan<char> value, int start)
    {
        throw new NotImplementedException();
    }

    public bool PrependToCommentValue(ReadOnlySpan<char> value, int start, int count)
    {
        throw new NotImplementedException();
    }

    public bool InsertInCommentValue(int index, StringBuilder insertion)
    {
        throw new NotImplementedException();
    }

    public bool InsertInCommentValue(int index, StringBuilder insertion, int start)
    {
        throw new NotImplementedException();
    }

    public bool InsertInCommentValue(int index, StringBuilder insertion, int start, int count)
    {
        throw new NotImplementedException();
    }

    public bool InsertInCommentValue(int index, string insertion)
    {
        throw new NotImplementedException();
    }

    public bool InsertInCommentValue(int index, string insertion, int start)
    {
        throw new NotImplementedException();
    }

    public bool InsertInCommentValue(int index, string insertion, int start, int count)
    {
        throw new NotImplementedException();
    }

    public bool InsertInCommentValue(int index, IBuffer insertion)
    {
        throw new NotImplementedException();
    }

    public bool InsertInCommentValue(int index, IBuffer insertion, int start)
    {
        throw new NotImplementedException();
    }

    public bool InsertInCommentValue(int index, IBuffer insertion, int start, int count)
    {
        throw new NotImplementedException();
    }

    public bool InsertInCommentValue(int index, ReadOnlySpan<char> insertion)
    {
        throw new NotImplementedException();
    }

    public bool InsertInCommentValue(int index, ReadOnlySpan<char> insertion, int start)
    {
        throw new NotImplementedException();
    }

    public bool InsertInCommentValue(int index, ReadOnlySpan<char> insertion, int start, int count)
    {
        throw new NotImplementedException();
    }

    public bool ReplaceInCommentValue(int index, StringBuilder replacement, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public bool ReplaceInCommentValue(int index, StringBuilder replacement, int replacementStart, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public bool ReplaceInCommentValue(int index, StringBuilder replacement, int replacementStart, int replacementLength,
        bool extend = false)
    {
        throw new NotImplementedException();
    }

    public bool ReplaceInCommentValue(int index, string replacement, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public bool ReplaceInCommentValue(int index, string replacement, int replacementStart, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public bool ReplaceInCommentValue(int index, string replacement, int replacementStart, int replacementLength,
        bool extend = false)
    {
        throw new NotImplementedException();
    }

    public bool ReplaceInCommentValue(int index, IBuffer replacement, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public bool ReplaceInCommentValue(int index, IBuffer replacement, int replacementStart, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public bool ReplaceInCommentValue(int index, IBuffer replacement, int replacementStart, int replacementLength,
        bool extend = false)
    {
        throw new NotImplementedException();
    }

    public bool ReplaceInCommentValue(int index, ReadOnlySpan<char> replacement, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public bool ReplaceInCommentValue(int index, ReadOnlySpan<char> replacement, int replacementStart, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public bool ReplaceInCommentValue(int index, ReadOnlySpan<char> replacement, int replacementStart, int replacementLength,
        bool extend = false)
    {
        throw new NotImplementedException();
    }

    public bool RemoveInCommentValue(int index, int length = 1)
    {
        throw new NotImplementedException();
    }

    public List<int> RemoveInCommentValueWhere(Func<int, char, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public void ClearCommentValue()
    {
        throw new NotImplementedException();
    }

    public bool Contains(char character)
    {
        throw new NotImplementedException();
    }

    public bool Contains(Func<char, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public bool Contains(Func<int, char, bool> predicate)
    {
        throw new NotImplementedException();
    }
}