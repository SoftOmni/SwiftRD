
using System;
using JetBrains.ReSharper.Psi.Tree;
using SoftOmni.SwiftRd.Language.Base.Interfaces.Flexible.InternalNodes;
using SoftOmni.SwiftRd.Language.Base.Interfaces.Flexible.BaseNodes;

namespace SoftOmni.SwiftRd.Language.Base.Interfaces.Flexible.LeafNodes;

/// <summary>
///     <para>
///         Represents a generic concrete or abstract syntax tree <see cref="INode"/> for an arbitrary language
///         that happens to be a leaf node.
///     </para>
///     <para>
///         An <see cref="ILeafNode"/> does not have any children. It is otherwise a regular <see cref="INode"/>.
///     </para>
///     <para>
///         This also doesn't assume that all the <see cref="INode"/>s of the tree
///         this <see cref="ILeafNode"/> is a part of have a particular language tied to them.
///         There could be differing languages within the same tree.
///         Use <see cref="INode{TIInternalNode, TILeafNode}"/> and <see cref="IInternalNode{TBaseNode}"/> and <see cref="ILeafNode{TBaseNode}"/>
///         to have a set of <see cref="INode"/>s that correspond to a particular language.
///     </para>
/// </summary>
/// <remarks>
///     <para>
///         For now this is simply useful for specifying a more specific type.
///         This does not have special features compared to an <see cref="INode"/> tied to it because anything
///         an <see cref="ILeafNode"/> would want to do, an <see cref="INode"/> would as well.
///     </para>
/// </remarks>
public interface ILeafNode : INode
{
    /// <summary>
    ///     <para>
    ///         Clone this <see cref="ILeafNode"/> as a new root <see cref="ILeafNode"/> of its own tree.
    ///     </para>
    ///     <para>
    ///         The cloned <see cref="ILeafNode"/> will not be physical
    ///         (it won't be associated to actual code in an actual file).
    ///         The physicality of a node is returned by <see cref="ITreeNode.IsPhysical"/>.
    ///     </para>
    ///     <para>
    ///         The original <see cref="ILeafNode"/> (this <see cref="ILeafNode"/>)
    ///         will not be touched in any way and will remain physical if it is physical
    ///         and not physical if it is not physical (the value returned from <see cref="ITreeNode.IsPhysical"/>).
    ///         It will remain attached to its current parent (obtained from <see cref="INode.GetParent"/>).
    ///     </para>
    /// </summary>
    /// <remarks>
    ///     A cloned version of an <see cref="ILeafNode"/> is not merely known to be an <see cref="INode"/>.
    ///     It is also an <see cref="ILeafNode"/> so this override of <see cref="INode.CloneAsDetached"/> in this interface
    ///     merely updates this documentation and the returned type to be an <see cref="ILeafNode"/>
    ///     as that is known to be true.
    /// </remarks>
    /// <returns>
    ///     The cloned <see cref="ILeafNode"/>.
    /// </returns>
    public new ILeafNode CloneAsDetached();

    /// <summary>
    ///     <para>
    ///         Clone this <see cref="ILeafNode"/> as a child of the <paramref name="newParent"/> at index <paramref name="index"/>.
    ///         The content will be the same.
    ///     </para>
    ///     <para>
    ///         An <paramref name="index"/> equal to the number of children is allowed and will result
    ///         in simply appending the cloned <see cref="ILeafNode"/> to the end of the children of <paramref name="newParent"/>.
    ///     </para>
    ///     <para>
    ///         When adding the cloned <see cref="ILeafNode"/> to the <paramref name="newParent"/> at <paramref name="index"/>,
    ///         no child <see cref="INode"/> in <paramref name="newParent"/> will be removed. It acts the same as inserting the <see cref="ILeafNode"/>
    ///         at <paramref name="index"/>. The element already at the <paramref name="index"/> and the later elements
    ///         are simply moved over by one in their <see cref="INode.ParentIndex"/>es. Their <see cref="INode.ParentTextIndex"/>
    ///         is moved over by the length of the code in the cloned <see cref="INode"/>.
    ///     </para>
    ///     <para>
    ///         The cloned <see cref="ILeafNode"/> will have the physicality if the <paramref name="newParent"/>.
    ///         The physicality of a node is returned by <see cref="ITreeNode.IsPhysical"/>.
    ///     </para>
    ///     <para>
    ///         The original <see cref="ILeafNode"/> (this <see cref="ILeafNode"/>)
    ///         will not be touched in any way and will remain physical if it is physical
    ///         and not physical if it is not physical (the value returned from <see cref="ITreeNode.IsPhysical"/>).
    ///         It will remain attached to its current parent (obtained from <see cref="INode.GetParent"/>).
    ///     </para>
    /// </summary>
    /// <param name="newParent">
    ///     The parent to which to add the cloned <see cref="ILeafNode"/>.
    /// </param>
    /// <param name="index">
    ///     The index of the cloned <see cref="ILeafNode"/> in the <paramref name="newParent"/>.
    /// </param>
    /// <returns>
    ///     The cloned <see cref="ILeafNode"/>.
    /// </returns>
    /// <exception cref="ArgumentOutOfRangeException">
    ///     If the <paramref name="index"/> is negative (less than 0).
    /// </exception>
    /// <exception cref="ArgumentOutOfRangeException">
    ///     If the <paramref name="index"/> is greater or equal to the number of children (returned by <see cref="IInternalNode.NumberOfChildren"/>).
    /// </exception>
    /// <remarks>
    ///     A cloned version of an <see cref="ILeafNode"/> is not merely known to be an <see cref="INode"/>.
    ///     It is also an <see cref="ILeafNode"/> so this override of <see cref="INode.CloneAsAttachedTo"/> in this interface
    ///     merely updates this documentation and the returned type to be an <see cref="ILeafNode"/>
    ///     as that is known to be true.
    /// </remarks>
    public new ILeafNode CloneAsAttachedTo(IInternalNode newParent, int index);
}