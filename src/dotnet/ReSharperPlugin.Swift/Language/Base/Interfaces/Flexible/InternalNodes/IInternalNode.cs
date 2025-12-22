using System;
using System.Collections.Generic;

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
}