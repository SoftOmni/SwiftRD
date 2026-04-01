using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.ReSharper.Psi.Parsing;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Lexer;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.LeafNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.NodeTypes;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Comments;

// ReSharper disable RedundantIfElseBlock
public class BlockCommentContentNode : SwiftLeafNode<SwiftCompositeNode>, ILeafCommentNode
{
    public BlockCommentStartNode? StartNode { get; internal set; }

    public BlockCommentEndNode? EndNode { get; internal set; }

    public BlockCommentNode? CommentNode { get; internal set; }

    internal BlockCommentContentNode(IEditableBuffer underlyingBuffer, BlockCommentStartNode? startNode = null, BlockCommentEndNode? endNode = null,
        BlockCommentNode? commentNode = null)
        : base(underlyingBuffer)
    {
        StartNode = startNode;
        EndNode = endNode;
        CommentNode = commentNode;
    }

    internal BlockCommentContentNode(IEditableBuffer underlyingBuffer, SwiftCompositeNode parentNode, int parentIndex, int parentTextIndex,
        BlockCommentStartNode? startNode = null, BlockCommentEndNode? endNode = null, BlockCommentNode? commentNode = null)
        : base(underlyingBuffer, parentNode, parentIndex, parentTextIndex)
    {
        StartNode = startNode;
        EndNode = endNode;
        CommentNode = commentNode;
    }

    public char this[int index]
    {
        get => GetCharAt(index);
        set => SetCharAt(index, value);
    }

    public char GetCharAt(int index)
    {
        return UnderlyingBuffer[index];
    }

    public void SetCharAt(int index, char value)
    {
        ReadOnlySpan<char> charSpan = stackalloc char[] { value };
        ReplaceInCommentValue(index, charSpan);
    }

    public static BlockCommentContentNode CreateFromValue(string value)
    {
        if (ContainsInnerComment(value))
        {
            throw new SyntaxError("A block comment content node can not contain an inner comment");
        }

        return new BlockCommentContentNode(new EditableBuffer(value));
    }

    public static BlockCommentContentNode CreateFromValue(IBuffer value)
    {
        if (ContainsInnerComment(value))
        {
            throw new SyntaxError("A block comment content node can not contain an inner comment");
        }

        return new BlockCommentContentNode(EditableBufferExtensions.CloneBuffer(value));
    }

    public override NodeType NodeType => SwiftNodeTypes.BlockCommentContent;

    public bool IsAssociatedWithBlockComment => Parent is BlockCommentNode;

    public bool IsAssociatedWithStartNode => StartNode is not null;

    public bool IsAssociatedWithEndNode => EndNode is not null;

    public int CommentValueLength => UnderlyingBuffer.Length;

    public bool IsEmpty => CommentValueLength != 0;

    public string GetCommentValue()
    {
        return UnderlyingBuffer.ToString();
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

        StringBuilder builder = new();
        int target = start + length;
        for (int i = start; i < target; i++)
        {
            builder.Append(Buffer[i]);
        }

        return builder.ToString();
    }

    public ReadOnlySpan<char> AsCommentValue()
    {
        UnderlyingBuffer.TryGetReadOnlySpan(out ReadOnlySpan<char> span);
        return span;
    }

    public ReadOnlySpan<char> AsCommentValue(int start, int length)
    {
        if (start < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(start));
        }

        if (length < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(length));
        }

        UnderlyingBuffer.TryGetReadOnlySpan(out ReadOnlySpan<char> span);
        return span.Slice(start, start + length);
    }

    public bool SetCommentValue(StringBuilder value)
    {
        if (ContainsInnerComment(value))
        {
            return false;
        }

        SetCommentValueUnchecked(value);
        return false;
    }

    public bool SetCommentValue(StringBuilder value, int start)
    {
        if (start < 0 || start >= value.Length)
        {
            throw new ArgumentOutOfRangeException(nameof(start));
        }

        if (ContainsInnerComment(value))
        {
            return false;
        }

        SetCommentValueUnchecked(value, start, value.Length - start);
        return true;
    }

    public bool SetCommentValue(StringBuilder value, int start, int count)
    {
        if (start < 0 || start >= value.Length)
        {
            throw new ArgumentOutOfRangeException(nameof(start));
        }

        if (count < 0 || start + count >= value.Length)
        {
            throw new ArgumentOutOfRangeException(nameof(count));
        }

        if (ContainsInnerComment(value))
        {
            return false;
        }

        SetCommentValueUnchecked(value, start, count);
        return true;
    }

    public bool SetCommentValue(string value)
    {
        if (ContainsInnerComment(value))
        {
            return false;
        }

        SetCommentValueUnchecked(value);
        return true;
    }

    public bool SetCommentValue(string value, int start)
    {
        if (start < 0 || start >= value.Length)
        {
            throw new ArgumentOutOfRangeException(nameof(start));
        }

        if (ContainsInnerComment(value, start))
        {
            return false;
        }

        SetCommentValueUnchecked(value, start, value.Length - start);
        return true;
    }

    public bool SetCommentValue(string value, int start, int count)
    {
        if (start < 0 || start >= value.Length)
        {
            throw new ArgumentOutOfRangeException(nameof(start));
        }

        if (count < 0 || start + count >= value.Length)
        {
            throw new ArgumentOutOfRangeException(nameof(count));
        }

        if (ContainsInnerComment(value, start, count))
        {
            return false;
        }

        SetCommentValueUnchecked(value, start, count);
        return true;
    }

    public bool SetCommentValue(IBuffer value)
    {
        if (ContainsInnerComment(value))
        {
            return false;
        }

        SetCommentValueUnchecked(value);
        return true;
    }

    public bool SetCommentValue(IBuffer value, int start)
    {
        if (start < 0 || start >= value.Length)
        {
            throw new ArgumentOutOfRangeException(nameof(start));
        }

        if (ContainsInnerComment(value, start))
        {
            return false;
        }

        SetCommentValueUnchecked(value, start, value.Length - start);
        return true;
    }

    public bool SetCommentValue(IBuffer value, int start, int count)
    {
        if (start < 0 || start >= value.Length)
        {
            throw new ArgumentOutOfRangeException(nameof(start));
        }

        if (count < 0 || start + count >= value.Length)
        {
            throw new ArgumentOutOfRangeException(nameof(count));
        }

        if (ContainsInnerComment(value, start, count))
        {
            return false;
        }

        SetCommentValueUnchecked(value, start, count);
        return true;
    }

    public bool SetCommentValue(ReadOnlySpan<char> value)
    {
        if (ContainsInnerComment(value))
        {
            return false;
        }

        SetCommentValueUnchecked(ref value);
        return true;
    }

    public bool SetCommentValue(ReadOnlySpan<char> value, int start)
    {
        if (start < 0 || start >= value.Length)
        {
            throw new ArgumentOutOfRangeException(nameof(start));
        }

        if (ContainsInnerComment(value, start))
        {
            return false;
        }

        SetCommentValueUnchecked(ref value, start, value.Length - start);
        return true;
    }

    public bool SetCommentValue(ReadOnlySpan<char> value, int start, int count)
    {
        if (start < 0 || start >= value.Length)
        {
            throw new ArgumentOutOfRangeException(nameof(start));
        }

        if (count < 0 || start + count >= value.Length)
        {
            throw new ArgumentOutOfRangeException(nameof(count));
        }

        if (ContainsInnerComment(value, start, count))
        {
            return false;
        }

        SetCommentValueUnchecked(ref value, start, count);
        return true;
    }

    protected void SetCommentValueUnchecked(StringBuilder value, int start = 0)
    {
        SetCommentValueUnchecked(value, start, value.Length - start);
    }

    protected void SetCommentValueUnchecked(StringBuilder value, int start, int count)
    {
        int commentTarget = Math.Min(count, UnderlyingBuffer.Length);
        int originalLength = CommentValueLength;

        for (int i = 0; i < commentTarget; i++)
        {
            UnderlyingBuffer.Replace(i, 1, value[start + i].ToString());
        }

        for (int i = commentTarget; i < count; i++)
        {
            UnderlyingBuffer.Insert(i, value[start + i].ToString());
        }

        if (UnderlyingBuffer.Length > count)
        {
            UnderlyingBuffer.Remove(UnderlyingBuffer.Length, UnderlyingBuffer.Length - count);
        }

        CascadeTextOffsetChange(originalLength - count);
    }

    protected void SetCommentValueUnchecked(string value, int start = 0)
    {
        SetCommentValueUnchecked(value, start, value.Length - start);
    }

    protected void SetCommentValueUnchecked(string value, int start, int count)
    {
        int commentTarget = Math.Min(count, UnderlyingBuffer.Length);
        int originalLength = CommentValueLength;

        for (int i = 0; i < commentTarget; i++)
        {
            UnderlyingBuffer.Replace(i, 1, value[start + i].ToString());
        }

        for (int i = commentTarget; i < count; i++)
        {
            UnderlyingBuffer.Insert(i, value[start + i].ToString());
        }

        if (UnderlyingBuffer.Length > count)
        {
            UnderlyingBuffer.Remove(UnderlyingBuffer.Length, UnderlyingBuffer.Length - count);
        }

        CascadeTextOffsetChange(originalLength - count);
    }

    protected void SetCommentValueUnchecked(IBuffer value, int start = 0)
    {
        SetCommentValueUnchecked(value, start, value.Length - start);
    }

    protected void SetCommentValueUnchecked(IBuffer value, int start, int count)
    {
        int commentTarget = Math.Min(count, UnderlyingBuffer.Length);
        int originalLength = CommentValueLength;

        for (int i = 0; i < commentTarget; i++)
        {
            UnderlyingBuffer.Replace(i, 1, value[start + i].ToString());
        }

        for (int i = commentTarget; i < count; i++)
        {
            UnderlyingBuffer.Insert(i, value[start + i].ToString());
        }

        if (UnderlyingBuffer.Length > count)
        {
            UnderlyingBuffer.Remove(UnderlyingBuffer.Length, UnderlyingBuffer.Length - count);
        }

        CascadeTextOffsetChange(originalLength - count);
    }

    protected void SetCommentValueUnchecked(ref ReadOnlySpan<char> value, int start = 0)
    {
        SetCommentValueUnchecked(ref value, start, value.Length - start);
    }

    protected void SetCommentValueUnchecked(ref ReadOnlySpan<char> value, int start, int count)
    {
        int commentTarget = Math.Min(count, UnderlyingBuffer.Length);
        int originalLength = CommentValueLength;

        for (int i = 0; i < commentTarget; i++)
        {
            UnderlyingBuffer.Replace(i, 1, value[start + i].ToString());
        }

        for (int i = commentTarget; i < count; i++)
        {
            UnderlyingBuffer.Insert(i, value[start + i].ToString());
        }

        if (UnderlyingBuffer.Length > count)
        {
            UnderlyingBuffer.Remove(UnderlyingBuffer.Length, UnderlyingBuffer.Length - count);
        }

        CascadeTextOffsetChange(originalLength - count);
    }

    public bool AppendToCommentValue(StringBuilder value)
    {
        if (ContainsInnerComment(value))
        {
            return false;
        }

        AppendToCommentValueUnchecked(value);
        return true;
    }

    public bool AppendToCommentValue(StringBuilder value, int start)
    {
        if (start < 0 || start >= value.Length)
        {
            throw new ArgumentOutOfRangeException(nameof(start));
        }

        if (ContainsInnerComment(value, start))
        {
            return false;
        }

        AppendToCommentValueUnchecked(value, start, value.Length - start);
        return true;
    }

    public bool AppendToCommentValue(StringBuilder value, int start, int count)
    {
        if (start < 0 || start >= value.Length)
        {
            throw new ArgumentOutOfRangeException(nameof(start));
        }

        if (count < 0 || start + count >= value.Length)
        {
            throw new ArgumentOutOfRangeException(nameof(count));
        }

        if (ContainsInnerComment(value, start, count))
        {
            return true;
        }

        AppendToCommentValueUnchecked(value, start, count);
        return true;
    }

    public bool AppendToCommentValue(string value)
    {
        if (ContainsInnerComment(value))
        {
            return false;
        }

        AppendToCommentValueUnchecked(value);
        return true;
    }

    public bool AppendToCommentValue(string value, int start)
    {
        if (start < 0 || start >= value.Length)
        {
            throw new ArgumentOutOfRangeException(nameof(start));
        }

        if (ContainsInnerComment(value, start))
        {
            return false;
        }

        AppendToCommentValueUnchecked(value, start, value.Length - start);
        return true;
    }

    public bool AppendToCommentValue(string value, int start, int count)
    {
        if (start < 0 || start >= value.Length)
        {
            throw new ArgumentOutOfRangeException(nameof(start));
        }

        if (count < 0 || start + count >= value.Length)
        {
            throw new ArgumentOutOfRangeException(nameof(count));
        }

        if (ContainsInnerComment(value, start, count))
        {
            return false;
        }

        AppendToCommentValueUnchecked(value, start, count);
        return true;
    }

    public bool AppendToCommentValue(IBuffer value)
    {
        if (ContainsInnerComment(value))
        {
            return false;
        }

        AppendToCommentValueUnchecked(value, 0, value.Length);
        return true;
    }

    public bool AppendToCommentValue(IBuffer value, int start)
    {
        if (start < 0 || start >= value.Length)
        {
            throw new ArgumentOutOfRangeException(nameof(start));
        }

        if (ContainsInnerComment(value, start))
        {
            return false;
        }

        AppendToCommentValueUnchecked(value, start, value.Length - start);
        return true;
    }

    public bool AppendToCommentValue(IBuffer value, int start, int count)
    {
        if (start < 0 || start >= value.Length)
        {
            throw new ArgumentOutOfRangeException(nameof(start));
        }

        if (count < 0 || start + count >= value.Length)
        {
            throw new ArgumentOutOfRangeException(nameof(count));
        }

        if (ContainsInnerComment(value, start, count))
        {
            return false;
        }

        AppendToCommentValueUnchecked(value, start, count);
        return true;
    }

    public bool AppendToCommentValue(ReadOnlySpan<char> value)
    {
        if (ContainsInnerComment(value))
        {
            return false;
        }

        AppendToCommentValueUnchecked(ref value);
        return true;
    }

    public bool AppendToCommentValue(ReadOnlySpan<char> value, int start)
    {
        if (start < 0 || start >= value.Length)
        {
            throw new ArgumentOutOfRangeException(nameof(start));
        }

        if (ContainsInnerComment(value, start))
        {
            return false;
        }

        AppendToCommentValueUnchecked(ref value, start, value.Length - start);
        return true;
    }

    public bool AppendToCommentValue(ReadOnlySpan<char> value, int start, int count)
    {
        if (start < 0 || start >= value.Length)
        {
            throw new ArgumentOutOfRangeException(nameof(start));
        }

        if (count < 0 || start + count >= value.Length)
        {
            throw new ArgumentOutOfRangeException(nameof(count));
        }

        if (ContainsInnerComment(value, start, count))
        {
            return false;
        }

        AppendToCommentValueUnchecked(ref value, start, count);
        return true;
    }

    protected void AppendToCommentValueUnchecked(StringBuilder value, int start = 0)
    {
        AppendToCommentValueUnchecked(value, start, value.Length - start);
    }

    protected void AppendToCommentValueUnchecked(StringBuilder value, int start, int count)
    {
        for (int i = start; i < count; i++)
        {
            UnderlyingBuffer.Insert(UnderlyingBuffer.Length, value[i].ToString());
        }

        CascadeTextOffsetChange(count);
    }

    protected void AppendToCommentValueUnchecked(string value, int start = 0)
    {
        AppendToCommentValueUnchecked(value, start, value.Length - start);
    }

    protected void AppendToCommentValueUnchecked(string value, int start, int count)
    {
        for (int i = start; i < count; i++)
        {
            UnderlyingBuffer.Insert(UnderlyingBuffer.Length, value[i].ToString());
        }

        CascadeTextOffsetChange(count);
    }

    protected void AppendToCommentValueUnchecked(IBuffer value, int start = 0)
    {
        AppendToCommentValueUnchecked(value, start, value.Length - start);
    }

    protected void AppendToCommentValueUnchecked(IBuffer buffer, int start, int count)
    {
        for (int i = start; i < count; i++)
        {
            UnderlyingBuffer.Insert(UnderlyingBuffer.Length, buffer[i].ToString());
        }
        
        CascadeTextOffsetChange(count);
    }

    protected void AppendToCommentValueUnchecked(ref ReadOnlySpan<char> value, int start = 0)
    {
        AppendToCommentValueUnchecked(ref value, start, value.Length - start);
    }

    protected void AppendToCommentValueUnchecked(ref ReadOnlySpan<char> value, int start, int count)
    {
        for (int i = start; i < count; i++)
        {
            UnderlyingBuffer.Insert(UnderlyingBuffer.Length, value[i].ToString());
        }
        
        CascadeTextOffsetChange(count);
    }

    public bool PrependToCommentValue(StringBuilder value)
    {
        return InsertInCommentValue(0, value);
    }

    public bool PrependToCommentValue(StringBuilder value, int start)
    {
        return InsertInCommentValue(0, value, start);
    }

    public bool PrependToCommentValue(StringBuilder value, int start, int count)
    {
        return InsertInCommentValue(0, value, start, count);
    }

    public bool PrependToCommentValue(string value)
    {
        return InsertInCommentValue(0, value);
    }

    public bool PrependToCommentValue(string value, int start)
    {
        return InsertInCommentValue(0, value, start);
    }

    public bool PrependToCommentValue(string value, int start, int count)
    {
        return InsertInCommentValue(0, value, start, count);
    }

    public bool PrependToCommentValue(IBuffer value)
    {
        return InsertInCommentValue(0, value);
    }

    public bool PrependToCommentValue(IBuffer value, int start)
    {
        return InsertInCommentValue(0, value, start);
    }

    public bool PrependToCommentValue(IBuffer value, int start, int count)
    {
        return InsertInCommentValue(0, value, start, count);
    }

    public bool PrependToCommentValue(ReadOnlySpan<char> value)
    {
        return InsertInCommentValue(0, value);
    }

    public bool PrependToCommentValue(ReadOnlySpan<char> value, int start)
    {
        return InsertInCommentValue(0, value, start);
    }

    public bool PrependToCommentValue(ReadOnlySpan<char> value, int start, int count)
    {
        return InsertInCommentValue(0, value, start, count);
    }

    public bool InsertInCommentValue(int index, StringBuilder insertion)
    {
        if (index < 0 || index > UnderlyingBuffer.Length)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }
        else if (index == UnderlyingBuffer.Length)
        {
            return AppendToCommentValue(insertion);
        }

        if (ContainsInnerComment(insertion))
        {
            return false;
        }

        InsertInCommentValueUnchecked(index, insertion);
        return true;
    }

    public bool InsertInCommentValue(int index, StringBuilder insertion, int start)
    {
        if (index < 0 || index > UnderlyingBuffer.Length)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }
        else if (index == UnderlyingBuffer.Length)
        {
            return AppendToCommentValue(insertion);
        }

        if (start < 0 || start > UnderlyingBuffer.Length)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        if (ContainsInnerComment(insertion))
        {
            return false;
        }

        InsertInCommentValueUnchecked(index, insertion, start);
        return true;
    }

    public bool InsertInCommentValue(int index, StringBuilder insertion, int start, int count)
    {
        if (index < 0 || index > UnderlyingBuffer.Length)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }
        else if (index == UnderlyingBuffer.Length)
        {
            return AppendToCommentValue(insertion);
        }

        if (start < 0 || start > UnderlyingBuffer.Length)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        if (count < 0 || start + count > UnderlyingBuffer.Length)
        {
            throw new ArgumentOutOfRangeException(nameof(count));
        }

        if (ContainsInnerComment(insertion))
        {
            return false;
        }

        InsertInCommentValueUnchecked(index, insertion, start, count);
        return true;
    }

    public bool InsertInCommentValue(int index, string insertion)
    {
        if (index < 0 || index > UnderlyingBuffer.Length)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }
        else if (index == UnderlyingBuffer.Length)
        {
            return AppendToCommentValue(insertion);
        }

        if (ContainsInnerComment(insertion))
        {
            return false;
        }

        InsertInCommentValueUnchecked(index, insertion);
        return true;
    }

    public bool InsertInCommentValue(int index, string insertion, int start)
    {
        if (index < 0 || index > UnderlyingBuffer.Length)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }
        else if (index == UnderlyingBuffer.Length)
        {
            return AppendToCommentValue(insertion);
        }

        if (start < 0 || start > UnderlyingBuffer.Length)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        if (ContainsInnerComment(insertion))
        {
            return false;
        }

        InsertInCommentValueUnchecked(index, insertion, start);
        return true;
    }

    public bool InsertInCommentValue(int index, string insertion, int start, int count)
    {
        if (index < 0 || index > UnderlyingBuffer.Length)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }
        else if (index == UnderlyingBuffer.Length)
        {
            return AppendToCommentValue(insertion);
        }

        if (start < 0 || start > UnderlyingBuffer.Length)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        if (count < 0 || start + count > UnderlyingBuffer.Length)
        {
            throw new ArgumentOutOfRangeException(nameof(count));
        }

        if (ContainsInnerComment(insertion))
        {
            return false;
        }

        InsertInCommentValueUnchecked(index, insertion, start, count);
        return true;
    }

    public bool InsertInCommentValue(int index, IBuffer insertion)
    {
        if (index < 0 || index > UnderlyingBuffer.Length)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }
        else if (index == UnderlyingBuffer.Length)
        {
            return AppendToCommentValue(insertion);
        }

        if (ContainsInnerComment(insertion))
        {
            return false;
        }

        InsertInCommentValueUnchecked(index, insertion);

        return true;
    }

    public bool InsertInCommentValue(int index, IBuffer insertion, int start)
    {
        if (index < 0 || index > UnderlyingBuffer.Length)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }
        else if (index == UnderlyingBuffer.Length)
        {
            return AppendToCommentValue(insertion);
        }

        if (start < 0 || start > UnderlyingBuffer.Length)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        if (ContainsInnerComment(insertion))
        {
            return false;
        }

        InsertInCommentValueUnchecked(index, insertion, start);
        return true;
    }

    public bool InsertInCommentValue(int index, IBuffer insertion, int start, int count)
    {
        if (index < 0 || index > UnderlyingBuffer.Length)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }
        else if (index == UnderlyingBuffer.Length)
        {
            return AppendToCommentValue(insertion);
        }

        if (start < 0 || start > UnderlyingBuffer.Length)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        if (count < 0 || start + count > UnderlyingBuffer.Length)
        {
            throw new ArgumentOutOfRangeException(nameof(count));
        }

        if (ContainsInnerComment(insertion))
        {
            return false;
        }

        InsertInCommentValueUnchecked(index, insertion, start, count);
        return true;
    }

    public bool InsertInCommentValue(int index, ReadOnlySpan<char> insertion)
    {
        if (index < 0 || index > UnderlyingBuffer.Length)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }
        else if (index == UnderlyingBuffer.Length)
        {
            return AppendToCommentValue(insertion);
        }

        if (ContainsInnerComment(insertion))
        {
            return false;
        }

        InsertInCommentValueUnchecked(index, ref insertion);

        return true;
    }

    public bool InsertInCommentValue(int index, ReadOnlySpan<char> insertion, int start)
    {
        if (index < 0 || index > UnderlyingBuffer.Length)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }
        else if (index == UnderlyingBuffer.Length)
        {
            return AppendToCommentValue(insertion);
        }

        if (start < 0 || start > UnderlyingBuffer.Length)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        if (ContainsInnerComment(insertion))
        {
            return false;
        }

        InsertInCommentValueUnchecked(index, ref insertion, start);
        return true;
    }

    public bool InsertInCommentValue(int index, ReadOnlySpan<char> insertion, int start, int count)
    {
        if (index < 0 || index > UnderlyingBuffer.Length)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }
        else if (index == UnderlyingBuffer.Length)
        {
            return AppendToCommentValue(insertion);
        }

        if (start < 0 || start > UnderlyingBuffer.Length)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        if (count < 0 || start + count > UnderlyingBuffer.Length)
        {
            throw new ArgumentOutOfRangeException(nameof(count));
        }

        if (ContainsInnerComment(insertion))
        {
            return false;
        }

        InsertInCommentValueUnchecked(index, ref insertion, start, count);
        return true;
    }

    protected void InsertInCommentValueUnchecked(int index, StringBuilder insertion, int start = 0)
    {
        InsertInCommentValueUnchecked(index, insertion, start, insertion.Length - start);
    }

    protected void InsertInCommentValueUnchecked(int index, StringBuilder insertion, int start, int count)
    {
        for (int i = start; i < count; i++)
        {
            UnderlyingBuffer.Insert(index + i, insertion[i].ToString());
        }
        
        CascadeTextOffsetChange(count);
    }

    protected void InsertInCommentValueUnchecked(int index, string insertion, int start = 0)
    {
        InsertInCommentValueUnchecked(index, insertion, start, insertion.Length - start);
    }

    protected void InsertInCommentValueUnchecked(int index, string insertion, int start, int count)
    {
        for (int i = start; i < count; i++)
        {
            UnderlyingBuffer.Insert(index + i, insertion[i].ToString());
        }
        
        CascadeTextOffsetChange(count);
    }

    protected void InsertInCommentValueUnchecked(int index, IBuffer insertion, int start = 0)
    {
        InsertInCommentValueUnchecked(index, insertion, start, insertion.Length - start);
    }

    protected void InsertInCommentValueUnchecked(int index, IBuffer insertion, int start, int count)
    {
        for (int i = start; i < count; i++)
        {
            UnderlyingBuffer.Insert(index + i, insertion[i].ToString());
        }
        
        CascadeTextOffsetChange(count);
    }

    protected void InsertInCommentValueUnchecked(int index, ref ReadOnlySpan<char> insertion, int start = 0)
    {
        InsertInCommentValueUnchecked(index, ref insertion, start, insertion.Length - start);
    }

    protected void InsertInCommentValueUnchecked(int index, ref ReadOnlySpan<char> insertion, int start, int count)
    {
        for (int i = start; i < count; i++)
        {
            UnderlyingBuffer.Insert(index + i, insertion[i].ToString());
        }
        
        CascadeTextOffsetChange(count);
    }

    public bool ReplaceInCommentValue(int index, StringBuilder replacement, bool extend = false)
    {
        if (index < 0 || index > UnderlyingBuffer.Length)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        if (ContainsInnerComment(replacement))
        {
            return false;
        }

        ReplaceInCommentValueUnchecked(index, replacement, extend: extend);
        return true;
    }

    public bool ReplaceInCommentValue(int index, StringBuilder replacement, int replacementStart, bool extend = false)
    {
        if (index < 0 || index > UnderlyingBuffer.Length)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        if (replacementStart < 0 || replacementStart > replacement.Length)
        {
            throw new ArgumentOutOfRangeException(nameof(replacementStart));
        }

        if (ContainsInnerComment(replacement, replacementStart))
        {
            return false;
        }

        ReplaceInCommentValueUnchecked(index, replacement, replacementStart, extend);
        return true;
    }

    public bool ReplaceInCommentValue(int index, StringBuilder replacement, int replacementStart, int replacementLength, bool extend = false)
    {
        if (index < 0 || index > UnderlyingBuffer.Length)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        if (replacementStart < 0 || replacementStart > replacement.Length)
        {
            throw new ArgumentOutOfRangeException(nameof(replacementStart));
        }

        if (replacementLength < 0 || replacementStart + replacementLength > replacement.Length)
        {
            throw new ArgumentOutOfRangeException(nameof(replacementLength));
        }

        if (ContainsInnerComment(replacement, replacementStart, replacementLength))
        {
            return false;
        }

        ReplaceInCommentValueUnchecked(index, replacement, replacementStart, replacementLength, extend);
        return true;
    }

    public bool ReplaceInCommentValue(int index, string replacement, bool extend = false)
    {
        if (index < 0 || index > UnderlyingBuffer.Length)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        if (ContainsInnerComment(replacement))
        {
            return false;
        }

        ReplaceInCommentValueUnchecked(index, replacement, extend: extend);
        return true;
    }

    public bool ReplaceInCommentValue(int index, string replacement, int replacementStart, bool extend = false)
    {
        if (index < 0 || index > UnderlyingBuffer.Length)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        if (replacementStart < 0 || replacementStart > replacement.Length)
        {
            throw new ArgumentOutOfRangeException(nameof(replacementStart));
        }

        if (ContainsInnerComment(replacement, replacementStart))
        {
            return false;
        }

        ReplaceInCommentValueUnchecked(index, replacement, replacementStart, extend);
        return true;
    }

    public bool ReplaceInCommentValue(int index, string replacement, int replacementStart, int replacementLength, bool extend = false)
    {
        if (index < 0 || index > UnderlyingBuffer.Length)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        if (replacementStart < 0 || replacementStart > replacement.Length)
        {
            throw new ArgumentOutOfRangeException(nameof(replacementStart));
        }

        if (replacementLength < 0 || replacementStart + replacementLength > replacement.Length)
        {
            throw new ArgumentOutOfRangeException(nameof(replacementLength));
        }

        if (ContainsInnerComment(replacement, replacementStart, replacementLength))
        {
            return false;
        }

        ReplaceInCommentValueUnchecked(index, replacement, replacementStart, replacementLength, extend);
        return true;
    }

    public bool ReplaceInCommentValue(int index, IBuffer replacement, bool extend = false)
    {
        if (index < 0 || index > UnderlyingBuffer.Length)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        if (ContainsInnerComment(replacement))
        {
            return false;
        }

        ReplaceInCommentValueUnchecked(index, replacement, extend: extend);
        return true;
    }

    public bool ReplaceInCommentValue(int index, IBuffer replacement, int replacementStart, bool extend = false)
    {
        if (index < 0 || index > UnderlyingBuffer.Length)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        if (replacementStart < 0 || replacementStart > replacement.Length)
        {
            throw new ArgumentOutOfRangeException(nameof(replacementStart));
        }

        if (ContainsInnerComment(replacement, replacementStart))
        {
            return false;
        }

        ReplaceInCommentValueUnchecked(index, replacement, replacementStart, extend);
        return true;
    }

    public bool ReplaceInCommentValue(int index, IBuffer replacement, int replacementStart, int replacementLength, bool extend = false)
    {
        if (index < 0 || index > UnderlyingBuffer.Length)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        if (replacementStart < 0 || replacementStart > replacement.Length)
        {
            throw new ArgumentOutOfRangeException(nameof(replacementStart));
        }

        if (replacementLength < 0 || replacementStart + replacementLength > replacement.Length)
        {
            throw new ArgumentOutOfRangeException(nameof(replacementLength));
        }

        if (ContainsInnerComment(replacement, replacementStart, replacementLength))
        {
            return false;
        }

        ReplaceInCommentValueUnchecked(index, replacement, replacementStart, replacementLength, extend);
        return true;
    }


    public bool ReplaceInCommentValue(int index, ReadOnlySpan<char> replacement, bool extend = false)
    {
        if (index < 0 || index > UnderlyingBuffer.Length)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        if (ContainsInnerComment(replacement))
        {
            return false;
        }

        ReplaceInCommentValueUnchecked(index, ref replacement, extend: extend);
        return true;
    }

    public bool ReplaceInCommentValue(int index, ReadOnlySpan<char> replacement, int replacementStart, bool extend = false)
    {
        if (index < 0 || index > UnderlyingBuffer.Length)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        if (replacementStart < 0 || replacementStart > replacement.Length)
        {
            throw new ArgumentOutOfRangeException(nameof(replacementStart));
        }

        if (ContainsInnerComment(replacement, replacementStart))
        {
            return false;
        }

        ReplaceInCommentValueUnchecked(index, ref replacement, replacementStart, extend);
        return true;
    }

    public bool ReplaceInCommentValue(int index, ReadOnlySpan<char> replacement, int replacementStart, int replacementLength, bool extend = false)
    {
        if (index < 0 || index > UnderlyingBuffer.Length)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        if (replacementStart < 0 || replacementStart > replacement.Length)
        {
            throw new ArgumentOutOfRangeException(nameof(replacementStart));
        }

        if (replacementLength < 0 || replacementStart + replacementLength > replacement.Length)
        {
            throw new ArgumentOutOfRangeException(nameof(replacementLength));
        }

        if (ContainsInnerComment(replacement, replacementStart, replacementLength))
        {
            return false;
        }

        ReplaceInCommentValueUnchecked(index, ref replacement, replacementStart, replacementLength, extend);
        return true;
    }

    protected void ReplaceInCommentValueUnchecked(int index, StringBuilder replacement, int replacementStart = 0, bool extend = false)
    {
        ReplaceInCommentValueUnchecked(index, replacement, replacementStart, replacement.Length - replacementStart, extend);
    }

    protected void ReplaceInCommentValueUnchecked(int index, StringBuilder replacement, int replacementStart, int replacementLength, bool extend)
    {
        int target = Math.Min(replacementLength, UnderlyingBuffer.Length - index);
        int originalLength = CommentValueLength;

        for (int i = 0; i < target; i++)
        {
            UnderlyingBuffer.Replace(index++, 1, replacement[replacementStart++].ToString());
        }

        if (!extend)
        {
            CascadeTextOffsetChange(originalLength - replacementLength);
            return;
        }

        for (int i = target; i < replacementLength; i++)
        {
            UnderlyingBuffer.Insert(UnderlyingBuffer.Length, replacement[replacementStart++].ToString());
        }
        
        CascadeTextOffsetChange(replacementLength - originalLength);
    }

    protected void ReplaceInCommentValueUnchecked(int index, string replacement, int replacementStart = 0, bool extend = false)
    {
        ReplaceInCommentValueUnchecked(index, replacement, replacementStart, replacement.Length - replacementStart, extend);
    }

    protected void ReplaceInCommentValueUnchecked(int index, string replacement, int replacementStart, int replacementLength, bool extend)
    {
        int target = Math.Min(replacementLength, UnderlyingBuffer.Length - index);
        int originalLength = CommentValueLength;

        for (int i = 0; i < target; i++)
        {
            UnderlyingBuffer.Replace(index++, 1, replacement[replacementStart++].ToString());
        }

        if (!extend)
        {
            CascadeTextOffsetChange(originalLength - replacementLength);
            return;
        }

        for (int i = target; i < replacementLength; i++)
        {
            UnderlyingBuffer.Insert(UnderlyingBuffer.Length, replacement[replacementStart++].ToString());
        }
        
        CascadeTextOffsetChange(replacementLength - originalLength);
    }

    protected void ReplaceInCommentValueUnchecked(int index, IBuffer replacement, int replacementStart = 0, bool extend = false)
    {
        ReplaceInCommentValueUnchecked(index, replacement, replacementStart, replacement.Length - replacementStart, extend);
    }

    protected void ReplaceInCommentValueUnchecked(int index, IBuffer replacement, int replacementStart, int replacementLength, bool extend)
    {
        int target = Math.Min(replacementLength, UnderlyingBuffer.Length - index);
        int originalLength = CommentValueLength;

        for (int i = 0; i < target; i++)
        {
            UnderlyingBuffer.Replace(index++, 1, replacement[replacementStart++].ToString());
        }

        if (!extend)
        {
            CascadeTextOffsetChange(originalLength - replacementLength);
            return;
        }

        for (int i = target; i < replacementLength; i++)
        {
            UnderlyingBuffer.Insert(UnderlyingBuffer.Length, replacement[replacementStart++].ToString());
        }
        
        CascadeTextOffsetChange(replacementLength - originalLength);
    }

    protected void ReplaceInCommentValueUnchecked(int index, ref ReadOnlySpan<char> replacement, int replacementStart = 0, bool extend = false)
    {
        ReplaceInCommentValueUnchecked(index, ref replacement, replacementStart, replacement.Length - replacementStart, extend);
    }

    protected void ReplaceInCommentValueUnchecked(int index, ref ReadOnlySpan<char> replacement, int replacementStart, int replacementLength,
        bool extend)
    {
        int target = Math.Min(replacementLength, UnderlyingBuffer.Length - index);
        int originalLength = CommentValueLength;

        for (int i = 0; i < target; i++)
        {
            UnderlyingBuffer.Replace(index++, 1, replacement[replacementStart++].ToString());
        }

        if (!extend)
        {
            CascadeTextOffsetChange(originalLength - replacementLength);
            return;
        }

        for (int i = target; i < replacementLength; i++)
        {
            UnderlyingBuffer.Insert(UnderlyingBuffer.Length, replacement[replacementStart++].ToString());
        }
        
        CascadeTextOffsetChange(replacementLength - originalLength);
    }

    public bool RemoveInCommentValue(int index, int length = 1)
    {
        if (length < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(length));
        }

        if (index < 0 || index + length >= UnderlyingBuffer.Length)
        {
            return false;
        }

        UnderlyingBuffer.Remove(index, length);
        CascadeTextOffsetChange(-length);

        return true;
    }

    public List<int> RemoveInCommentValueWhere(Func<int, char, bool> predicate)
    {
        List<int> removedLocations = [];
        int numberOfRemoved = 0;

        for (int i = 0; i < UnderlyingBuffer.Length; i++)
        {
            int relativeIndex = i;
            if (!predicate(relativeIndex, Buffer[i]))
            {
                continue;
            }

            UnderlyingBuffer.Remove(i, 1);
            removedLocations.Add(relativeIndex);
            numberOfRemoved++;
        }
        
        CascadeTextOffsetChange(-numberOfRemoved);
        return removedLocations;
    }

    public void ClearCommentValue()
    {
        int originalLength = CommentValueLength;
        UnderlyingBuffer.Remove(0, UnderlyingBuffer.Length);
        
        CascadeTextOffsetChange(-originalLength);
    }

    public bool Contains(char character)
    {
        if (character is SwiftLexer.LineFeed or SwiftLexer.CarriageReturn)
        {
            return false;
        }

        for (int i = 0; i < UnderlyingBuffer.Length; i++)
        {
            if (character == Buffer[i])
            {
                return true;
            }
        }

        return false;
    }

    public bool Contains(Func<char, bool> predicate)
    {
        for (int i = 0; i < UnderlyingBuffer.Length; i++)
        {
            if (predicate(Buffer[i]))
            {
                return true;
            }
        }

        return false;
    }

    public bool Contains(Func<int, char, bool> predicate)
    {
        for (int i = 0; i < UnderlyingBuffer.Length; i++)
        {
            if (predicate(i, Buffer[i]))
            {
                return true;
            }
        }

        return false;
    }

    protected static bool ContainsInnerComment(StringBuilder value, int start = 0)
    {
        return ContainsInnerComment(value, start, value.Length);
    }

    protected static bool ContainsInnerComment(StringBuilder value, int start, int count)
    {
        for (int index = start; index < count; index++)
        {
            char character = value[index];
            if (character is SwiftLexer.LineFeed or SwiftLexer.CarriageReturn)
            {
                return true;
            }
        }

        return false;
    }

    protected static bool ContainsInnerComment(string value, int start = 0)
    {
        return ContainsInnerComment(value, start, value.Length);
    }

    protected static bool ContainsInnerComment(string value, int start, int count)
    {
        for (int index = start; index < count; index++)
        {
            char character = value[index];
            if (character is SwiftLexer.LineFeed or SwiftLexer.CarriageReturn)
            {
                return true;
            }
        }

        return false;
    }

    protected static bool ContainsInnerComment(IBuffer value, int start = 0)
    {
        return ContainsInnerComment(value, start, value.Length);
    }

    protected static bool ContainsInnerComment(IBuffer buffer, int start, int count)
    {
        for (int i = start; i < count - 1; i++)
        {
            char character = buffer[i];
            if (character is SwiftLexer.Slash && buffer[i + 1] is SwiftLexer.Slash or SwiftLexer.Star)
            {
                return true;
            }
        }

        return false;
    }

    protected static bool ContainsInnerComment(ReadOnlySpan<char> value, int start = 0)
    {
        return ContainsInnerComment(value, start, value.Length);
    }

    protected static bool ContainsInnerComment(ReadOnlySpan<char> span, int start, int count)
    {
        for (int index = start; index < count - 1; index++)
        {
            char character = span[index];
            if (character is SwiftLexer.Slash && span[index + 1] is SwiftLexer.Slash or SwiftLexer.Star)
            {
                return true;
            }
        }

        return false;
    }

    public IEnumerator<char> GetEnumerator()
    {
        return new Enumerator(this);
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public sealed class Enumerator : IEnumerator<char>
    {
        private const int StartIndex = -1;

        private readonly BlockCommentContentNode _blockContentNode;

        private int _index = StartIndex;

        internal Enumerator(BlockCommentContentNode blockContentNode)
        {
            _blockContentNode = blockContentNode;
        }

        public bool MoveNext()
        {
            if (_index >= _blockContentNode.UnderlyingBuffer.Length)
            {
                return false;
            }

            _index++;
            return true;
        }

        public void Reset()
        {
            _index = StartIndex;
        }

        public char Current => _blockContentNode.Buffer[_index];

        object IEnumerator.Current => Current;

        public void Dispose()
        {
            // Nothing to dispose
        }
    }

    public new SwiftCompositeNode CloneAsDetached()
    {
        throw new NotImplementedException();
    }

    public new SwiftCompositeNode CloneAsAttachedTo(SwiftCompositeNode newParent, int index)
    {
        throw new NotImplementedException();
    }
}