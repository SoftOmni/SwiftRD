using System;
using System.Collections.Generic;
using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi.Tree;
using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Parser.Tree.Base.InternalNode;

namespace ReSharperPlugin.Swift.Language.Parser.Tree;

/// <summary>
///     <para>
///         Represents a swift concrete syntax tree node.
///         This node can be a leaf or an internal node.
///     </para>
///
///     <para>
///         This interface is the base type definning all Swift syntax tree nodes.
///     </para>
/// </summary>
public interface ISwiftNode : ITreeNode
{
    /// <summary>
    ///     <para>
    ///         Returns the parent of the node or null if the node has no parent node (is a root node).
    ///     </para>
    ///     <para>
    ///         The parent by definition is an internal node and thus this method always returns a <see cref="SwiftInternalNode"/>.
    ///     </para>
    /// </summary>
    /// <remarks>
    ///     The return type is a <see cref="SwiftInternalNode"/> as it is impossible for the parent to be a <see cref="SwiftLeafNode"/>.
    /// </remarks>
    /// <returns>
    ///     The <see cref="SwiftInternalNode"/> that is this node's parent; <see langword="null"/> otherwise.
    /// </returns>
    public SwiftInternalNode? GetParent();

    /// <summary>
    ///     <para>
    ///         Returns whether the node has a parent. If the node has no parent it is a root node of its own tree
    ///         (which may contain only the present root-node itself).
    ///     </para>
    /// </summary>
    /// <returns>
    ///     <see langword="true"/> if the node has a parent; <see langword="false"/> if the node has no parent.
    /// </returns>
    public bool HasParent();

    /// <summary>
    ///     <para>
    ///         The index of this node in its parent as a child or -1 if the node has no parent.
    ///     </para>
    ///     <para>
    ///         A node's children are stored as a <see cref="List{T}"/> of <see cref="ISwiftNode"/>
    ///         or some other data structure that acts as an ordered 0 index list or array of <see cref="ISwiftNode"/>.
    ///     </para>
    ///     <para>
    ///         This index is the index in the parent's list or equivalent data structure of this child.
    ///     </para>
    ///     <para>
    ///         If the node has no parent it is a root node of its own tree
    ///         (which may contain only the present root-node itself). In this case -1 will be returned.
    ///     </para>
    /// </summary>
    /// <returns>
    ///     The index of this node as a child node in the parent or -1 is this node has no parent.
    /// </returns>
    public int ParentIndex { get; }

    /// <summary>
    ///     <para>
    ///         The index in the parent's <see cref="IBuffer"/> (returned by <see cref="GetBuffer"/>)
    ///         where the text/code of this child node begins or -1 if this node has no parent.
    ///     </para>
    ///     <para>
    ///         This is the index of the text or code of this node beginning in its parent.
    ///     </para>
    ///     <para>
    ///         If the node has no parent it is a root node of its own tree
    ///         (which may contain only the present root-node itself). In this case -1 will be returned.   
    ///     </para>
    /// </summary>
    /// <returns>
    ///     <para>
    ///         The index of this code/text in the parent's node or -1 if this node has no parent.
    ///     </para>
    /// </returns>
    public int ParentTextIndex { get; }

    /// <summary>
    ///     <para>
    ///         The <see cref="IBuffer"/> of this node containing its code/text.
    ///         This is a given back as a read-only <see cref="IBuffer"/> (even though it may be an <see cref="IEditableBuffer"/> under the hood).
    ///     </para>
    /// </summary>
    /// <remarks>
    ///     This buffer may be a buffer which is actually a string-view like object over the parent's buffer.
    /// </remarks>
    /// <returns>
    ///     The <see cref="IBuffer"/> as a read-only content containing the code/text of this node.
    /// </returns>
    public IBuffer GetBuffer();

    /// <summary>
    ///     <para>
    ///         The number of children this node has.
    ///     </para>
    ///     <para>
    ///         If the node is a <see cref="SwiftLeafNode"/>, the node has no children by definition and thus this will always return 0 in that case.
    ///     </para>
    /// </summary>
    /// <remarks>
    ///     The number of children of a <see cref="SwiftLeafNode"/> will always be 0.
    /// </remarks>
    /// <returns>
    ///     The number of children this node has.
    /// </returns>
    public int NumberOfChildren();

    /// <summary>
    ///     <para>
    ///         The <see cref="ISwiftNode"/> child node at a given <paramref name="index"/>.
    ///     </para>
    ///     <para>
    ///         When retrieving the value, this simply returns the <see cref="ISwiftNode"/> at that <paramref name="index"/>.
    ///     </para>
    ///     <para>
    ///         When setting the value, the node at that <paramref name="index"/> will be detached (turned into its own root node in its own tree).
    ///         The <paramref name="value"/> node will be attached at the position where the detached node was. That node's content will be turned into
    ///         a child of this node. If it had a parent, it will be detached from that parent before (turned into its own root node in its own tree).
    ///     </para>
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         When retrieving, this is equivalent to a call to <see cref="GetChildAt"/> with the same <paramref name="index"/>.
    ///     </para>
    ///     <para>
    ///         When setting, this is equivalent to a call to <see cref="SetChildAt"/> with the same
    ///         <paramref name="index"/> and <paramref name="value"/>
    ///         (<paramref name="value"/> is parameter in "newNode" in <see cref="SetChildAt"/>).
    ///     </para>
    ///     <para>
    ///         A <see cref="SwiftLeafNode"/> does not have children
    ///         and cannot have children so retrieval and setting will fail and throw an exception.
    ///     </para>
    /// </remarks>
    /// <param name="index">
    ///     The index in the list or list like (or array like) object of the child <see cref="ISwiftNode"/>.
    /// </param>
    /// <param name="value">
    ///     The child <see cref="ISwiftNode"/> to replace the child node at <paramref name="index"/> with.
    /// </param>
    /// <returns>
    ///     The <see cref="ISwiftNode"/> at the given <paramref name="index"/>.
    /// </returns>
    /// <exception cref="ArgumentOutOfRangeException">
    ///     If the <paramref name="index"/> is negative (less than 0).
    /// </exception>
    /// <exception cref="ArgumentOutOfRangeException">
    ///     If the <paramref name="index"/> is greater or equal to the number of children (returned by <see cref="NumberOfChildren"/>).
    /// </exception>
    /// <exception cref="NotSupportedException">
    ///     If the method is called within a <see cref="SwiftLeafNode"/>.
    /// </exception>
    public ISwiftNode this[int index] { get; internal set; }
    
    /// <summary>
    ///     <para>
    ///         Retrieve the <see cref="ISwiftNode"/> child node at the <paramref name="index"/>.
    ///     </para>
    /// </summary>
    /// <param name="index">
    ///     The index in the list or list like (or array like) object of the child <see cref="ISwiftNode"/>.
    /// </param>
    /// <returns>
    ///     The <see cref="ISwiftNode"/> at the given <paramref name="index"/>.
    /// </returns>
    /// <remarks>
    ///     <para>
    ///         This is equivalent to retrieving the node through <see cref="this[int]"/> with the same <paramref name="index"/>.
    ///     </para>
    ///     <para>
    ///         As a <see cref="SwiftLeafNode"/> has no children and cannot have children, this method will always fail and throw an exception.
    ///     </para>
    /// </remarks>
    /// <exception cref="ArgumentOutOfRangeException">
    ///     If the <paramref name="index"/> is negative (less than 0).
    /// </exception>
    /// <exception cref="ArgumentOutOfRangeException">
    ///     If the <paramref name="index"/> is greater or equal to the number of children (returned by <see cref="NumberOfChildren"/>).
    /// </exception>
    /// <exception cref="NotSupportedException">
    ///     If the method is called within a <see cref="SwiftLeafNode"/>.
    /// </exception>
    public ISwiftNode GetChildAt(int index);

    /// <summary>
    ///     <para>
    ///         Sets the <paramref name="newNode"/> to be the child node at <paramref name="index"/>
    ///         in place of the node that may be there already. If the <paramref name="index"/> is equal to the number of children
    ///         (value returned by <see cref="NumberOfChildren"/>), this instead appends <paramref name="newNode"/> to the end
    ///         as an added last child in order.
    ///     </para>
    ///     <para>
    ///         When setting the value, the node at that <paramref name="index"/> will be detached (turned into its own root node in its own tree).
    ///         The <paramref name="newNode"/> node will be attached at the position where the detached node was. That node's content will be turned into
    ///         a child of this node. If it had a parent, it will be detached from that parent before (turned into its own root node in its own tree).
    ///     </para>
    ///     <para>
    ///         If the <paramref name="index"/> is equal to the number of children (value returned by <see cref="NumberOfChildren"/>),
    ///         this instead appends this <see cref="newNode"/> to the end as an added last child in order (without removing any other node).
    ///     </para>
    /// </summary>
    /// <param name="index">
    ///     The index in the list or list like (or array like) object of the child <see cref="ISwiftNode"/>.
    /// </param>
    /// <param name="newNode">
    ///     The child <see cref="ISwiftNode"/> to replace the child node at <paramref name="index"/> with.
    /// </param>
    /// <returns>
    ///     <para>
    ///         The previous <see cref="ISwiftNode"/> at the location if there was an <see cref="ISwiftNode"/> at <paramref name="index"/>
    ///         (so every index except if <paramref name="index"/> is equal to the number of children (returned from <see cref="NumberOfChildren"/>).
    ///     </para>
    ///     <para>
    ///         If the node was appended to the end because <paramref name="index"/> was equal to the number of children
    ///         (returned from <see cref="NumberOfChildren"/>), <see langword="null"/>
    ///     </para>
    /// </returns>
    /// <remarks>
    ///     <para>
    ///         As a <see cref="SwiftLeafNode"/> has no children and cannot have children, this method will always fail and throw an exception.
    ///         This includes the case of appending a new node to the end with a <paramref name="index"/> equal to the number of children
    ///         (returned from <see cref="NumberOfChildren"/>) (which is always 0 in the case of a <see cref="SwiftLeafNode"/>).
    ///     </para>
    /// </remarks>
    /// <exception cref="ArgumentOutOfRangeException">
    ///     If the <paramref name="index"/> is negative (less than 0).
    /// </exception>
    /// <exception cref="ArgumentOutOfRangeException">
    ///     If the <paramref name="index"/> is greater or equal to the number of children (returned by <see cref="NumberOfChildren"/>).
    /// </exception>
    /// <exception cref="NotSupportedException">
    ///     If the method is called within a <see cref="SwiftLeafNode"/>.
    /// </exception>
    public ISwiftNode? SetChildAt(int index, ISwiftNode newNode);

    /// <summary>
    ///     <para>
    ///         Clone this <see cref="ISwiftNode"/> as a new root node of its own tree.
    ///         The content will be the same and cloned and the child nodes will also be deeply cloned.
    ///     </para>
    ///     <para>
    ///         The cloned node will not be physical
    ///         (it won't be associated to actual code in an actual file).
    ///         The physicality of a node is returned by <see cref="ITreeNode.IsPhysical"/>.
    ///     </para>
    ///     <para>
    ///         The original <see cref="ISwiftNode"/> (this <see cref="ISwiftNode"/>) will not be touched in any way and will remain physical if it physical
    ///         (the value returned from <see cref="ITreeNode.IsPhysical"/>). It will remain attached to its current parent.
    ///     </para>
    /// </summary>
    /// <returns>
    ///     The cloned node.
    /// </returns>
    public ISwiftNode CloneAsDetachedDeep();

    /// <summary>
    ///     <para>
    ///         Clone this <see cref="ISwiftNode"/> as a child of the <paramref name="newParent"/> at index <paramref name="index"/>.
    ///         The content will be the same and cloned and the child nodes will also be deeply cloned.
    ///     </para>
    ///     <para>
    ///         An <paramref name="index"/> equal to the number of children is allowed and will result
    ///         in simply appending the cloned node to the end of the children of <paramref name="newParent"/>.
    ///     </para>
    ///     <para>
    ///         When adding the cloned <see cref="ISwiftNode"/> to the <paramref name="newParent"/> at <paramref name="index"/>,
    ///         no child <see cref="ISwiftNode"/> in <paramref name="newParent"/> will be removed. It acts the same as inserting the <see cref="ISwiftNode"/>
    ///         at <paramref name="index"/>. The element already at the <paramref name="index"/> and the subsequent elements
    ///         are simply moved over by one in their <see cref="ParentIndex"/>es. Their <see cref="ParentTextIndex"/>
    ///         is moved over by the length of the code in the cloned <see cref="ISwiftNode"/>.
    ///     </para>
    ///     <para>
    ///         The cloned node will have the physicality if the <paramref name="newParent"/>.
    ///         The physicality of a node is returned by <see cref="ITreeNode.IsPhysical"/>.
    ///     </para>
    ///     <para>
    ///         The original <see cref="ISwiftNode"/> (this <see cref="ISwiftNode"/>) will not be touched in any way and will remain physical if it physical
    ///         (the value returned from <see cref="ITreeNode.IsPhysical"/>). It will remain attached to its current parent.
    ///     </para>
    /// </summary>
    /// <param name="newParent">
    ///     The parent to which to add the cloned <see cref="ISwiftNode"/>.
    /// </param>
    /// <param name="index">
    ///     The index of the cloned node in the <paramref name="newParent"/>.
    /// </param>
    /// <returns>
    ///     The cloned <see cref="ISwiftNode"/>.
    /// </returns>
    /// <exception cref="ArgumentOutOfRangeException">
    ///     If the <paramref name="index"/> is negative (less than 0).
    /// </exception>
    /// <exception cref="ArgumentOutOfRangeException">
    ///     If the <paramref name="index"/> is greater or equal to the number of children (returned by <see cref="NumberOfChildren"/>).
    /// </exception>
    public ISwiftNode CloneAsAttachedToDeep(SwiftInternalNode newParent, int index);

    /// <summary>
    ///     <para>
    ///         Attaches the <see cref="ISwiftNode"/> as a child <see cref="ISwiftNode"/> of <paramref name="newParent"/> at index <paramref name="parentIndex"/>.
    ///         If the <see cref="ISwiftNode"/> already has a parent node it is attached, it is detached and removed from that node first.
    ///     </para>
    ///     <para>
    ///         An <paramref name="parentIndex"/> equal to the number of children is allowed and will result
    ///         in simply appending the cloned node to the end of the children of <paramref name="newParent"/>.
    ///     </para>
    ///     <para>
    ///         If the node had a parent (returned from <see cref="GetParent"/>), the <see cref="ISwiftNode"/> will be detached.
    ///         It will be removed from the parent without changing other child nodes.
    ///     </para>
    ///     <para>
    ///         When adding the <see cref="ISwiftNode"/> to the <paramref name="newParent"/> at <paramref name="parentIndex"/>,
    ///         no child <see cref="ISwiftNode"/> in <paramref name="newParent"/> will be removed. It acts the same as inserting the <see cref="ISwiftNode"/>
    ///         at <paramref name="parentIndex"/>. The element already at the <paramref name="parentIndex"/> and the subsequent elements
    ///         are simply moved over by one in their <see cref="ParentIndex"/>es. Their <see cref="ParentTextIndex"/>
    ///         is moved over by the length of the code in the cloned <see cref="ISwiftNode"/>.
    ///     </para>
    /// </summary>
    /// <param name="newParent">
    ///     The parent to which to add the cloned <see cref="ISwiftNode"/>.
    /// </param>
    /// <param name="parentIndex">
    ///     The index (as in the new <see cref="ParentIndex"/>) of the <see cref="ISwiftNode"/> in the <paramref name="newParent"/>.
    /// </param>
    /// <exception cref="ArgumentOutOfRangeException">
    ///     If the <paramref name="parentIndex"/> is negative (less than 0).
    /// </exception>
    /// <exception cref="ArgumentOutOfRangeException">
    ///     If the <paramref name="parentIndex"/> is greater or equal to the number of children (returned by <see cref="NumberOfChildren"/>).
    /// </exception>
    public void AttachToParent(SwiftInternalNode newParent, int parentIndex);

    /// <summary>
    ///     <para>
    ///         Make the <see cref="ISwiftNode"/> child at index <paramref name="childIndex"/> a new root node of its own tree.
    ///         This will remove the child as a child of this <see cref="ISwiftNode"/>. That <see cref="ISwiftNode"/> will no longer have a parent.
    ///     </para>
    /// </summary>
    /// <param name="childIndex">
    ///     The index of the child to remove in the list-like (or array-like) structure containing the children.
    /// </param>
    /// <returns>
    ///     The <see cref="ISwiftNode"/> that has been detached and made a root of its own tree.
    /// </returns>
    public ISwiftNode DetachChild(int childIndex); // TODO: make this a part of the internal node API not the general API

    /// <summary>
    ///     <para>
    ///         Make the <see cref="ISwiftNode"/> the root node of its own tree.
    ///     </para>
    ///     <para>
    ///         This will remove the parent (returned from <see cref="GetParent"/>) and remove this
    ///         <see cref="ISwiftNode"/> from its parent's nodes.
    ///     </para>
    ///     <para>
    ///         The buffer (obtainable with <see cref="GetBuffer"/>) will be a root buffer.
    ///     </para>
    ///     <para>
    ///         Its physicality will be not physical
    ///         (it won't be associated to actual code in an actual file).
    ///         The physicality of a node is returned by <see cref="ITreeNode.IsPhysical"/>.
    ///     </para>
    /// </summary>
    public void DetachFromParent();
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