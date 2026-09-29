using System;
using System.Collections.Generic;
using SoftOmni.SwiftRd.Language.Base.Interfaces.Flexible.BaseNodes;

namespace SoftOmni.SwiftRd.Language.Base.Interfaces.Flexible.InternalNodes;

public partial interface IInternalNode
{
    /// <summary>
    ///     <para>
    ///         Sets the <paramref name="newNode"/> to be the child <see cref="INode"/> at <paramref name="index"/>
    ///         in place of the <see cref="INode"/> that may be there already.
    ///         If the <paramref name="index"/> is equal to the <see cref="NumberOfChildren"/>,
    ///         this instead appends <paramref name="newNode"/> to the end as an added last child in order.
    ///     </para>
    ///     <para>
    ///         When setting the value, the <see cref="INode"/> at that <paramref name="index"/> will be detached
    ///         (turned into its own root <see cref="INode"/> in its own tree).
    ///         The <paramref name="newNode"/> <see cref="INode"/> will be attached at the position where
    ///         the detached <see cref="INode"/> was.
    ///         That <see cref="INode"/>'s content will be turned into a child of this <see cref="INode"/>.
    ///         If it had a parent, it will be detached from that parent before (turned into its own root <see cref="INode"/> in its own tree).
    ///     </para>
    ///     <para>
    ///         If the <paramref name="index"/> is equal to the <see cref="NumberOfChildren"/>,
    ///         this instead appends this <see cref="newNode"/> to the end as an added last child in order (without removing any other <see cref="INode"/>).
    ///     </para>
    /// </summary>
    /// <param name="index">
    ///     The index in the <see cref="List{T}"/> or <see cref="List{T}"/>-like (or <see cref="Array"/>-like) object of the child <see cref="INode"/>.
    /// </param>
    /// <param name="newNode">
    ///     The child <see cref="INode"/> to replace the child <see cref="INode"/> at <paramref name="index"/> with.
    /// </param>
    /// <returns>
    ///     <para>
    ///         The previous <see cref="INode"/> at the location if there was an <see cref="INode"/> at <paramref name="index"/>
    ///         (so every index except if <paramref name="index"/> is equal to the <see cref="NumberOfChildren"/>.
    ///     </para>
    ///     <para>
    ///         If the <see cref="INode"/> was appended to the end because
    ///         <paramref name="index"/> was equal to the <see cref="NumberOfChildren"/>, <see langword="null"/>
    ///     </para>
    /// </returns>
    /// <exception cref="ArgumentOutOfRangeException">
    ///     If the <paramref name="index"/> is negative (less than 0).
    /// </exception>
    /// <exception cref="ArgumentOutOfRangeException">
    ///     If the <paramref name="index"/> is greater or equal to the number of children (returned by <see cref="NumberOfChildren"/>).
    /// </exception>
    /// <remarks>
    ///     If the returned the value is not necessary and can be freed by the garbage collector, use <see cref="SetChildAtAndDiscard"/> instead which
    ///     has the same behavior with the same parameters aside for the fact that it doesn't return the <see cref="INode"/> that may have been replaced by
    ///     <paramref name="newNode"/>
    /// </remarks>
    public INode? SetChildAt(int index, INode newNode);
    
    /// <summary>
    ///     <para>
    ///         Sets the <paramref name="newNode"/> to be the child <see cref="INode"/> at <paramref name="index"/>
    ///         in place of the <see cref="INode"/> that may be there already.
    ///         If the <paramref name="index"/> is equal to the <see cref="NumberOfChildren"/>,
    ///         this instead appends <paramref name="newNode"/> to the end as an added last child in order.
    ///     </para>
    ///     <para>
    ///         When setting the value, the <see cref="INode"/> at that <paramref name="index"/> will be detached
    ///         (turned into its own root <see cref="INode"/> in its own tree).
    ///         The <paramref name="newNode"/> <see cref="INode"/> will be attached at the position where
    ///         the detached <see cref="INode"/> was.
    ///         That <see cref="INode"/>'s content will be turned into a child of this <see cref="INode"/>.
    ///         If it had a parent, it will be detached from that parent before (turned into its own root <see cref="INode"/> in its own tree).
    ///     </para>
    ///     <para>
    ///         If the <paramref name="index"/> is equal to the <see cref="NumberOfChildren"/>,
    ///         this instead appends this <see cref="newNode"/> to the end as an added last child in order (without removing any other <see cref="INode"/>).
    ///     </para>
    /// </summary>
    /// <param name="index">
    ///     The index in the <see cref="List{T}"/> or <see cref="List{T}"/>-like (or <see cref="Array"/>-like) object of the child <see cref="INode"/>.
    /// </param>
    /// <param name="newNode">
    ///     The child <see cref="INode"/> to replace the child <see cref="INode"/> at <paramref name="index"/> with.
    /// </param>
    /// <exception cref="ArgumentOutOfRangeException">
    ///     If the <paramref name="index"/> is negative (less than 0).
    /// </exception>
    /// <exception cref="ArgumentOutOfRangeException">
    ///     If the <paramref name="index"/> is greater or equal to the number of children (returned by <see cref="NumberOfChildren"/>).
    /// </exception>
    /// <remarks>
    ///     If you need to use the <see cref="INode"/> that used to be at <paramref name="index"/>, this method discards that node.
    ///     Use <see cref="SetChildAt"/> instead. It has the same exact behavior with the same exact parameters except for the fact that it keeps
    ///     and returns the <see cref="INode"/> that may have been replaced by <paramref name="newNode"/> at <paramref name="index"/>.
    /// </remarks>
    public void SetChildAtAndDiscard(int index, INode newNode);
    
    public INode SetChildAt<TNode>(int index, TNode newNode) where TNode : INode;
    
    public void SetChildAtAndDiscard<TNode>(int index, TNode newNode) where TNode : INode;
}
