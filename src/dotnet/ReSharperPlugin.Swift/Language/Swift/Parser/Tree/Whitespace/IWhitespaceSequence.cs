using System;
using System.Collections.Generic;
using System.Text;
using JetBrains.Text;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Whitespace;

public interface IWhitespaceSequence : IReadOnlyWhitespaceSequence, IWhitespaceNode
{
    public void MakeOnlyTabs(
        TabWidthRounding rounding =
            TabWidthRounding.RoundingUpIfMiddle);

    public void MakeOnlyTabs(int tabWidth,
        TabWidthRounding rounding =
            TabWidthRounding.RoundingUpIfMiddle);

    public void MakeOnlySpaces();

    public void MakeOnlySpaces(int tabWidth);

    public void SetTabWidthToDefault();

    public void SetTabWidth(int tabWidth);
    
    public void SetValue(IBuffer value);

    public void SetValue(IBuffer value, int startIndex);

    public void SetValue(IBuffer value, int startIndex, int endIndex);

    public void SetValue(StringBuilder value);

    public void SetValue(StringBuilder value, int startIndex);

    public void SetValue(StringBuilder value, int startIndex, int endIndex);

    public void SetValue(string value);

    public void SetValue(string value, int startIndex);

    public void SetValue(string value, int startIndex, int endIndex);

    public void SetValue(ReadOnlySpan<char> value);

    public void SetValue(ReadOnlySpan<char> value, int startIndex);

    public void SetValue(ReadOnlySpan<char> value, int startIndex, int endIndex);

    public void InsertInValue(int offset, IBuffer buffer);

    public void InsertInValue(int offset, IBuffer buffer, int startIndex);

    public void InsertInValue(int offset, IBuffer buffer, int startIndex, int endIndex);

    public void InsertInValue(int offset, IEditableBuffer buffer);

    public void InsertInValue(int offset, IEditableBuffer buffer, int startIndex);

    public void InsertInValue(int offset, IEditableBuffer buffer, int startIndex, int endIndex);

    public void InsertInValue(int offset, StringBuilder buffer);

    public void InsertInValue(int offset, StringBuilder buffer, int startIndex);

    public void InsertInValue(int offset, StringBuilder buffer, int startIndex, int endIndex);

    public void InsertInValue(int offset, string buffer);

    public void InsertInValue(int offset, string buffer, int startIndex);

    public void InsertInValue(int offset, string buffer, int startIndex, int endIndex);

    public void InsertInValue(int offset, ReadOnlySpan<char> buffer);

    public void InsertInValue(int offset, ReadOnlySpan<char> buffer, int startIndex);

    public void InsertInValue(int offset, ReadOnlySpan<char> buffer, int startIndex, int endIndex);

    public void PrependToValue(IBuffer buffer);

    public void PrependToValue(IBuffer buffer, int startIndex);

    public void PrependToValue(IBuffer buffer, int startIndex, int endIndex);

    public void PrependToValue(IEditableBuffer buffer);

    public void PrependToValue(IEditableBuffer buffer, int startIndex);

    public void PrependToValue(IEditableBuffer buffer, int startIndex, int endIndex);

    public void PrependToValue(StringBuilder buffer);

    public void PrependToValue(StringBuilder buffer, int startIndex);

    public void PrependToValue(StringBuilder buffer, int startIndex, int endIndex);

    public void PrependToValue(string buffer);

    public void PrependToValue(string buffer, int startIndex);

    public void PrependToValue(string buffer, int startIndex, int endIndex);

    public void PrependToValue(ReadOnlySpan<char> buffer);

    public void PrependToValue(ReadOnlySpan<char> buffer, int startIndex);

    public void PrependToValue(ReadOnlySpan<char> buffer, int startIndex, int endIndex);

    public void AppendToValue(IBuffer buffer);

    public void AppendToValue(IBuffer buffer, int startIndex);

    public void AppendToValue(IBuffer buffer, int startIndex, int endIndex);

    public void AppendToValue(IEditableBuffer buffer);

    public void AppendToValue(IEditableBuffer buffer, int startIndex);

    public void AppendToValue(IEditableBuffer buffer, int startIndex, int endIndex);

    public void AppendToValue(StringBuilder buffer);

    public void AppendToValue(StringBuilder buffer, int startIndex);

    public void AppendToValue(StringBuilder buffer, int startIndex, int endIndex);

    public void AppendToValue(string buffer);

    public void AppendToValue(string buffer, int startIndex);

    public void AppendToValue(string buffer, int startIndex, int endIndex);

    public void AppendToValue(ReadOnlySpan<char> buffer);

    public void AppendToValue(ReadOnlySpan<char> buffer, int startIndex);

    public void AppendToValue(ReadOnlySpan<char> buffer, int startIndex, int endIndex);

    public void ReplaceInValue(int index, IBuffer buffer, bool extend = false);

    public void ReplaceInValue(int index, IBuffer buffer, int startIndex, bool extend = false);

    public void ReplaceInValue(int index, IBuffer buffer, int startIndex, int endIndex, bool extend = false);

    public void ReplaceInValue(int index, IEditableBuffer buffer, bool extend = false);

    public void ReplaceInValue(int index, IEditableBuffer buffer, int startIndex, bool extend = false);

    public void ReplaceInValue(int index, IEditableBuffer buffer, int startIndex, int endIndex, bool extend = false);

    public void ReplaceInValue(int index, StringBuilder buffer, bool extend = false);

    public void ReplaceInValue(int index, StringBuilder buffer, int startIndex, bool extend = false);

    public void ReplaceInValue(int index, StringBuilder buffer, int startIndex, int endIndex, bool extend = false);

    public void ReplaceInValue(int index, string buffer, bool extend = false);

    public void ReplaceInValue(int index, string buffer, int startIndex, bool extend = false);

    public void ReplaceInValue(int index, string buffer, int startIndex, int endIndex, bool extend = false);

    public void ReplaceInValue(int index, ReadOnlySpan<char> buffer, bool extend = false);

    public void ReplaceInValue(int index, ReadOnlySpan<char> buffer, int startIndex, bool extend = false);

    public void ReplaceInValue(int index, ReadOnlySpan<char> buffer, int startIndex, int endIndex, bool extend = false);

    public void RemoveFromValue(int index);

    public void RemoveFromValue(int startIndex, int endIndex);

    public List<(int index, char character)> RemoveWhere(Func<int, bool> predicate);

    public List<(int index, char character)> RemoveWhere(Func<int, bool> predicate, int startIndex);

    public List<(int index, char character)> RemoveWhere(Func<int, bool> predicate, int startIndex, int endIndex);

    public List<(int index, char character)> RemoveWhere(Func<char, bool> predicate);

    public List<(int index, char character)> RemoveWhere(Func<char, bool> predicate, int startIndex);

    public List<(int index, char character)> RemoveWhere(Func<char, bool> predicate, int startIndex, int endIndex);

    public List<(int index, char character)> RemoveWhere(Func<int, char, bool> predicate);

    public List<(int index, char character)> RemoveWhere(Func<int, char, bool> predicate, int startIndex);

    public List<(int index, char character)> RemoveWhere(Func<int, char, bool> predicate, int startIndex, int endIndex);

    public void ClearValue();
}
