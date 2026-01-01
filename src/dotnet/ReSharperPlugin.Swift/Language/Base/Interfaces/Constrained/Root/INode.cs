using System;
using JetBrains.ReSharper.Psi.Tree;

using ReSharperPlugin.Swift.Language.Base.Interfaces.Flexible.Root;
using ReSharperPlugin.Swift.Language.Base.Interfaces.Flexible.InternalNodes;
using ReSharperPlugin.Swift.Language.Base.Interfaces.Flexible.LeafNodes;

namespace ReSharperPlugin.Swift.Language.Base.Interfaces.Constrained.Root;

public interface INode<TInternalNode, TLeafNode> : INode
    where TInternalNode : IInternalNode where TLeafNode : ILeafNode
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
    public new TInternalNode? GetParent();

    /// <summary>
    ///     <para>
    ///         Clone this <see cref="INode"/> as a new root <see cref="INode"/> of its own tree.
    ///     </para>
    ///     <para>
    ///         The cloned <see cref="INode"/> will not be physical
    ///         (it won't be associated with actual code in an actual file).
    ///         The physicality of a node is returned by <see cref="ITreeNode.IsPhysical"/>.
    ///     </para>
    ///     <para>
    ///         The original <see cref="INode"/> (this <see cref="INode"/>) will not be touched in any way and will remain physical if it is physical
    ///         and not physical if it is not physical (the value returned from <see cref="ITreeNode.IsPhysical"/>).
    ///         It will remain attached to its current parent (obtained from <see cref="GetParent"/>).
    ///     </para>
    /// </summary>
    /// <returns>
    ///     The cloned node.
    /// </returns>
    public new INode<TInternalNode, TLeafNode> CloneAsDetached();

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
    ///         at <paramref name="index"/>. The element already at the <paramref name="index"/> and the later elements
    ///         are simply moved over by one in their <see cref="INode.ParentIndex"/>es. Their <see cref="INode.ParentTextIndex"/>
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
    public new INode<TInternalNode, TLeafNode> CloneAsAttachedTo(IInternalNode newParent, int index);

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
    ///         at <paramref name="parentIndex"/>. The element already at the <paramref name="parentIndex"/> and the later elements
    ///         are simply moved over by one in their <see cref="INode.ParentIndex"/>es. Their <see cref="INode.ParentTextIndex"/>
    ///         is moved over by the length of the code in the cloned <see cref="INode"/>.
    ///     </para>
    /// </summary>
    /// <param name="newParent">
    ///     The parent to which to add the cloned <see cref="INode"/>.
    /// </param>
    /// <param name="parentIndex">
    ///     The index (as in the new <see cref="INode.ParentIndex"/>) of the <see cref="INode"/> in the <paramref name="newParent"/>.
    /// </param>
    /// <exception cref="ArgumentOutOfRangeException">
    ///     If the <paramref name="parentIndex"/> is negative (less than 0).
    /// </exception>
    /// <exception cref="ArgumentOutOfRangeException">
    ///     If the <paramref name="parentIndex"/> is greater or equal to the number of children
    ///     (returned by <see cref="IInternalNode.NumberOfChildren"/> on the <paramref name="newParent"/>).
    /// </exception>
    public void AttachToParent(TInternalNode newParent, int parentIndex);
}