using System;
using System.Collections.Generic;
using JetBrains.ReSharper.Psi.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Base.Interfaces.Flexible.InternalNodes;
using SoftOmni.SwiftRd.Language.Base.Interfaces.Flexible.LeafNodes;

namespace SoftOmni.SwiftRd.Language.Base.Interfaces.Flexible.BaseNodes;

/// <summary>
///     <para>
///         Represents a generic concrete or abstract syntax tree node for an arbitrary language.
///     </para>
///     <para>
///         This is the base interface and doesn't assume the node is an internal node or a leaf node.
///         <see cref="IInternalNode"/> and <see cref="ILeafNode"/> are there for respective internal nodes and leaf nodes.
///     </para>
///     <para>
///         This also doesn't assume that all the <see cref="INode"/>s of the tree have a particular language tied to them.
///         There could be differing languages within the same tree.
///         Use <see cref="INode{TIInternalNode, TILeafNode}"/> and <see cref="IInternalNode{TBaseNode}"/>
///         and <see cref="ILeafNode{TBaseNode}"/> to have a set of <see cref="INode"/>s that correspond to a particular language.
///     </para>
/// </summary>
public interface INode : ITreeNode
{
    /// <summary>
    ///     <para>
    ///         Returns the parent of the <see cref="INode"/> or <see langword="null"/> if the <see cref="INode"/>
    ///         has no parent <see cref="INode"/> (is a root <see cref="INode"/>).
    ///     </para>
    ///     <para>
    ///         The parent by definition is an <see cref="IInternalNode"/> and thus this method always returns an <see cref="IInternalNode"/>.
    ///     </para>
    /// </summary>
    /// <remarks>
    ///     The return type is an <see cref="IInternalNode"/> as it is impossible for the parent to be an <see cref="ILeafNode"/>.
    /// </remarks>
    /// <returns>
    ///     The <see cref="IInternalNode"/> that is this <see cref="INode"/>'s parent; <see langword="null"/> otherwise.
    /// </returns>
    public IInternalNode? GetParent();

    /// <summary>
    ///     <para>
    ///         Returns whether the <see cref="INode"/> has a parent (which can be obtained from <see cref="GetParent"/>).
    ///         If the <see cref="INode"/> has no parent, it is a root <see cref="INode"/> of its own tree
    ///         (which may contain only the present root-<see cref="INode"/> itself).
    ///     </para>
    /// </summary>
    /// <returns>
    ///     <see langword="true"/> if the <see cref="INode"/> has a parent; <see langword="false"/> if the <see cref="INode"/> has no parent.
    /// </returns>
    public bool HasParent();

    /// <summary>
    ///     <para>
    ///         The index of this <see cref="INode"/> in its parent as a child or -1 if the <see cref="INode"/> has no parent.
    ///     </para>
    ///     <para>
    ///         A <see cref="IInternalNode"/>'s children are stored as a <see cref="List{T}"/> of <see cref="INode"/>
    ///         or some other data structure that acts as an ordered 0 index list or array of <see cref="INode"/>s.
    ///     </para>
    ///     <para>
    ///         This index is the index in the parent's list or equivalent data structure of this child.
    ///     </para>
    ///     <para>
    ///         If the <see cref="INode"/> has no parent it is a root <see cref="INode"/> of its own tree
    ///         (which may contain only the present root-<see cref="INode"/> itself). In this case -1 will be returned.
    ///     </para>
    /// </summary>
    /// <returns>
    ///     The index of this <see cref="INode"/> as a child <see cref="INode"/> in the parent or -1 is this node has no parent.
    /// </returns>
    public int ParentIndex { get; }

    /// <summary>
    ///     <para>
    ///         The index in the parent's <see cref="Buffer"/>
    ///         where the text/code of this child <see cref="INode"/> begins or -1 if this <see cref="INode"/> has no parent.
    ///     </para>
    ///     <para>
    ///         This is the index of the text or code of this <see cref="INode"/> beginning in its parent.
    ///     </para>
    ///     <para>
    ///         If the <see cref="INode"/> has no parent it is a <see cref="INode"/> node of its own tree
    ///         (which may contain only the present root-<see cref="INode"/> itself). In this case -1 will be returned.   
    ///     </para>
    /// </summary>
    /// <returns>
    ///     <para>
    ///         The index of this code/text in the parent's node or -1 if this node has no parent.
    ///     </para>
    /// </returns>
    public int ParentTextIndex { get; }
    
    public void UnsafeDangerousSetUnderlyingBuffer(IEditableBuffer buffer);
    
    /// <summary>
    ///    
    /// </summary>
    /// <param name="index"></param>
    public void UnsafeDangerousSetParentIndex(int index);
    
    public void UnsafeDangerousSetParentTextIndex(int index);

    /// <summary>
    ///     <para>
    ///         The <see cref="IBuffer"/> of this <see cref="INode"/> containing its code/text.
    ///         This is a given back as a read-only <see cref="IBuffer"/> (even though it may be an <see cref="IEditableBuffer"/> under the hood).
    ///     </para>
    /// </summary>
    /// <remarks>
    ///     This <see cref="Buffer"/> may be a <see cref="Buffer"/> which is actually a string-view like object over the parent's <see cref="Buffer"/>.
    /// </remarks>
    /// <returns>
    ///     The <see cref="IBuffer"/> as a read-only content containing the code/text of this <see cref="INode"/>.
    /// </returns>
    public IBuffer Buffer { get; }

    /// <summary>
    ///     <para>
    ///         Clone this <see cref="INode"/> as a new root <see cref="INode"/> of its own tree.
    ///     </para>
    ///     <para>
    ///         The cloned <see cref="INode"/> will not be physical
    ///         (it won't be associated to actual code in an actual file).
    ///         The physicality of a node is returned by <see cref="ITreeNode.IsPhysical"/>.
    ///     </para>
    ///     <para>
    ///         The original <see cref="INode"/> (this <see cref="INode"/>) will not be touched in any way and will remain physical if it is physical
    ///         and not physical if it is not physical (the value returned from <see cref="ITreeNode.IsPhysical"/>).
    ///         It will remain attached to its current parent (obtained from <see cref="GetParent"/>).
    ///     </para>
    /// </summary>
    /// <returns>
    ///     The cloned <see cref="INode"/>.
    /// </returns>
    public INode CloneAsDetached();

    /// <summary>
    ///     <para>
    ///         Clone this <see cref="INode"/> as a child of the <paramref name="newParent"/> at index <paramref name="index"/>.
    ///         The content will be the same.
    ///     </para>
    ///     <para>
    ///         An <paramref name="index"/> equal to the number of children is allowed and will result
    ///         in simply appending the cloned <see cref="INode"/> to the end of the children of <paramref name="newParent"/>.
    ///     </para>
    ///     <para>
    ///         When adding the cloned <see cref="INode"/> to the <paramref name="newParent"/> at <paramref name="index"/>,
    ///         no child <see cref="INode"/> in <paramref name="newParent"/> will be removed. It acts the same as inserting the <see cref="INode"/>
    ///         at <paramref name="index"/>. The element already at the <paramref name="index"/> and the subsequent elements
    ///         are simply moved over by one in their <see cref="ParentIndex"/>es. Their <see cref="ParentTextIndex"/>
    ///         is moved over by the length of the code in the cloned <see cref="INode"/>.
    ///     </para>
    ///     <para>
    ///         The cloned node will have the physicality if the <paramref name="newParent"/>.
    ///         The physicality of a node is returned by <see cref="ITreeNode.IsPhysical"/>.
    ///     </para>
    ///     <para>
    ///         The original <see cref="INode"/> (this <see cref="INode"/>) will not be touched in any way and will remain physical if it is physical
    ///         and not physical if it is not physical (the value returned from <see cref="ITreeNode.IsPhysical"/>).
    ///         It will remain attached to its current parent (obtained from <see cref="GetParent"/>).
    ///     </para>
    /// </summary>
    /// <param name="newParent">
    ///     The parent to which to add the cloned <see cref="INode"/>.
    /// </param>
    /// <param name="index">
    ///     The index of the cloned <see cref="INode"/> in the <paramref name="newParent"/>.
    /// </param>
    /// <returns>
    ///     The cloned <see cref="INode"/>.
    /// </returns>
    /// <exception cref="ArgumentOutOfRangeException">
    ///     If the <paramref name="index"/> is negative (less than 0).
    /// </exception>
    /// <exception cref="ArgumentOutOfRangeException">
    ///     If the <paramref name="index"/> is greater or equal to the number of children (returned by <see cref="IInternalNode.NumberOfChildren"/>).
    /// </exception>
    public INode CloneAsAttachedTo(IInternalNode newParent, int index);

    /// <summary>
    ///     <para>
    ///         Attaches the <see cref="INode"/> as a child <see cref="INode"/> of <paramref name="newParent"/> at index <paramref name="parentIndex"/>.
    ///         If the <see cref="INode"/> already has a parent (returned by balling <see cref="GetParent"/>)
    ///         <see cref="INode"/> it is attached to, it is detached and removed from that <see cref="INode"/> first.
    ///     </para>
    ///     <para>
    ///         An <paramref name="parentIndex"/> equal to the number of children of the parent
    ///         (returned by calling <see cref="IInternalNode.NumberOfChildren"/> on the <paramref name="newParent"/>)
    ///         is allowed and will result in simply appending the cloned <see cref="INode"/> to
    ///         the end of the children of <paramref name="newParent"/>.
    ///     </para>
    ///     <para>
    ///         If the <see cref="INode"/> had a parent (returned from <see cref="GetParent"/>), the <see cref="INode"/> will be detached.
    ///         It will be removed from the parent without changing other child nodes.
    ///     </para>
    ///     <para>
    ///         When adding the <see cref="INode"/> to the <paramref name="newParent"/> at <paramref name="parentIndex"/>,
    ///         no child <see cref="INode"/> in <paramref name="newParent"/> will be removed. It acts the same as inserting the <see cref="INode"/>
    ///         at <paramref name="parentIndex"/>. The element already at the <paramref name="parentIndex"/> and the subsequent elements
    ///         are simply moved over by one in their <see cref="ParentIndex"/>es. Their <see cref="ParentTextIndex"/>
    ///         is moved over by the length of the code in the cloned <see cref="INode"/>.
    ///     </para>
    /// </summary>
    /// <param name="newParent">
    ///     The parent to which to add the cloned <see cref="INode"/>.
    /// </param>
    /// <param name="parentIndex">
    ///     The index (as in the new <see cref="ParentIndex"/>) of the <see cref="INode"/> in the <paramref name="newParent"/>.
    /// </param>
    /// <exception cref="ArgumentOutOfRangeException">
    ///     If the <paramref name="parentIndex"/> is negative (less than 0).
    /// </exception>
    /// <exception cref="ArgumentOutOfRangeException">
    ///     If the <paramref name="parentIndex"/> is greater or equal to the number of children
    ///     (returned by <see cref="IInternalNode.NumberOfChildren"/> on the <paramref name="newParent"/>).
    /// </exception>
    /// <exception cref="NotSupportedException">
    ///     If you use this method in a type that implements <see cref="INode{TIInternalNode, TILeafNode}"/>
    ///     (this includes <see cref="IInternalNode{TBaseNode}"/> and <see cref="ILeafNode{TBaseNode}"/>)
    ///     and <paramref name="newParent"/> is not of the same type as
    ///     the "TIInternalNode" type that interface was instantiated with. // TODO: review and validate this when awake.
    /// </exception>
    public void AttachToParent(IInternalNode newParent, int parentIndex);
    
    /// <summary>
    ///     <para>
    ///         Make the <see cref="INode"/> the root <see cref="INode"/> of its own tree.
    ///     </para>
    ///     <para>
    ///         This will remove the parent (returned from <see cref="GetParent"/>) and remove this
    ///         <see cref="INode"/> from its parent's <see cref="INode"/>s.
    ///     </para>
    ///     <para>
    ///         The <see cref="Buffer"/> will be a root <see cref="Buffer"/>.
    ///     </para>
    ///     <para>
    ///         Its physicality will be not physical
    ///         (it won't be associated to actual code in an actual file).
    ///         The physicality of a <see cref="INode"/> is returned by <see cref="ITreeNode.IsPhysical"/>.
    ///     </para>
    /// </summary>
    public void DetachFromParent();
}
