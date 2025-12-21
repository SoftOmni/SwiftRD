using System;
using System.Collections.Generic;

namespace ReSharperPlugin.Swift.Language.Base;

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
    ///         Make the <see cref="INode"/> child at index <paramref name="childIndex"/> a new <see cref="INode"/> node of its own tree.
    ///         This will remove the child as a child of this <see cref="INode"/>. That <see cref="INode"/> will no longer have a parent
    ///         (returned from <see cref="INode.GetParent"/>).
    ///     </para>
    /// </summary>
    /// <param name="childIndex">
    ///     The index of the child to remove in the <see cref="List{T}"/>-like (or <see cref="Array"/>-like) structure containing the children.
    /// </param>
    /// <returns>
    ///     The <see cref="INode"/> that has been detached and made a root of its own tree.
    /// </returns>
    public INode DetachChild(int childIndex);
    
    
}