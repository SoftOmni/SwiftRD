using System;
using System.Text;
using JetBrains.DocumentModel;
using JetBrains.Text;
using JetBrains.Util;

namespace SoftOmni.SwiftRd.Technology.Buffers;

public sealed class DocumentEditableBuffer(IDocument document) : IEditableBuffer
{
    public IDocument Document { get; } = document;

    public string GetText()
    {
        return Document.GetText();
    }

    public string GetText(TextRange range)
    {
        return Document.GetText(range);
    }

    public bool TryGetReadOnlySpan(out ReadOnlySpan<char> span)
    {
        return Document.Buffer.TryGetReadOnlySpan(out span);
    }

    public void AppendTextTo(StringBuilder builder, TextRange range)
    {
        Document.Buffer.AppendTextTo(builder, range);
    }

    public int GetFNVHashCode(int prefixSeed, TextRange range)
    {
        return Document.Buffer.GetFNVHashCode(prefixSeed, range);
    }

    public void CopyTo(int sourceIndex, char[] destinationArray, int destinationIndex, int length)
    {
        Document.Buffer.CopyTo(sourceIndex, destinationArray, destinationIndex, length);
    }

    public char this[int index] => Document.Buffer[index];

    public int Length => Document.GetTextLength();

    public void Insert(int offset, string text)
    {
        DocumentOffset documentOffset = new(Document, offset);
        Document.InsertText(documentOffset, text);
    }

    public void Remove(int offset, int length)
    {
        DocumentRange documentRange = new(Document, new TextRange(offset, offset + length));
        
        Document.DeleteText(documentRange);
    }

    public void Replace(int offset, int length, string newText)
    {
        DocumentRange documentRange = new(Document, new TextRange(offset, offset + length));
        
        Document.ReplaceText(documentRange, newText);
    }

    public void Replace(int offset, int length, BufferRange newText)
    {
        Replace(offset, length, newText.GetText());
    }
}
