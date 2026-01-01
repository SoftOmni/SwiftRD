using System;
using System.Collections.Generic;
using JetBrains.ReSharper.Psi.Tree;
using ReSharperPlugin.Swift.Language.Base.Interfaces.Constrained.Root;
using ReSharperPlugin.Swift.Language.Base.Interfaces.Constrained.InternalNodes;
using ReSharperPlugin.Swift.Language.Base.Interfaces.Constrained.LeafNodes;

using ReSharperPlugin.Swift.Language.Base.Interfaces.Flexible.Root;

namespace ReSharperPlugin.Swift.Language.Base.Interfaces.Flexible.InternalNodes;

/// <summary>
///     <para>
///         Represents a generic concrete or abstract syntax tree <see cref="INode"/> for an arbitrary language
///         that happens to be an internal node.
///     </para>
///     <para>
///         An <see cref="IInternalNode"/> can have children.
///         These children are represented as though being stored in a <see cref="List{T}"/>,
///         <see cref="List{T}"/>-like (or <see cref="Array"/>-like) way.
///         Each child has an index, starting at 0.
///     </para>
///     <para>
///         This also doesn't assume that all the <see cref="INode"/>s of the tree
///         this <see cref="IInternalNode"/> is a part of have a particular language tied to them.
///         There could be differing languages within the same tree.
///         Use <see cref="INode{TIInternalNode, TILeafNode}"/> and <see cref="IInternalNode{TBaseNode}"/> and <see cref="ILeafNode{TBaseNode}"/>
///         to have a set of <see cref="INode"/>s that correspond to a particular language.
///     </para>
/// </summary>
public partial interface IInternalNode : INode
{
    /// <summary>
    ///     <para>
    ///         The number of children this <see cref="IInternalNode"/> has.
    ///     </para>
    /// </summary>
    /// <returns>
    ///     The number of children this <see cref="IInternalNode"/> has.
    /// </returns>
    public int NumberOfChildren { get; }

    /// <summary>
    ///     <para>
    ///         The child <see cref="INode"/> at a given <paramref name="index"/>.
    ///     </para>
    ///     <para>
    ///         When retrieving the value, this simply returns the <see cref="INode"/> at that <paramref name="index"/>.
    ///     </para>
    ///     <para>
    ///         When setting the value, the <see cref="INode"/> at that <paramref name="index"/> will be detached (turned into its own root <see cref="INode"/> in its own tree).
    ///         The <paramref name="value"/> <see cref="INode"/> will be attached at the position where the detached <see cref="INode"/> was. That <see cref="INode"/>'s content will be turned into
    ///         a child of this <see cref="INode"/>. If it had a parent (obtainable with <see cref="INode.GetParent"/>),
    ///         it will be detached from that parent before (turned into its own root <see cref="INode"/> in its own tree).
    ///     </para>
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         When retrieving, this is equivalent to a call to <see cref="GetChildAt"/> with the same <paramref name="index"/>.
    ///     </para>
    ///     <para>
    ///         When setting, this is equivalent to a call to <see cref="SetChildAt"/> with the same
    ///         <paramref name="index"/> and <paramref name="value"/>
    ///         (<paramref name="value"/> is parameter "newNode" in <see cref="SetChildAt"/>).
    ///     </para>
    /// </remarks>
    /// <param name="index">
    ///     The index in the <see cref="List{T}"/> or <see cref="List{T}"/>-like (or <see cref="Array"/>-like) object of the child <see cref="INode"/>.
    /// </param>
    /// <param name="value">
    ///     The child <see cref="INode"/> to replace the child <see cref="INode"/> at <paramref name="index"/> with.
    /// </param>
    /// <returns>
    ///     The <see cref="INode"/> at the given <paramref name="index"/>.
    /// </returns>
    /// <exception cref="ArgumentOutOfRangeException">
    ///     If the <paramref name="index"/> is negative (less than 0).
    /// </exception>
    /// <exception cref="ArgumentOutOfRangeException">
    ///     If the <paramref name="index"/> is greater or equal to the <see cref="NumberOfChildren"/>.
    /// </exception>
    public INode this[int index] { get; internal set; }

    /// <summary>
    ///     <para>
    ///         Clone this <see cref="IInternalNode"/> as a new root <see cref="IInternalNode"/> of its own tree.
    ///     </para>
    ///     <para>
    ///         The cloned <see cref="IInternalNode"/> will not be physical
    ///         (it won't be associated to actual code in an actual file).
    ///         The physicality of a node is returned by <see cref="ITreeNode.IsPhysical"/>.
    ///     </para>
    ///     <para>
    ///         The original <see cref="IInternalNode"/> (this <see cref="IInternalNode"/>)
    ///         will not be touched in any way and will remain physical if it is physical
    ///         and not physical if it is not physical (the value returned from <see cref="ITreeNode.IsPhysical"/>).
    ///         It will remain attached to its current parent (obtained from <see cref="INode.GetParent"/>).
    ///     </para>
    /// </summary>
    /// <remarks>
    ///     A cloned version of an <see cref="IInternalNode"/> is not merely known to be an <see cref="INode"/>.
    ///     It is also an <see cref="IInternalNode"/> so this override of <see cref="INode.CloneAsDetached"/> in this interface
    ///     merely updates this documentation and the returned type to be an <see cref="IInternalNode"/>
    ///     as that is known to be true.
    /// </remarks>
    /// <returns>
    ///     The cloned <see cref="IInternalNode"/>.
    /// </returns>
    public new IInternalNode CloneAsDetached();
    
    /// <summary>
    ///     <para>
    ///         Clone this <see cref="IInternalNode"/> as a child of the <paramref name="newParent"/> at index <paramref name="index"/>.
    ///         The content will be the same.
    ///     </para>
    ///     <para>
    ///         An <paramref name="index"/> equal to the number of children is allowed and will result
    ///         in simply appending the cloned <see cref="IInternalNode"/> to the end of the children of <paramref name="newParent"/>.
    ///     </para>
    ///     <para>
    ///         When adding the cloned <see cref="IInternalNode"/> to the <paramref name="newParent"/> at <paramref name="index"/>,
    ///         no child <see cref="INode"/> in <paramref name="newParent"/> will be removed. It acts the same as inserting the <see cref="IInternalNode"/>
    ///         at <paramref name="index"/>. The element already at the <paramref name="index"/> and the later elements
    ///         are simply moved over by one in their <see cref="INode.ParentIndex"/>es. Their <see cref="INode.ParentTextIndex"/>
    ///         is moved over by the length of the code in the cloned <see cref="INode"/>.
    ///     </para>
    ///     <para>
    ///         The cloned <see cref="IInternalNode"/> will have the physicality if the <paramref name="newParent"/>.
    ///         The physicality of a node is returned by <see cref="ITreeNode.IsPhysical"/>.
    ///     </para>
    ///     <para>
    ///         The original <see cref="IInternalNode"/> (this <see cref="IInternalNode"/>)
    ///         will not be touched in any way and will remain physical if it is physical
    ///         and not physical if it is not physical (the value returned from <see cref="ITreeNode.IsPhysical"/>).
    ///         It will remain attached to its current parent (obtained from <see cref="INode.GetParent"/>).
    ///     </para>
    /// </summary>
    /// <param name="newParent">
    ///     The parent to which to add the cloned <see cref="IInternalNode"/>.
    /// </param>
    /// <param name="index">
    ///     The index of the cloned <see cref="IInternalNode"/> in the <paramref name="newParent"/>.
    /// </param>
    /// <returns>
    ///     The cloned <see cref="IInternalNode"/>.
    /// </returns>
    /// <exception cref="ArgumentOutOfRangeException">
    ///     If the <paramref name="index"/> is negative (less than 0).
    /// </exception>
    /// <exception cref="ArgumentOutOfRangeException">
    ///     If the <paramref name="index"/> is greater or equal to the number of children (returned by <see cref="IInternalNode.NumberOfChildren"/>).
    /// </exception>
    /// <remarks>
    ///     A cloned version of an <see cref="IInternalNode"/> is not merely known to be an <see cref="INode"/>.
    ///     It is also an <see cref="IInternalNode"/> so this override of <see cref="INode.CloneAsAttachedTo"/> in this interface
    ///     merely updates this documentation and the returned type to be an <see cref="IInternalNode"/>
    ///     as that is known to be true.
    /// </remarks>
    public new IInternalNode CloneAsAttachedTo(IInternalNode newParent, int index);
}