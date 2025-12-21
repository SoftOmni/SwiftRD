using System;
using System.Text;
using JetBrains.Text;
using JetBrains.Util;

namespace ReSharperPlugin.Swift.Technology;

public class SubEditableBuffer : IEditableBuffer
{
    public SubEditableBuffer(IEditableBuffer parent, int parentIndex, int length = 0)
    { }

    public string GetText()
    {
        throw new NotImplementedException();
    }

    public string GetText(TextRange range)
    {
        throw new NotImplementedException();
    }

    public bool TryGetReadOnlySpan(out ReadOnlySpan<char> span)
    {
        throw new NotImplementedException();
    }

    public void AppendTextTo(StringBuilder builder, TextRange range)
    {
        throw new NotImplementedException();
    }

    public int GetFNVHashCode(int prefixSeed, TextRange range)
    {
        throw new NotImplementedException();
    }

    public void CopyTo(int sourceIndex, char[] destinationArray, int destinationIndex, int length)
    {
        throw new NotImplementedException();
    }

    public char this[int index] => throw new NotImplementedException();

    public int Length { get; internal set; }

    public void Insert(int offset, string text)
    {
        throw new NotImplementedException();
    }

    public void Remove(int offset, int length)
    {
        throw new NotImplementedException();
    }

    public void Replace(int offset, int length, string newText)
    {
        throw new NotImplementedException();
    }

    public void Replace(int offset, int length, BufferRange newText)
    {
        throw new NotImplementedException();
    }
}