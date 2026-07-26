using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using JetBrains.ReSharper.Psi.Parsing;
using JetBrains.Text;
using SoftOmni.SwiftRd.Extensions;
using SoftOmni.SwiftRd.Language.Base.Interfaces.Flexible.BaseNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Lexer;
using SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Markers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.WhitespaceAndComments;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Comments.Errors;
using SoftOmni.SwiftRd.Technology;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Comments;

public class BlockCommentNode : SwiftCompositeNode, ICommentNode, IEnumerable<BlockCommentContentNode>
{
    public bool IsRootComment => ImmediateParentNode is null;

    public int OffsetFromParentComment { get; internal set; }

    public int ChildOffsetFromParentComment { get; internal set; }

    public int OffsetFromRootComment { get; internal set; }

    public BlockCommentStartNode? BlockCommentStartNode { get; internal set; }

    public BlockCommentEndNode? BlockCommentEndNode { get; internal set; }

    private readonly List<BlockCommentContentNode> _blockCommentContentNodes = [];

    private readonly List<BlockCommentNode> _childrenCommentNodes = [];

    public IReadOnlyList<BlockCommentContentNode> BlockCommentContentNodes => _blockCommentContentNodes;

    private readonly List<CommentChildType> _childTypes = [];

    public IReadOnlyList<CommentChildType> ChildTypes => _childTypes;

    public BlockCommentNode? ImmediateParentNode { get; internal set; }

    public BlockCommentNode? RootParentNode { get; internal set; }

    public enum CommentChildType
    {
        Content,
        BlockComment
    }

    private BlockCommentNode(IEditableBuffer buffer, List<ICommentNode> commentNodes, BlockCommentStartNode startNode, BlockCommentEndNode endNode)
        : base(buffer)
    {
        BlockCommentStartNode = startNode;
        BlockCommentEndNode = endNode;

        foreach (ICommentNode commentNode in commentNodes)
        {
            ChildNodes.Add(commentNode);
        }
    }

    internal BlockCommentNode(SwiftCompositeNode parent, int index, IEditableBuffer editableBuffer, List<ICommentNode> commentNodes,
        BlockCommentStartNode? startNode = null, BlockCommentEndNode? endNode = null)
        : base(parent, index, editableBuffer, commentNodes)
    {
        BlockCommentStartNode = startNode;
        BlockCommentEndNode = endNode;

        SetupCommentNode();
    }

    internal BlockCommentNode(SwiftCompositeNode parent, int index, int textIndex, int lengthInParent, List<ICommentNode> commentNodes,
        BlockCommentStartNode? startNode = null, BlockCommentEndNode? endNode = null)
        : base(parent, index, textIndex, lengthInParent, commentNodes)
    {
        BlockCommentStartNode = startNode;
        BlockCommentEndNode = endNode;

        SetupCommentNode();
    }

    private BlockCommentNode(IEditableBuffer parentBuffer, List<INode> commentNodes, List<BlockCommentNode> childrenCommentNodes, List<BlockCommentContentNode> blockCommentContentNodes, List<CommentChildType> commentChildTypes)
        : base(parentBuffer)
    {
        ChildNodes.AddRange(commentNodes);
        _childTypes = commentChildTypes;
        _childrenCommentNodes = childrenCommentNodes;
        _blockCommentContentNodes = blockCommentContentNodes;
    }

    private void SetupCommentNode()
    {
        if (Parent is BlockCommentNode blockCommentNode)
        {
            ImmediateParentNode = blockCommentNode;
        }

        foreach (INode rawChildNode in ChildNodes)
        {
            ISwiftNode<SwiftCompositeNode> child = (ISwiftNode<SwiftCompositeNode>)rawChildNode;

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
        BlockCommentContentNode contentNode = BlockCommentContentNode.CreateFromValue(value);
        BlockCommentStartNode startNode = BlockCommentStartNode.Create();
        BlockCommentEndNode endNode = BlockCommentEndNode.Create();

        return MergeIntoCommentNode(contentNode, startNode, endNode);
    }

    public static BlockCommentNode Create(IBuffer value)
    {
        BlockCommentContentNode contentNode = BlockCommentContentNode.CreateFromValue(value);
        BlockCommentStartNode startNode = BlockCommentStartNode.Create();
        BlockCommentEndNode endNode = BlockCommentEndNode.Create();

        return MergeIntoCommentNode(contentNode, startNode, endNode);
    }

    private static BlockCommentNode MergeIntoCommentNode(BlockCommentContentNode contentNode, BlockCommentStartNode startNode,
        BlockCommentEndNode endNode)
    {
        IEditableBuffer mergedBuffer =
            EditableBufferExtensions.CombineBuffers(contentNode.CommentValueLength + startNode.GetTextLength() + endNode.GetTextLength());

        BlockCommentNode blockCommentNode = new(mergedBuffer, [contentNode], startNode, endNode);

        contentNode.UnsafeDangerousSetUnderlyingBuffer(new SubEditableBuffer(mergedBuffer, startNode.GetTextLength(),
            contentNode.CommentValueLength));

        endNode.StartNode = startNode;
        startNode.EndNode = endNode;

        startNode.BlockCommentNode = blockCommentNode;
        endNode.BlockCommentNode = blockCommentNode;

        blockCommentNode.AttachChildForcibly(0, startNode);
        blockCommentNode.AttachChildForcibly(blockCommentNode.NumberOfChildren, endNode);

        blockCommentNode.SetupCommentNode();

        return blockCommentNode;
    }

    public BlockCommentContentNodeEnumerator GetCommentEnumerator()
    {
        return new BlockCommentContentNodeEnumerator(this);
    }

    IEnumerator<BlockCommentContentNode> IEnumerable<BlockCommentContentNode>.GetEnumerator()
    {
        return GetCommentEnumerator();
    }

    public IEnumerator<char> GetEnumerator()
    {
        return new BlockCommentEnumerator(this);
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public int CommentValueLength => CalculateCommentValueSize();

    public bool IsEmpty
    {
        get
        {
            IEnumerator<BlockCommentContentNode> contentEnumerator = GetCommentEnumerator();

            while (contentEnumerator.MoveNext())
            {
                if (contentEnumerator.Current?.IsEmpty ?? true)
                {
                    continue;
                }

                contentEnumerator.Dispose();
                return false;
            }

            return true;
        }
    }

    private int CalculateCommentValueSize()
    {
        int commentValueSize = 0;

        IEnumerator<BlockCommentContentNode> commentEnumerator = GetCommentEnumerator();
        while (commentEnumerator.MoveNext())
        {
            commentValueSize += commentEnumerator.Current!.CommentValueLength;
        }

        commentEnumerator.Dispose();
        return commentValueSize;
    }

    public char GetCharAt(int index)
    {
        (BlockCommentContentNode node, int offset) block = GetPointedAtBlockCommentContentByIndex(index);
        return block.node[block.offset];
    }

    public void SetCharAt(int index, char value)
    {
        (BlockCommentContentNode node, int offset) block = GetPointedAtBlockCommentContentByIndex(index);
        block.node[block.offset] = value;
    }

    public string GetCommentValue()
    {
        StringBuilder commentValue = new();

        BlockCommentContentNodeEnumerator commentEnumerator = GetCommentEnumerator();
        while (commentEnumerator.MoveNext())
        {
            BlockCommentContentNode commentContentNode = commentEnumerator.Current;
            StringBuilderExtensions.Append(commentValue, commentContentNode.Buffer);
        }

        commentEnumerator.Dispose();
        return commentValue.ToString();
    }

    public string GetCommentSubstring(int start, int length)
    {
        if (start < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(start));
        }

        if (length < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(length));
        }

        StringBuilder commentValue = new();

        IEnumerator<char> characterEnumerator = GetEnumerator();
        int currentIndex = -1;

        while (currentIndex < start)
        {
            currentIndex++;
            if (!characterEnumerator.MoveNext())
            {
                characterEnumerator.Dispose();
                throw new ArgumentOutOfRangeException(nameof(start));
            }
        }

        int totalLength = start + length;
        while (characterEnumerator.MoveNext() && currentIndex < totalLength)
        {
            commentValue.Append(characterEnumerator.Current);
        }

        characterEnumerator.Dispose();
        if (currentIndex < totalLength)
        {
            throw new ArgumentOutOfRangeException(nameof(length));
        }

        return commentValue.ToString();
    }

    public ReadOnlySpan<char> AsCommentValue()
    {
        throw new NotSupportedException("Error: because we use a string builder under the hood, this method is not supported.");
    }

    public ReadOnlySpan<char> AsCommentValue(int start, int length)
    {
        throw new NotSupportedException("Error: because we use a string builder under the hood, this method is not supported.");
    }

    public bool SetCommentValue(StringBuilder value)
    {
        ClearCommentValue();
        return AppendToCommentValue(value);
    }

    public bool SetCommentValue(StringBuilder value, int start)
    {
        ClearCommentValue();
        return AppendToCommentValue(value, start);
    }

    public bool SetCommentValue(StringBuilder value, int start, int count)
    {
        ClearCommentValue();
        return AppendToCommentValue(value, start, count);
    }

    public bool SetCommentValue(string value)
    {
        ClearCommentValue();
        return AppendToCommentValue(value);
    }

    public bool SetCommentValue(string value, int start)
    {
        ClearCommentValue();
        return AppendToCommentValue(value, start);
    }

    public bool SetCommentValue(string value, int start, int count)
    {
        ClearCommentValue();
        return AppendToCommentValue(value, start, count);
    }

    public bool SetCommentValue(IBuffer value)
    {
        ClearCommentValue();
        return AppendToCommentValue(value);
    }

    public bool SetCommentValue(IBuffer value, int start)
    {
        ClearCommentValue();
        return AppendToCommentValue(value, start);
    }

    public bool SetCommentValue(IBuffer value, int start, int count)
    {
        ClearCommentValue();
        return AppendToCommentValue(value, start, count);
    }

    public bool SetCommentValue(ReadOnlySpan<char> value)
    {
        ClearCommentValue();
        return AppendToCommentValue(value);
    }

    public bool SetCommentValue(ReadOnlySpan<char> value, int start)
    {
        ClearCommentValue();
        return AppendToCommentValue(value, start);
    }

    public bool SetCommentValue(ReadOnlySpan<char> value, int start, int count)
    {
        ClearCommentValue();
        return AppendToCommentValue(value, start, count);
    }

    public bool AppendToCommentValue(StringBuilder value)
    {
        BlockCommentContentNode lastContentNode = GetOrGenerateLastContentNode();
        return lastContentNode.AppendToCommentValue(value);
    }

    public bool AppendToCommentValue(StringBuilder value, int start)
    {
        BlockCommentContentNode lastContentNode = GetOrGenerateLastContentNode();
        return lastContentNode.AppendToCommentValue(value, start);
    }

    public bool AppendToCommentValue(StringBuilder value, int start, int count)
    {
        BlockCommentContentNode lastContentNode = GetOrGenerateLastContentNode();
        return lastContentNode.AppendToCommentValue(value, start, count);
    }

    public bool AppendToCommentValue(string value)
    {
        BlockCommentContentNode lastContentNode = GetOrGenerateLastContentNode();
        return lastContentNode.AppendToCommentValue(value);
    }

    public bool AppendToCommentValue(string value, int start)
    {
        BlockCommentContentNode lastContentNode = GetOrGenerateLastContentNode();
        return lastContentNode.AppendToCommentValue(value, start);
    }

    public bool AppendToCommentValue(string value, int start, int count)
    {
        BlockCommentContentNode lastContentNode = GetOrGenerateLastContentNode();
        return lastContentNode.AppendToCommentValue(value, start, count);
    }

    public bool AppendToCommentValue(IBuffer value)
    {
        BlockCommentContentNode lastContentNode = GetOrGenerateLastContentNode();
        return lastContentNode.AppendToCommentValue(value);
    }

    public bool AppendToCommentValue(IBuffer value, int start)
    {
        BlockCommentContentNode lastContentNode = GetOrGenerateLastContentNode();
        return lastContentNode.AppendToCommentValue(value, start);
    }

    public bool AppendToCommentValue(IBuffer value, int start, int count)
    {
        BlockCommentContentNode lastContentNode = GetOrGenerateLastContentNode();
        return lastContentNode.AppendToCommentValue(value, start, count);
    }

    public bool AppendToCommentValue(ReadOnlySpan<char> value)
    {
        BlockCommentContentNode lastContentNode = GetOrGenerateLastContentNode();
        return lastContentNode.AppendToCommentValue(value);
    }

    public bool AppendToCommentValue(ReadOnlySpan<char> value, int start)
    {
        BlockCommentContentNode lastContentNode = GetOrGenerateLastContentNode();
        return lastContentNode.AppendToCommentValue(value, start);
    }

    public bool AppendToCommentValue(ReadOnlySpan<char> value, int start, int count)
    {
        BlockCommentContentNode lastContentNode = GetOrGenerateLastContentNode();
        return lastContentNode.AppendToCommentValue(value, start, count);
    }

    public bool PrependToCommentValue(StringBuilder value)
    {
        BlockCommentContentNode firstContentNode = GetOrGenerateFirstContentNode();
        return firstContentNode.PrependToCommentValue(value);
    }

    public bool PrependToCommentValue(StringBuilder value, int start)
    {
        BlockCommentContentNode firstContentNode = GetOrGenerateFirstContentNode();
        return firstContentNode.PrependToCommentValue(value, start);
    }

    public bool PrependToCommentValue(StringBuilder value, int start, int count)
    {
        BlockCommentContentNode firstContentNode = GetOrGenerateFirstContentNode();
        return firstContentNode.PrependToCommentValue(value, start, count);
    }

    public bool PrependToCommentValue(string value)
    {
        BlockCommentContentNode firstContentNode = GetOrGenerateFirstContentNode();
        return firstContentNode.PrependToCommentValue(value);
    }

    public bool PrependToCommentValue(string value, int start)
    {
        BlockCommentContentNode firstContentNode = GetOrGenerateFirstContentNode();
        return firstContentNode.PrependToCommentValue(value, start);
    }

    public bool PrependToCommentValue(string value, int start, int count)
    {
        BlockCommentContentNode firstContentNode = GetOrGenerateFirstContentNode();
        return firstContentNode.PrependToCommentValue(value, start, count);
    }

    public bool PrependToCommentValue(IBuffer value)
    {
        BlockCommentContentNode firstContentNode = GetOrGenerateFirstContentNode();
        return firstContentNode.PrependToCommentValue(value);
    }

    public bool PrependToCommentValue(IBuffer value, int start)
    {
        BlockCommentContentNode firstContentNode = GetOrGenerateFirstContentNode();
        return firstContentNode.PrependToCommentValue(value, start);
    }

    public bool PrependToCommentValue(IBuffer value, int start, int count)
    {
        BlockCommentContentNode firstContentNode = GetOrGenerateFirstContentNode();
        return firstContentNode.PrependToCommentValue(value, start, count);
    }

    public bool PrependToCommentValue(ReadOnlySpan<char> value)
    {
        BlockCommentContentNode firstContentNode = GetOrGenerateFirstContentNode();
        return firstContentNode.PrependToCommentValue(value);
    }

    public bool PrependToCommentValue(ReadOnlySpan<char> value, int start)
    {
        BlockCommentContentNode firstContentNode = GetOrGenerateFirstContentNode();
        return firstContentNode.PrependToCommentValue(value, start);
    }

    public bool PrependToCommentValue(ReadOnlySpan<char> value, int start, int count)
    {
        BlockCommentContentNode firstContentNode = GetOrGenerateFirstContentNode();
        return firstContentNode.PrependToCommentValue(value, start, count);
    }

    public bool InsertInCommentValue(int index, StringBuilder insertion)
    {
        (BlockCommentContentNode mostPreciseBlockComment, int offset) = GetPointedAtBlockCommentContentByIndex(index);
        return mostPreciseBlockComment.InsertInCommentValue(offset, insertion);
    }

    public bool InsertInCommentValue(int index, StringBuilder insertion, int start)
    {
        (BlockCommentContentNode mostPreciseBlockComment, int offset) = GetPointedAtBlockCommentContentByIndex(index);
        return mostPreciseBlockComment.InsertInCommentValue(offset, insertion, start);
    }

    public bool InsertInCommentValue(int index, StringBuilder insertion, int start, int count)
    {
        (BlockCommentContentNode mostPreciseBlockComment, int offset) = GetPointedAtBlockCommentContentByIndex(index);
        return mostPreciseBlockComment.InsertInCommentValue(offset, insertion, start, count);
    }

    public bool InsertInCommentValue(int index, string insertion)
    {
        (BlockCommentContentNode mostPreciseBlockComment, int offset) = GetPointedAtBlockCommentContentByIndex(index);
        return mostPreciseBlockComment.InsertInCommentValue(offset, insertion);
    }

    public bool InsertInCommentValue(int index, string insertion, int start)
    {
        (BlockCommentContentNode mostPreciseBlockComment, int offset) = GetPointedAtBlockCommentContentByIndex(index);
        return mostPreciseBlockComment.InsertInCommentValue(offset, insertion, start);
    }

    public bool InsertInCommentValue(int index, string insertion, int start, int count)
    {
        (BlockCommentContentNode mostPreciseBlockComment, int offset) = GetPointedAtBlockCommentContentByIndex(index);
        return mostPreciseBlockComment.InsertInCommentValue(offset, insertion, start, count);
    }

    public bool InsertInCommentValue(int index, IBuffer insertion)
    {
        (BlockCommentContentNode mostPreciseBlockComment, int offset) = GetPointedAtBlockCommentContentByIndex(index);
        return mostPreciseBlockComment.InsertInCommentValue(offset, insertion);
    }

    public bool InsertInCommentValue(int index, IBuffer insertion, int start)
    {
        (BlockCommentContentNode mostPreciseBlockComment, int offset) = GetPointedAtBlockCommentContentByIndex(index);
        return mostPreciseBlockComment.InsertInCommentValue(offset, insertion, start);
    }

    public bool InsertInCommentValue(int index, IBuffer insertion, int start, int count)
    {
        (BlockCommentContentNode mostPreciseBlockComment, int offset) = GetPointedAtBlockCommentContentByIndex(index);
        return mostPreciseBlockComment.InsertInCommentValue(offset, insertion, start, count);
    }

    public bool InsertInCommentValue(int index, ReadOnlySpan<char> insertion)
    {
        (BlockCommentContentNode mostPreciseBlockComment, int offset) = GetPointedAtBlockCommentContentByIndex(index);
        return mostPreciseBlockComment.InsertInCommentValue(offset, insertion);
    }

    public bool InsertInCommentValue(int index, ReadOnlySpan<char> insertion, int start)
    {
        (BlockCommentContentNode mostPreciseBlockComment, int offset) = GetPointedAtBlockCommentContentByIndex(index);
        return mostPreciseBlockComment.InsertInCommentValue(offset, insertion, start);
    }

    public bool InsertInCommentValue(int index, ReadOnlySpan<char> insertion, int start, int count)
    {
        (BlockCommentContentNode mostPreciseBlockComment, int offset) = GetPointedAtBlockCommentContentByIndex(index);
        return mostPreciseBlockComment.InsertInCommentValue(offset, insertion, start, count);

        // TODO: Add parent modification trigger property checks
    }

    public bool ReplaceInCommentValue(int index, StringBuilder replacement, bool extend = false)
    {
        return ThrowBecauseReplaceNotSupportedYet();
    }

    public bool ReplaceInCommentValue(int index, StringBuilder replacement, int replacementStart, bool extend = false)
    {
        return ThrowBecauseReplaceNotSupportedYet();
    }

    public bool ReplaceInCommentValue(int index, StringBuilder replacement, int replacementStart, int replacementLength, bool extend = false)
    {
        return ThrowBecauseReplaceNotSupportedYet();
    }

    public bool ReplaceInCommentValue(int index, string replacement, bool extend = false)
    {
        return ThrowBecauseReplaceNotSupportedYet();
    }

    public bool ReplaceInCommentValue(int index, string replacement, int replacementStart, bool extend = false)
    {
        return ThrowBecauseReplaceNotSupportedYet();
    }

    public bool ReplaceInCommentValue(int index, string replacement, int replacementStart, int replacementLength, bool extend = false)
    {
        return ThrowBecauseReplaceNotSupportedYet();
    }

    public bool ReplaceInCommentValue(int index, IBuffer replacement, bool extend = false)
    {
        return ThrowBecauseReplaceNotSupportedYet();
    }

    public bool ReplaceInCommentValue(int index, IBuffer replacement, int replacementStart, bool extend = false)
    {
        return ThrowBecauseReplaceNotSupportedYet();
    }

    public bool ReplaceInCommentValue(int index, IBuffer replacement, int replacementStart, int replacementLength, bool extend = false)
    {
        return ThrowBecauseReplaceNotSupportedYet();
    }

    public bool ReplaceInCommentValue(int index, ReadOnlySpan<char> replacement, bool extend = false)
    {
        return ThrowBecauseReplaceNotSupportedYet();
    }

    public bool ReplaceInCommentValue(int index, ReadOnlySpan<char> replacement, int replacementStart, bool extend = false)
    {
        return ThrowBecauseReplaceNotSupportedYet();
    }

    public bool ReplaceInCommentValue(int index, ReadOnlySpan<char> replacement, int replacementStart, int replacementLength, bool extend = false)
    {
        return ThrowBecauseReplaceNotSupportedYet();
    }

    public bool RemoveInCommentValue(int index, int length = 1)
    {
        int currentOffset = 0;

        List<(BlockCommentContentNode contentNode, int offset, int removalLength)> operations = [];

        BlockCommentContentNodeEnumerator commentEnumerator = GetCommentEnumerator();
        int removedLength = 0;
        while (commentEnumerator.MoveNext())
        {
            BlockCommentContentNode commentContentNode = commentEnumerator.Current;

            if (currentOffset + commentContentNode.CommentValueLength <= index)
            {
                int subOffset = index - currentOffset;
                int deletedLength = Math.Min(commentContentNode.CommentValueLength - subOffset, length);

                operations.Add((commentContentNode, subOffset, deletedLength));
                removedLength += deletedLength;
                currentOffset += commentContentNode.CommentValueLength;
                break;
            }

            currentOffset += commentContentNode.CommentValueLength;
        }

        if (currentOffset < index)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        while (commentEnumerator.MoveNext() && removedLength < length)
        {
            BlockCommentContentNode commentContentNode = commentEnumerator.Current;
            
            int deletedLength = Math.Min(commentContentNode.CommentValueLength, length - removedLength);
            removedLength += deletedLength;
            
            operations.Add((commentContentNode, 0, deletedLength));
        }

        commentEnumerator.Dispose();
        foreach ((BlockCommentContentNode contentNode, int offset, int removalLength) in operations)
        {
            contentNode.RemoveInCommentValue(offset, removalLength);
            if (removalLength == contentNode.CommentValueLength)
            {
                contentNode.CommentNode?.DetachChildAtAndDiscard<BlockCommentContentNode>(contentNode.ParentIndex);
            }
        }

        return removedLength == length;
    }

    public List<int> RemoveInCommentValueWhere(Func<int, char, bool> predicate)
    {
        int globalIndex = 0;
        List<int> removalLocations = [];
        
        BlockCommentContentNodeEnumerator commentEnumerator = GetCommentEnumerator();
        while (commentEnumerator.MoveNext())
        {
            BlockCommentContentNode commentContentNode = commentEnumerator.Current;

            int targetLocalIndex = globalIndex + commentContentNode.GetTextLength();
            for (int localIndex = 0; localIndex < targetLocalIndex; localIndex++)
            {
                if (!predicate(globalIndex, commentContentNode[localIndex]))
                {
                    globalIndex++;
                    continue;
                }

                commentContentNode.RemoveInCommentValue(localIndex);
                removalLocations.Add(localIndex);
                localIndex--; // TODO: Investigate if this is intentional
            }

            globalIndex += commentContentNode.GetTextLength();
            if (commentContentNode.IsEmpty)
            {
                commentContentNode.CommentNode?.DetachChildAtAndDiscard<BlockCommentContentNode>(commentContentNode.ParentIndex);
            }
        }

        commentEnumerator.Dispose();
        return removalLocations;
    }

    public void ClearCommentValue()
    {
        // ReSharper disable once MergeIntoPattern
        if (_childTypes.Count == 1 && _childTypes[0] is CommentChildType.Content)
        {
            BlockCommentContentNodes[0].ClearCommentValue();
            return;
        }

        ClearChildren(1, NumberOfChildren - 1);

        _childTypes.Clear();
        _childrenCommentNodes.Clear();
        _blockCommentContentNodes.Clear();
    }

    public bool Contains(char character)
    {
        IEnumerator<char> textEnumerator = GetEnumerator();
        while (textEnumerator.MoveNext())
        {
            char currentCharacter = textEnumerator.Current;
            if (currentCharacter != character)
            {
                continue;
            }

            textEnumerator.Dispose();
            return true;
        }

        textEnumerator.Dispose();
        return false;
    }

    public bool Contains(Func<char, bool> predicate)
    {
        IEnumerator<char> textEnumerator = GetEnumerator();
        while (textEnumerator.MoveNext())
        {
            char currentCharacter = textEnumerator.Current;
            if (!predicate(currentCharacter))
            {
                continue;
            }

            textEnumerator.Dispose();
            return true;
        }

        textEnumerator.Dispose();
        return false;
    }

    public bool Contains(Func<int, char, bool> predicate)
    {
        IEnumerator<char> textEnumerator = GetEnumerator();
        int index = 0;
        while (textEnumerator.MoveNext())
        {
            char currentCharacter = textEnumerator.Current;
            if (predicate(index, currentCharacter))
            {
                textEnumerator.Dispose();
                return true;
            }

            index++;
        }

        textEnumerator.Dispose();
        return false;
    }

    private (BlockCommentContentNode node, int offset) GetPointedAtBlockCommentContentByIndex(int index)
    {
        int currentOffset = 0;

        BlockCommentContentNodeEnumerator commentEnumerator = GetCommentEnumerator();
        while (commentEnumerator.MoveNext())
        {
            BlockCommentContentNode commentContentNode = commentEnumerator.Current;

            if (currentOffset + commentContentNode.CommentValueLength <= index)
            {
                commentEnumerator.Dispose();

                return (commentContentNode, index - currentOffset);
            }

            currentOffset += commentContentNode.CommentValueLength;
        }

        commentEnumerator.Dispose();
        throw new ArgumentOutOfRangeException(nameof(index));
    }

    private BlockCommentContentNode GetOrGenerateLastContentNode()
    {
        if (_childTypes.Count > 0 && _childTypes[0] is CommentChildType.Content)
        {
            return BlockCommentContentNodes[0];
        }

        BlockCommentContentNode newContentNode = new(new SubEditableBuffer(UnderlyingBuffer, BlockCommentStartNode?.GetTextLength() ?? 0),
            BlockCommentStartNode, BlockCommentEndNode, this);

        ChildNodes.Insert(BlockCommentStartNode is null ? 0 : 1, newContentNode);
        _childTypes.Insert(0, CommentChildType.Content);
        _blockCommentContentNodes.Insert(0, newContentNode);

        return newContentNode;
    }

    private BlockCommentContentNode GetOrGenerateFirstContentNode()
    {
        if (_childTypes.Count > 0 && _childTypes[_childTypes.Count - 1] is CommentChildType.Content)
        {
            return BlockCommentContentNodes[0];
        }

        BlockCommentContentNode newContentNode =
            new(new SubEditableBuffer(UnderlyingBuffer, GetTextLength() - BlockCommentEndNode?.GetTextLength() ?? 0), BlockCommentStartNode,
                BlockCommentEndNode, this);

        ChildNodes.Insert(BlockCommentEndNode is null ? ChildNodes.Count : ChildNodes.Count - 1, newContentNode);
        _childTypes.Add(CommentChildType.Content);
        _blockCommentContentNodes.Add(newContentNode);

        return newContentNode;
    }

    private static bool ThrowBecauseReplaceNotSupportedYet()
    {
        throw new NotSupportedException("ERROR: This method due to its complexity and low priority will be implemented at a later date.\n" +
                                        "Please replace how you see fit in the child nodes instead");
    }

    internal static BlockCommentNode ParseWithStart(SwiftLexer lexer, IEditableBuffer parentBuffer, int offset, int levelOfBlockComment)
    {
        SubEditableBuffer subBuffer = new(parentBuffer, offset); // TODO: Make iterative
        TokenNodeType? lexerTokenType = lexer.TokenType;
        List<BlockCommentContentNode> blockCommentContentNodes = [];
        List<BlockCommentNode> childrenCommentNodes = [];
        List<CommentChildType> commentChildTypes = [];
        List<INode> childNodes = [];

        BlockCommentStartNode firstNode = new(new SubEditableBuffer(subBuffer, 0, lexer.TokenLength));
        childNodes.Add(firstNode);

        lexer.Advance();
        int subOffset = lexer.TokenLength;
        while (lexerTokenType is not null and not BlockCommentEndToken and not EndOfFileToken)
        {
            if (lexerTokenType is BlockCommentContentToken)
            {
                BlockCommentContentNode blockCommentContentNode = new(new SubEditableBuffer(subBuffer, subOffset, lexer.TokenLength));
                blockCommentContentNodes.Add(blockCommentContentNode);
                subOffset += lexer.TokenLength;

                commentChildTypes.Add(CommentChildType.Content);
                childNodes.Add(blockCommentContentNode);
                lexer.Advance();
                lexerTokenType = lexer.TokenType;
                continue;
            }

            if (lexerTokenType is not BlockCommentStartToken) // If the lexer is working, this should never happen
            {
                childNodes.Add(new IllegalTokenInCommentNode(new SubEditableBuffer(parentBuffer, subOffset, lexer.TokenLength), lexerTokenType));
                subOffset += lexer.TokenLength;
                continue;
            }

            BlockCommentNode childCommentNode = ParseWithStart(lexer, subBuffer, subOffset, levelOfBlockComment + 1);
            subOffset += childCommentNode.GetTextLength();

            childrenCommentNodes.Add(childCommentNode);
            commentChildTypes.Add(CommentChildType.BlockComment);
            childNodes.Add(childCommentNode);

            lexer.Advance();
            lexerTokenType = lexer.TokenType;
        }

        if (lexerTokenType is not BlockCommentEndToken)
        {
            childNodes.Add(new NotEndedBlockCommentNode(parentBuffer, levelOfBlockComment));
        }
        else
        {
            BlockCommentEndNode endNode = new(new SubEditableBuffer(parentBuffer, subOffset, lexer.TokenLength));
            childNodes.Add(endNode);
        }

        return new BlockCommentNode(parentBuffer, childNodes, childrenCommentNodes, blockCommentContentNodes, commentChildTypes);
    }

    public class BlockCommentContentNodeEnumerator : IEnumerator<BlockCommentContentNode>
    {
        private readonly BlockCommentNode _rootNode;

        private readonly Stack<BlockCommentNode> _nodeStack;

        private readonly Stack<(int childTypeIndex, int blockCommentIndex, int contentNodesIndex)> _nodeChildCursorPositions;

        public BlockCommentContentNodeEnumerator(BlockCommentNode rootNode)
        {
            _rootNode = rootNode;
            _nodeStack = new Stack<BlockCommentNode>();
            _nodeChildCursorPositions = new Stack<(int childTypeIndex, int blockCommentIndex, int contentNodesIndex)>();

            _nodeStack.Push(rootNode);
            _nodeChildCursorPositions.Push((-1, 0, 0));
        }

        public bool MoveNext()
        {
            if (_nodeStack.Count == 0)
            {
                return false;
            }

            IncrementCursorPosition();
            while (_nodeStack.Count > 0)
            {
                if (_nodeChildCursorPositions.Peek().childTypeIndex >= _nodeStack.Peek()._childTypes.Count)
                {
                    _nodeStack.Pop();
                    _nodeChildCursorPositions.Pop();
                    continue;
                }

                IncrementCursorPosition();
                (int childTypeIndex, int blockCommentIndex, int contentNodesIndex) currentPosition = _nodeChildCursorPositions.Peek();
                if (_nodeStack.Peek()._childTypes[_nodeChildCursorPositions.Peek().childTypeIndex] is CommentChildType.BlockComment)
                {
                    _nodeChildCursorPositions.Push((currentPosition.childTypeIndex, currentPosition.blockCommentIndex + 1,
                        currentPosition.contentNodesIndex));

                    _nodeStack.Push(_nodeStack.Peek()._childrenCommentNodes[currentPosition.blockCommentIndex]);
                    _nodeChildCursorPositions.Push((-1, 0, 0));
                    continue;
                }

                _nodeChildCursorPositions.Push((currentPosition.childTypeIndex, currentPosition.blockCommentIndex,
                    currentPosition.contentNodesIndex + 1));
                return true; // We have a content node
            }

            return false;
        }

        public void Reset()
        {
            _nodeChildCursorPositions.Clear();
            _nodeStack.Clear();
            _nodeStack.Push(_rootNode);
            _nodeChildCursorPositions.Push((-1, 0, 0));
        }

        private void IncrementCursorPosition()
        {
            (int childTypeIndex, int blockCommentIndex, int contentNodesIndex) position = _nodeChildCursorPositions.Pop();
            _nodeChildCursorPositions.Push((position.childTypeIndex + 1, position.blockCommentIndex, position.contentNodesIndex));
        }

        public BlockCommentContentNode Current => _nodeStack.Peek().BlockCommentContentNodes[_nodeChildCursorPositions.Peek().contentNodesIndex];

        object IEnumerator.Current => Current;

        public void Dispose()
        {
            // Nothing to do
        }
    }

    public struct BlockCommentEnumerator(BlockCommentNode rootNode) : IEnumerator<char>
    {
        private readonly BlockCommentContentNodeEnumerator _blockEnumerator = new(rootNode);

        private int _currentContentNodeIndex = -1;

        public void Dispose()
        {
            // Nothing to do
        }

        public bool MoveNext()
        {
            if (_currentContentNodeIndex != -1)
            {
                _currentContentNodeIndex += 1;
                if (_currentContentNodeIndex < _blockEnumerator.Current.CommentValueLength)
                {
                    return true;
                }
            }

            if (_blockEnumerator.MoveNext())
            {
                _currentContentNodeIndex = 0;
            }

            return false;
        }

        public void Reset()
        {
            _blockEnumerator.Reset();
            _currentContentNodeIndex = -1;
        }

        public char Current => _blockEnumerator.Current.GetCharAt(_currentContentNodeIndex);

        object IEnumerator.Current => Current;
    }
}