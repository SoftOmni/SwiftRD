using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi.Tree;
using JetBrains.Text;

namespace ReSharperPlugin.Swift.Language.Parser.Tree;

public interface ISwiftNode : ITreeNode
{
    public SwiftInternalNode? GetParent();

    public bool HasParent();
    
    public int ParentIndex { get; }
    
    public int ParentTextIndex { get; }

    public IBuffer GetBuffer();
    
    public int NumberOfChildren();
    
    public ISwiftNode this[int index] { get; internal set; }

    public ISwiftNode GetChildAt(int index);

    public ISwiftNode? SetChildAt(int index, ISwiftNode newNode);

    public ISwiftNode CloneAsDetachedShallow();

    public ISwiftNode CloneAsDetachedDeep();

    public ISwiftNode CloneAsAttachedToShallow(int index, SwiftInternalNode newParent);
    
    public ISwiftNode CloneAsAttachedToDeep(int index, SwiftInternalNode newParent);

    public void AttachToParent(SwiftInternalNode newParent, int parentIndex);

    public void DetachChild(int childIndex);
    
    public void DetachFromParent();

    public enum DepthCloningMode
    {
        SoftLinkRemaining,
        HardStop
    }
}

public static class BufferExtensions
{
    extension(IEditableBuffer buffer)
    {
        public void Insert(int index, ISwiftNode swiftNode)
        {
            IBuffer nodeBuffer = swiftNode.GetBuffer();
            for (int bufferIndex = 0; bufferIndex < nodeBuffer.Length; bufferIndex++)
            {
                buffer.Insert(index + bufferIndex, nodeBuffer[bufferIndex].ToString());
            }
        }
    }

    public static IBuffer CombineBuffers(int capacity, params IBuffer[] buffers)
    {
        EditableBuffer finalBuffer = new(capacity);

        for (int buffersIndex = 0; buffersIndex < finalBuffer.Length; buffersIndex++)
        {
            IBuffer buffer = buffers[buffersIndex];

            for (int bufferIndex = 0; bufferIndex < buffer.Length; bufferIndex++)
            {
                finalBuffer.Insert(finalBuffer.Length, buffer[bufferIndex].ToString());
            }
        }
        
        return finalBuffer;
    }
    
    public static IBuffer CombineBuffers(params IBuffer[] buffers)
    {
        EditableBuffer finalBuffer = new();

        for (int buffersIndex = 0; buffersIndex < finalBuffer.Length; buffersIndex++)
        {
            IBuffer buffer = buffers[buffersIndex];

            for (int bufferIndex = 0; bufferIndex < buffer.Length; bufferIndex++)
            {
                finalBuffer.Insert(finalBuffer.Length, buffer[bufferIndex].ToString());
            }
        }
        
        return finalBuffer;
    }
}