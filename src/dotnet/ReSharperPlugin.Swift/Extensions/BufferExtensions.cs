using System;
using JetBrains.DocumentModel.Impl;
using JetBrains.Text;

namespace ReSharperPlugin.Swift.Extensions;

public static class BufferExtensions
{
    extension(IBuffer buffer)
    {
        public IBuffer Clone()
        { 
            EditableBuffer newBuffer = new(buffer.Length);
            for (int i = 0; i < buffer.Length; i++)
            {
                newBuffer.Insert(i, buffer[i].ToString());
            }

            return newBuffer;
        }
        
        public IBuffer Clone(int start)
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
        
        public IBuffer Clone(int start, int end)
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
    }

    extension(IEditableBuffer editableBuffer)
    {
        public IEditableBuffer CloneEditable()
        { 
            EditableBuffer newBuffer = new(editableBuffer.Length);
            for (int i = 0; i < editableBuffer.Length; i++)
            {
                newBuffer.Insert(i, editableBuffer[i].ToString());
            }

            return newBuffer;
        }
        
        public IEditableBuffer CloneEditable(int start)
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
        
        public IEditableBuffer CloneEditable(int start, int end)
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
        
        public void Insert(int index, IBuffer buffer)
        {
            for (int bufferIndex = 0; bufferIndex < buffer.Length; bufferIndex++)
            {
                editableBuffer.Insert(index + bufferIndex, buffer[bufferIndex].ToString());
            }
        }
    }
}