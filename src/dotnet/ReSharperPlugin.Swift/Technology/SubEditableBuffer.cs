using System;
using System.Text;
using JetBrains.Text;
using JetBrains.Util;

namespace SoftOmni.SwiftRd.Technology;

public sealed class SubEditableBuffer : IEditableBuffer
{
    private readonly IEditableBuffer _parentBuffer;
    
    private readonly int _parentOffset;
    
    private int _lengthInParentBuffer;

    public SubEditableBuffer(IEditableBuffer parent, int parentIndex, int length = 0)
    {
        if (parentIndex < 0 || parentIndex >= parent.Length)
        {
            throw new ArgumentOutOfRangeException(nameof(parent));
        }

        if (length < 0 || length >= parentIndex + parent.Length)
        {
            throw new ArgumentOutOfRangeException(nameof(length));
        }
        
        _parentBuffer = parent;
        _parentOffset = parentIndex;
        _lengthInParentBuffer = length;
    }

    public string GetText()
    {
        return _parentBuffer.GetText(new TextRange(_parentOffset, _parentOffset + _lengthInParentBuffer));
    }

    public string GetText(TextRange range)
    {
        TextRange relativeRange = CheckAndGetAdjustedRelativeRange(range);
        return _parentBuffer.GetText(relativeRange);
    }

    public bool TryGetReadOnlySpan(out ReadOnlySpan<char> span)
    {
        bool succeeded = _parentBuffer.TryGetReadOnlySpan(out ReadOnlySpan<char> overallSpan);
        if (!succeeded)
        {
            span = overallSpan;
            return false;
        }

        span = overallSpan.Slice(_parentOffset, _parentOffset + _lengthInParentBuffer);
        return true;
    }

    public void AppendTextTo(StringBuilder builder, TextRange range)
    {
        TextRange relativeRange = CheckAndGetAdjustedRelativeRange(range);
        _parentBuffer.AppendTextTo(builder, relativeRange);

        _lengthInParentBuffer += builder.Length;
    }

    public int GetFNVHashCode(int prefixSeed, TextRange range)
    {
        TextRange relativeRange = CheckAndGetAdjustedRelativeRange(range);
        return _parentBuffer.GetFNVHashCode(prefixSeed, relativeRange);
    }

    public void CopyTo(int sourceIndex, char[] destinationArray, int destinationIndex, int length)
    {
        if (sourceIndex < 0 || sourceIndex >= _lengthInParentBuffer)
        {
            throw new ArgumentOutOfRangeException(nameof(sourceIndex));
        }

        if (destinationIndex < 0 || destinationIndex >= destinationArray.Length)
        {
            throw new ArgumentOutOfRangeException(nameof(destinationIndex));
        }

        if (length <= sourceIndex || sourceIndex + length >= _lengthInParentBuffer ||
            destinationIndex + length >= destinationArray.Length)
        {
            throw new ArgumentOutOfRangeException(nameof(length));
        }
        
        for (int i = 0; i < length; i++)
        {
            destinationArray[i] = _parentBuffer[sourceIndex + i];
        }
    }

    public char this[int index] => _parentBuffer[_parentOffset + index];

    public int Length => _lengthInParentBuffer;

    public void Insert(int offset, string text)
    {
        if (offset < 0 || offset >= _lengthInParentBuffer)
        {
            throw new ArgumentOutOfRangeException(nameof(offset));
        }
        
        _parentBuffer.Insert(_parentOffset + offset, text);
        _lengthInParentBuffer += text.Length;
    }

    public void Remove(int offset, int length)
    {
        if (offset < 0 || offset >= _lengthInParentBuffer)
        {
            throw new ArgumentOutOfRangeException(nameof(offset));
        }

        if (length < 0 || offset + length >= _lengthInParentBuffer)
        {
            throw new ArgumentOutOfRangeException(nameof(length));
        }
        
        _parentBuffer.Remove(_parentOffset + offset, length);
        _lengthInParentBuffer -= length;
    }

    public void Replace(int offset, int length, string newText)
    {
        Remove(offset, length);
        Insert(offset, newText);
    }

    public void Replace(int offset, int length, BufferRange newText)
    {
        Replace(offset, length, newText.GetText());
    }

    private TextRange CheckAndGetAdjustedRelativeRange(TextRange range)
    {
        if (range.StartOffset < 0 || range.StartOffset >= _lengthInParentBuffer)
        {
            throw new ArgumentOutOfRangeException(nameof(range));
        }

        if (range.EndOffset < range.StartOffset || range.EndOffset >= _lengthInParentBuffer)
        {
            throw new ArgumentOutOfRangeException(nameof(range));
        }

        int relativeStart = _parentOffset + range.StartOffset;
        int relativeEnd = _parentOffset + range.EndOffset;
        TextRange relativeRange = new(relativeStart, relativeEnd);
        return relativeRange;
    }

    internal void SetLength(int newLength)
    {
        if (newLength < 0 || newLength >= _parentOffset + _parentBuffer.Length)
        {
            throw new ArgumentOutOfRangeException(nameof(newLength));
        }

        _lengthInParentBuffer = newLength;
    }

    internal void IncreaseLengthBy(int additionalLength)
    {
        if (additionalLength < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(additionalLength));
        }
        
        SetLength(_lengthInParentBuffer + additionalLength);
    }

    internal void SetLengthToParentOffset(int parentOffset)
    {
        if (parentOffset < _parentOffset || parentOffset + _parentOffset >= _parentBuffer.Length)
        {
            throw new ArgumentOutOfRangeException(nameof(parentOffset));
        }

        _lengthInParentBuffer = parentOffset - _parentOffset;
    }
}
