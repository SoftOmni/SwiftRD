using System;
using JetBrains.DocumentModel.Impl;
using JetBrains.Text;

namespace ReSharperPlugin.Swift.Extensions;

public static class BufferExtensions
{
    public static IBuffer Clone(this IBuffer buffer)
    { 
        EditableBuffer newBuffer = new(buffer.Length);
        for (int i = 0; i < buffer.Length; i++)
        {
            newBuffer.Insert(i, buffer[i].ToString());
        }

        return newBuffer;
    }

    public static IBuffer Clone(this IBuffer buffer, int start)
    {
        if (start < 0 || start > buffer.Length)
        {
            throw new ArgumentOutOfRangeException(nameof(start));
        }
            
        EditableBuffer newBuffer = new(buffer.Length);
        for (int i = start; i < buffer.Length; i++)
        {
            newBuffer.Insert(i, buffer[i].ToString());
        }

        return newBuffer;
    }

    public static IBuffer Clone(this IBuffer buffer, int start, int end)
    {
        if (start < 0 || start > buffer.Length)
        {
            throw new ArgumentOutOfRangeException(nameof(start));
        }

        if (end < 0 || end > buffer.Length)
        {
            throw new ArgumentOutOfRangeException(nameof(end));
        }
            
        EditableBuffer newBuffer = new(buffer.Length);
        for (int i = start; i < end; i++)
        {
            newBuffer.Insert(i, buffer[i].ToString());
        }

        return newBuffer;
    }

    public static IEditableBuffer CloneEditable(this IEditableBuffer editableBuffer)
    { 
        EditableBuffer newBuffer = new(editableBuffer.Length);
        for (int i = 0; i < editableBuffer.Length; i++)
        {
            newBuffer.Insert(i, editableBuffer[i].ToString());
        }

        return newBuffer;
    }

    public static IEditableBuffer CloneEditable(this IEditableBuffer editableBuffer, int start)
    {
        if (start < 0 || start > editableBuffer.Length)
        {
            throw new ArgumentOutOfRangeException(nameof(start));
        }
            
        EditableBuffer newBuffer = new(editableBuffer.Length);
        for (int i = start; i < editableBuffer.Length; i++)
        {
            newBuffer.Insert(i, editableBuffer[i].ToString());
        }

        return newBuffer;
    }

    public static IEditableBuffer CloneEditable(this IEditableBuffer editableBuffer, int start, int end)
    {
        if (start < 0 || start > editableBuffer.Length)
        {
            throw new ArgumentOutOfRangeException(nameof(start));
        }

        if (end < 0 || end > editableBuffer.Length)
        {
            throw new ArgumentOutOfRangeException(nameof(end));
        }
            
        EditableBuffer newBuffer = new(editableBuffer.Length);
        for (int i = start; i < end; i++)
        {
            newBuffer.Insert(i, editableBuffer[i].ToString());
        }

        return newBuffer;
    }

    public static void Insert(this IEditableBuffer editableBuffer, int index, IBuffer buffer)
    {
        for (int bufferIndex = 0; bufferIndex < buffer.Length; bufferIndex++)
        {
            editableBuffer.Insert(index + bufferIndex, buffer[bufferIndex].ToString());
        }
    }
}