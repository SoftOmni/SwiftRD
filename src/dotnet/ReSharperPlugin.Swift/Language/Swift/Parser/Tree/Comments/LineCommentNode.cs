using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using JetBrains.DocumentModel.Impl;
using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Parser.Lexer;
using ReSharperPlugin.Swift.Language.Parser.Tree.Base.InternalNode;

// ReSharper disable RedundantIfElseBlock

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Comments;

public class LineCommentNode : SwiftLeafNode, ICommentNode
{
    public LineCommentNode(IEditableBuffer buffer)
        : base(buffer, NodeTypes.NodeTypes.LineComment)
    { }

    public LineCommentNode(SwiftInternalNode parent, IEditableBuffer buffer)
        : base(parent, buffer, NodeTypes.NodeTypes.LineComment)
    { }

    public static LineCommentNode CreateCommentFromValue(string value)
    {
        return new LineCommentNode(new EditableBuffer("//" + value));
    }

    public static LineCommentNode CreateCommentFromValue(IEditableBuffer value)
    {
        value.Insert(0, "//");
        return new LineCommentNode(value);
    }

    public int CommentValueLength => EditableBuffer.Length - 2;

    public string GetCommentValue()
    {
        return EditableBuffer.ToString();
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
            builder.Append(Buffer[i + 2]);
        }

        return builder.ToString();
    }
    
    public ReadOnlySpan<char> AsCommentValue()
    {
        EditableBuffer.TryGetReadOnlySpan(out ReadOnlySpan<char> span);
        return span.Slice(2);
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
        
        EditableBuffer.TryGetReadOnlySpan(out ReadOnlySpan<char> span);
        return span.Slice(2 + start, 2 + start + length);
    }

    public bool SetCommentValue(StringBuilder value)
    {
        if (ContainsNewLine(value))
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

        if (ContainsNewLine(value))
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

        if (ContainsNewLine(value))
        {
            return false;
        }

        SetCommentValueUnchecked(value, start, count);
        return true;
    }

    public bool SetCommentValue(string value)
    {
        if (ContainsNewLine(value))
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

        if (ContainsNewLine(value, start))
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

        if (ContainsNewLine(value, start, count))
        {
            return false;
        }

        SetCommentValueUnchecked(value, start, count);
        return true;
    }

    public bool SetCommentValue(IBuffer value)
    {
        if (ContainsNewLine(value))
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

        if (ContainsNewLine(value, start))
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

        if (ContainsNewLine(value, start, count))
        {
            return false;
        }

        SetCommentValueUnchecked(value, start, count);
        return true;
    }

    public bool SetCommentValue(ReadOnlySpan<char> value)
    {
        if (ContainsNewLine(value))
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

        if (ContainsNewLine(value, start))
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

        if (ContainsNewLine(value, start, count))
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
        int commentTarget = Math.Min(count, CommentValueLength);

        for (int i = 0; i < commentTarget; i++)
        {
            EditableBuffer.Replace(i + 2, 1, value[start + i].ToString());
        }

        for (int i = commentTarget; i < count; i++)
        {
            EditableBuffer.Insert(i + 2, value[start + i].ToString());
        }

        if (CommentValueLength > count)
        {
            EditableBuffer.Remove(EditableBuffer.Length, CommentValueLength - count);
        }
    }

    protected void SetCommentValueUnchecked(string value, int start = 0)
    {
        SetCommentValueUnchecked(value, start, value.Length - start);
    }

    protected void SetCommentValueUnchecked(string value, int start, int count)
    {
        int commentTarget = Math.Min(count, CommentValueLength);

        for (int i = 0; i < commentTarget; i++)
        {
            EditableBuffer.Replace(i + 2, 1, value[start + i].ToString());
        }

        for (int i = commentTarget; i < count; i++)
        {
            EditableBuffer.Insert(i + 2, value[start + i].ToString());
        }

        if (CommentValueLength > count)
        {
            EditableBuffer.Remove(EditableBuffer.Length, CommentValueLength - count);
        }
    }

    protected void SetCommentValueUnchecked(IBuffer value, int start = 0)
    {
        SetCommentValueUnchecked(value, start, value.Length - start);
    }

    protected void SetCommentValueUnchecked(IBuffer value, int start, int count)
    {
        int commentTarget = Math.Min(count, CommentValueLength);

        for (int i = 0; i < commentTarget; i++)
        {
            EditableBuffer.Replace(i + 2, 1, value[start + i].ToString());
        }

        for (int i = commentTarget; i < count; i++)
        {
            EditableBuffer.Insert(i + 2, value[start + i].ToString());
        }

        if (CommentValueLength > count)
        {
            EditableBuffer.Remove(EditableBuffer.Length, CommentValueLength - count);
        }
    }

    protected void SetCommentValueUnchecked(ref ReadOnlySpan<char> value, int start = 0)
    {
        SetCommentValueUnchecked(ref value, start, value.Length - start);
    }

    protected void SetCommentValueUnchecked(ref ReadOnlySpan<char> value, int start, int count)
    {
        int commentTarget = Math.Min(count, CommentValueLength);

        for (int i = 0; i < commentTarget; i++)
        {
            EditableBuffer.Replace(i + 2, 1, value[start + i].ToString());
        }

        for (int i = commentTarget; i < count; i++)
        {
            EditableBuffer.Insert(i + 2, value[start + i].ToString());
        }

        if (CommentValueLength > count)
        {
            EditableBuffer.Remove(EditableBuffer.Length, CommentValueLength - count);
        }
    }

    public bool AppendToCommentValue(StringBuilder value)
    {
        if (ContainsNewLine(value))
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

        if (ContainsNewLine(value, start))
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

        if (ContainsNewLine(value, start, count))
        {
            return true;
        }

        AppendToCommentValueUnchecked(value, start, count);
        return true;
    }

    public bool AppendToCommentValue(string value)
    {
        if (ContainsNewLine(value))
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

        if (ContainsNewLine(value, start))
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

        if (ContainsNewLine(value, start, count))
        {
            return false;
        }

        AppendToCommentValueUnchecked(value, start, count);
        return true;
    }

    public bool AppendToCommentValue(IBuffer value)
    {
        if (ContainsNewLine(value))
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

        if (ContainsNewLine(value, start))
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

        if (ContainsNewLine(value, start, count))
        {
            return false;
        }

        AppendToCommentValueUnchecked(value, start, count);
        return true;
    }

    public bool AppendToCommentValue(ReadOnlySpan<char> value)
    {
        if (ContainsNewLine(value))
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

        if (ContainsNewLine(value, start))
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

        if (ContainsNewLine(value, start, count))
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
            EditableBuffer.Insert(EditableBuffer.Length, value[i].ToString());
        }
    }

    protected void AppendToCommentValueUnchecked(string value, int start = 0)
    {
        AppendToCommentValueUnchecked(value, start, value.Length - start);
    }

    protected void AppendToCommentValueUnchecked(string value, int start, int count)
    {
        for (int i = start; i < count; i++)
        {
            EditableBuffer.Insert(EditableBuffer.Length, value[i].ToString());
        }
    }

    protected void AppendToCommentValueUnchecked(IBuffer value, int start = 0)
    {
        AppendToCommentValueUnchecked(value, start, value.Length - start);
    }

    protected void AppendToCommentValueUnchecked(IBuffer buffer, int start, int count)
    {
        for (int i = start; i < count; i++)
        {
            EditableBuffer.Insert(EditableBuffer.Length, buffer[i].ToString());
        }
    }

    protected void AppendToCommentValueUnchecked(ref ReadOnlySpan<char> value, int start = 0)
    {
        AppendToCommentValueUnchecked(ref value, start, value.Length - start);
    }

    protected void AppendToCommentValueUnchecked(ref ReadOnlySpan<char> value, int start, int count)
    {
        for (int i = start; i < count; i++)
        {
            EditableBuffer.Insert(EditableBuffer.Length, value[i].ToString());
        }
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
        if (index < 0 || index > CommentValueLength)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }
        else if (index == CommentValueLength)
        {
            return AppendToCommentValue(insertion);
        }

        if (ContainsNewLine(insertion))
        {
            return false;
        }

        InsertInCommentValueUnchecked(index, insertion);
        return true;
    }

    public bool InsertInCommentValue(int index, StringBuilder insertion, int start)
    {
        if (index < 0 || index > CommentValueLength)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }
        else if (index == CommentValueLength)
        {
            return AppendToCommentValue(insertion);
        }

        if (start < 0 || start > CommentValueLength)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        if (ContainsNewLine(insertion))
        {
            return false;
        }

        InsertInCommentValueUnchecked(index, insertion, start);
        return true;
    }

    public bool InsertInCommentValue(int index, StringBuilder insertion, int start, int count)
    {
        if (index < 0 || index > CommentValueLength)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }
        else if (index == CommentValueLength)
        {
            return AppendToCommentValue(insertion);
        }

        if (start < 0 || start > CommentValueLength)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        if (count < 0 || start + count > CommentValueLength)
        {
            throw new ArgumentOutOfRangeException(nameof(count));
        }

        if (ContainsNewLine(insertion))
        {
            return false;
        }

        InsertInCommentValueUnchecked(index, insertion, start, count);
        return true;
    }

    public bool InsertInCommentValue(int index, string insertion)
    {
        if (index < 0 || index > CommentValueLength)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }
        else if (index == CommentValueLength)
        {
            return AppendToCommentValue(insertion);
        }

        if (ContainsNewLine(insertion))
        {
            return false;
        }

        InsertInCommentValueUnchecked(index, insertion);
        return true;
    }

    public bool InsertInCommentValue(int index, string insertion, int start)
    {
        if (index < 0 || index > CommentValueLength)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }
        else if (index == CommentValueLength)
        {
            return AppendToCommentValue(insertion);
        }

        if (start < 0 || start > CommentValueLength)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        if (ContainsNewLine(insertion))
        {
            return false;
        }

        InsertInCommentValueUnchecked(index, insertion, start);
        return true;
    }

    public bool InsertInCommentValue(int index, string insertion, int start, int count)
    {
        if (index < 0 || index > CommentValueLength)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }
        else if (index == CommentValueLength)
        {
            return AppendToCommentValue(insertion);
        }

        if (start < 0 || start > CommentValueLength)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        if (count < 0 || start + count > CommentValueLength)
        {
            throw new ArgumentOutOfRangeException(nameof(count));
        }

        if (ContainsNewLine(insertion))
        {
            return false;
        }

        InsertInCommentValueUnchecked(index, insertion, start, count);
        return true;
    }

    public bool InsertInCommentValue(int index, IBuffer insertion)
    {
        if (index < 0 || index > CommentValueLength)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }
        else if (index == CommentValueLength)
        {
            return AppendToCommentValue(insertion);
        }

        if (ContainsNewLine(insertion))
        {
            return false;
        }

        InsertInCommentValueUnchecked(index, insertion);

        return true;
    }

    public bool InsertInCommentValue(int index, IBuffer insertion, int start)
    {
        if (index < 0 || index > CommentValueLength)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }
        else if (index == CommentValueLength)
        {
            return AppendToCommentValue(insertion);
        }

        if (start < 0 || start > CommentValueLength)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        if (ContainsNewLine(insertion))
        {
            return false;
        }

        InsertInCommentValueUnchecked(index, insertion, start);
        return true;
    }

    public bool InsertInCommentValue(int index, IBuffer insertion, int start, int count)
    {
        if (index < 0 || index > CommentValueLength)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }
        else if (index == CommentValueLength)
        {
            return AppendToCommentValue(insertion);
        }

        if (start < 0 || start > CommentValueLength)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        if (count < 0 || start + count > CommentValueLength)
        {
            throw new ArgumentOutOfRangeException(nameof(count));
        }

        if (ContainsNewLine(insertion))
        {
            return false;
        }

        InsertInCommentValueUnchecked(index, insertion, start, count);
        return true;
    }

    public bool InsertInCommentValue(int index, ReadOnlySpan<char> insertion)
    {
        if (index < 0 || index > CommentValueLength)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }
        else if (index == CommentValueLength)
        {
            return AppendToCommentValue(insertion);
        }

        if (ContainsNewLine(insertion))
        {
            return false;
        }

        InsertInCommentValueUnchecked(index, ref insertion);

        return true;
    }

    public bool InsertInCommentValue(int index, ReadOnlySpan<char> insertion, int start)
    {
        if (index < 0 || index > CommentValueLength)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }
        else if (index == CommentValueLength)
        {
            return AppendToCommentValue(insertion);
        }

        if (start < 0 || start > CommentValueLength)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        if (ContainsNewLine(insertion))
        {
            return false;
        }

        InsertInCommentValueUnchecked(index, ref insertion, start);
        return true;
    }

    public bool InsertInCommentValue(int index, ReadOnlySpan<char> insertion, int start, int count)
    {
        if (index < 0 || index > CommentValueLength)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }
        else if (index == CommentValueLength)
        {
            return AppendToCommentValue(insertion);
        }

        if (start < 0 || start > CommentValueLength)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        if (count < 0 || start + count > CommentValueLength)
        {
            throw new ArgumentOutOfRangeException(nameof(count));
        }

        if (ContainsNewLine(insertion))
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
            EditableBuffer.Insert(index + i, insertion[i].ToString());
        }
    }

    protected void InsertInCommentValueUnchecked(int index, string insertion, int start = 0)
    {
        InsertInCommentValueUnchecked(index, insertion, start, insertion.Length - start);
    }

    protected void InsertInCommentValueUnchecked(int index, string insertion, int start, int count)
    {
        for (int i = start; i < count; i++)
        {
            EditableBuffer.Insert(index + i, insertion[i].ToString());
        }
    }

    protected void InsertInCommentValueUnchecked(int index, IBuffer insertion, int start = 0)
    {
        InsertInCommentValueUnchecked(index, insertion, start, insertion.Length - start);
    }

    protected void InsertInCommentValueUnchecked(int index, IBuffer insertion, int start, int count)
    {
        for (int i = start; i < count; i++)
        {
            EditableBuffer.Insert(index + i, insertion[i].ToString());
        }
    }

    protected void InsertInCommentValueUnchecked(int index, ref ReadOnlySpan<char> insertion, int start = 0)
    {
        InsertInCommentValueUnchecked(index, ref insertion, start, insertion.Length - start);
    }

    protected void InsertInCommentValueUnchecked(int index, ref ReadOnlySpan<char> insertion, int start, int count)
    {
        for (int i = start; i < count; i++)
        {
            EditableBuffer.Insert(index + i, insertion[i].ToString());
        }
    }

    public bool ReplaceInCommentValue(int index, StringBuilder replacement, bool extend = false)
    {
        if (index < 0 || index > CommentValueLength)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        if (ContainsNewLine(replacement))
        {
            return false;
        }

        ReplaceInCommentValueUnchecked(index, replacement, extend: extend);
        return true;
    }

    public bool ReplaceInCommentValue(int index, StringBuilder replacement, int replacementStart, bool extend = false)
    {
        if (index < 0 || index > CommentValueLength)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        if (replacementStart < 0 || replacementStart > replacement.Length)
        {
            throw new ArgumentOutOfRangeException(nameof(replacementStart));
        }

        if (ContainsNewLine(replacement, replacementStart))
        {
            return false;
        }

        ReplaceInCommentValueUnchecked(index, replacement, replacementStart, extend);
        return true;
    }

    public bool ReplaceInCommentValue(int index, StringBuilder replacement, int replacementStart, int replacementLength,
        bool extend = false)
    {
        if (index < 0 || index > CommentValueLength)
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

        if (ContainsNewLine(replacement, replacementStart, replacementLength))
        {
            return false;
        }

        ReplaceInCommentValueUnchecked(index, replacement, replacementStart, replacementLength, extend);
        return true;
    }

    public bool ReplaceInCommentValue(int index, string replacement, bool extend = false)
    {
        if (index < 0 || index > CommentValueLength)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        if (ContainsNewLine(replacement))
        {
            return false;
        }

        ReplaceInCommentValueUnchecked(index, replacement, extend: extend);
        return true;
    }

    public bool ReplaceInCommentValue(int index, string replacement, int replacementStart, bool extend = false)
    {
        if (index < 0 || index > CommentValueLength)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        if (replacementStart < 0 || replacementStart > replacement.Length)
        {
            throw new ArgumentOutOfRangeException(nameof(replacementStart));
        }

        if (ContainsNewLine(replacement, replacementStart))
        {
            return false;
        }

        ReplaceInCommentValueUnchecked(index, replacement, replacementStart, extend);
        return true;
    }

    public bool ReplaceInCommentValue(int index, string replacement, int replacementStart,
        int replacementLength, bool extend = false)
    {
        if (index < 0 || index > CommentValueLength)
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

        if (ContainsNewLine(replacement, replacementStart, replacementLength))
        {
            return false;
        }

        ReplaceInCommentValueUnchecked(index, replacement, replacementStart, replacementLength, extend);
        return true;
    }

    public bool ReplaceInCommentValue(int index, IBuffer replacement, bool extend = false)
    {
        if (index < 0 || index > CommentValueLength)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        if (ContainsNewLine(replacement))
        {
            return false;
        }

        ReplaceInCommentValueUnchecked(index, replacement, extend: extend);
        return true;
    }

    public bool ReplaceInCommentValue(int index, IBuffer replacement, int replacementStart, bool extend = false)
    {
        if (index < 0 || index > CommentValueLength)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        if (replacementStart < 0 || replacementStart > replacement.Length)
        {
            throw new ArgumentOutOfRangeException(nameof(replacementStart));
        }

        if (ContainsNewLine(replacement, replacementStart))
        {
            return false;
        }

        ReplaceInCommentValueUnchecked(index, replacement, replacementStart, extend);
        return true;
    }

    public bool ReplaceInCommentValue(int index, IBuffer replacement, int replacementStart,
        int replacementLength, bool extend = false)
    {
        if (index < 0 || index > CommentValueLength)
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

        if (ContainsNewLine(replacement, replacementStart, replacementLength))
        {
            return false;
        }

        ReplaceInCommentValueUnchecked(index, replacement, replacementStart, replacementLength, extend);
        return true;
    }


    public bool ReplaceInCommentValue(int index, ReadOnlySpan<char> replacement, bool extend = false)
    {
        if (index < 0 || index > CommentValueLength)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        if (ContainsNewLine(replacement))
        {
            return false;
        }

        ReplaceInCommentValueUnchecked(index, ref replacement, extend: extend);
        return true;
    }

    public bool ReplaceInCommentValue(int index, ReadOnlySpan<char> replacement, int replacementStart,
        bool extend = false)
    {
        if (index < 0 || index > CommentValueLength)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        if (replacementStart < 0 || replacementStart > replacement.Length)
        {
            throw new ArgumentOutOfRangeException(nameof(replacementStart));
        }

        if (ContainsNewLine(replacement, replacementStart))
        {
            return false;
        }

        ReplaceInCommentValueUnchecked(index, ref replacement, replacementStart, extend);
        return true;
    }

    public bool ReplaceInCommentValue(int index, ReadOnlySpan<char> replacement, int replacementStart,
        int replacementLength, bool extend = false)
    {
        if (index < 0 || index > CommentValueLength)
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

        if (ContainsNewLine(replacement, replacementStart, replacementLength))
        {
            return false;
        }

        ReplaceInCommentValueUnchecked(index, ref replacement, replacementStart, replacementLength, extend);
        return true;
    }

    protected void ReplaceInCommentValueUnchecked(int index, StringBuilder replacement, int replacementStart = 0,
        bool extend = false)
    {
        ReplaceInCommentValueUnchecked(index, replacement, replacementStart, replacement.Length - replacementStart,
            extend);
    }

    protected void ReplaceInCommentValueUnchecked(int index, StringBuilder replacement, int replacementStart,
        int replacementLength,
        bool extend)
    {
        int target = Math.Min(replacementLength, CommentValueLength - index);

        for (int i = 0; i < target; i++)
        {
            EditableBuffer.Replace(index++, 1, replacement[replacementStart++].ToString());
        }

        if (!extend)
        {
            return;
        }

        for (int i = target; i < replacementLength; i++)
        {
            EditableBuffer.Insert(CommentValueLength, replacement[replacementStart++].ToString());
        }
    }

    protected void ReplaceInCommentValueUnchecked(int index, string replacement, int replacementStart = 0,
        bool extend = false)
    {
        ReplaceInCommentValueUnchecked(index, replacement, replacementStart, replacement.Length - replacementStart,
            extend);
    }

    protected void ReplaceInCommentValueUnchecked(int index, string replacement, int replacementStart,
        int replacementLength,
        bool extend)
    {
        int target = Math.Min(replacementLength, CommentValueLength - index);

        for (int i = 0; i < target; i++)
        {
            EditableBuffer.Replace(index++, 1, replacement[replacementStart++].ToString());
        }

        if (!extend)
        {
            return;
        }

        for (int i = target; i < replacementLength; i++)
        {
            EditableBuffer.Insert(CommentValueLength, replacement[replacementStart++].ToString());
        }
    }

    protected void ReplaceInCommentValueUnchecked(int index, IBuffer replacement, int replacementStart = 0,
        bool extend = false)
    {
        ReplaceInCommentValueUnchecked(index, replacement, replacementStart, replacement.Length - replacementStart,
            extend);
    }

    protected void ReplaceInCommentValueUnchecked(int index, IBuffer replacement, int replacementStart,
        int replacementLength,
        bool extend)
    {
        int target = Math.Min(replacementLength, CommentValueLength - index);

        for (int i = 0; i < target; i++)
        {
            EditableBuffer.Replace(index++, 1, replacement[replacementStart++].ToString());
        }

        if (!extend)
        {
            return;
        }

        for (int i = target; i < replacementLength; i++)
        {
            EditableBuffer.Insert(CommentValueLength, replacement[replacementStart++].ToString());
        }
    }

    protected void ReplaceInCommentValueUnchecked(int index, ref ReadOnlySpan<char> replacement,
        int replacementStart = 0,
        bool extend = false)
    {
        ReplaceInCommentValueUnchecked(index, ref replacement, replacementStart, replacement.Length - replacementStart,
            extend);
    }

    protected void ReplaceInCommentValueUnchecked(int index, ref ReadOnlySpan<char> replacement, int replacementStart,
        int replacementLength,
        bool extend)
    {
        int target = Math.Min(replacementLength, CommentValueLength - index);

        for (int i = 0; i < target; i++)
        {
            EditableBuffer.Replace(index++, 1, replacement[replacementStart++].ToString());
        }

        if (!extend)
        {
            return;
        }

        for (int i = target; i < replacementLength; i++)
        {
            EditableBuffer.Insert(CommentValueLength, replacement[replacementStart++].ToString());
        }
    }

    public bool RemoveInCommentValue(int index, int length = 1)
    {
        if (length < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(length));
        }

        if (index < 0 || index + length + 2 >= EditableBuffer.Length)
        {
            return false;
        }

        EditableBuffer.Remove(index, EditableBuffer.Length - index);

        return true;
    }

    public List<int> RemoveInCommentValueWhere(Func<int, char, bool> predicate)
    {
        List<int> removedLocations = [];

        for (int i = 2; i < EditableBuffer.Length; i++)
        {
            int relativeIndex = i - 2;
            if (!predicate(relativeIndex, Buffer[i]))
            {
                continue;
            }

            EditableBuffer.Remove(i, 1);
            removedLocations.Add(relativeIndex);
        }

        return removedLocations;
    }

    public void ClearCommentValue()
    {
        EditableBuffer.Remove(2, CommentValueLength);
    }

    public bool Contains(char character)
    {
        if (character is SwiftLexer.LineFeed or SwiftLexer.CarriageReturn)
        {
            return false;
        }

        for (int i = 2; i < EditableBuffer.Length; i++)
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
        for (int i = 2; i < EditableBuffer.Length; i++)
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
        for (int i = 2; i < EditableBuffer.Length; i++)
        {
            if (predicate(i - 2, Buffer[i]))
            {
                return true;
            }
        }

        return false;
    }

    protected static bool ContainsNewLine(StringBuilder value, int start = 0)
    {
        return ContainsNewLine(value, start, value.Length);
    }

    protected static bool ContainsNewLine(StringBuilder value, int start, int count)
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

    protected static bool ContainsNewLine(string value, int start = 0)
    {
        return ContainsNewLine(value, start, value.Length);
    }

    protected static bool ContainsNewLine(string value, int start, int count)
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

    protected static bool ContainsNewLine(IBuffer value, int start = 0)
    {
        return ContainsNewLine(value, start, value.Length);
    }

    protected static bool ContainsNewLine(IBuffer buffer, int start, int count)
    {
        for (int i = start; i < count; i++)
        {
            char character = buffer[i];
            if (character is SwiftLexer.LineFeed or SwiftLexer.CarriageReturn)
            {
                return true;
            }
        }

        return false;
    }

    protected static bool ContainsNewLine(ReadOnlySpan<char> value, int start = 0)
    {
        return ContainsNewLine(value, start, value.Length);
    }

    protected static bool ContainsNewLine(ReadOnlySpan<char> span, int start, int count)
    {
        for (int index = start; index < count; index++)
        {
            char character = span[index];
            if (character is SwiftLexer.LineFeed or SwiftLexer.CarriageReturn)
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

    protected override ISwiftNode Clone()
    {
        return new LineCommentNode(EditableBufferExtensions.CloneBuffer(EditableBuffer));
    }

    public sealed class Enumerator : IEnumerator<char>
    {
        private readonly LineCommentNode _lineCommentNode;

        private int _index = 1;

        internal Enumerator(LineCommentNode lineCommentNode)
        {
            _lineCommentNode = lineCommentNode;
        }

        public bool MoveNext()
        {
            if (_index >= _lineCommentNode.EditableBuffer.Length)
            {
                return false;
            }

            _index++;
            return true;
        }

        public void Reset()
        {
            _index = 1;
        }

        public char Current => _lineCommentNode.Buffer[_index];

        object IEnumerator.Current => Current;

        public void Dispose()
        {
            // Nothing to dispose
        }
    }
}