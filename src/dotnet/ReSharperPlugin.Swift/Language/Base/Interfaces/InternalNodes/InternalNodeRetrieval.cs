using System;
using System.Collections.Generic;

namespace ReSharperPlugin.Swift.Language.Base;

public partial interface IInternalNode
{
    /// <summary>
    ///     <para>
    ///         Retrieve the child <see cref="INode"/> at the <paramref name="index"/>.
    ///     </para>
    /// </summary>
    /// <param name="index">
    ///     The index in the <see cref="List{T}"/> or <see cref="List{T}"/>-like (or <see cref="Array"/>-like) object of the child <see cref="INode"/>.
    /// </param>
    /// <returns>
    ///     The <see cref="INode"/> at the given <paramref name="index"/>.
    /// </returns>
    /// <remarks>
    ///     <para>
    ///         This is equivalent to retrieving the node through <see cref="this[int]"/> with the same <paramref name="index"/>.
    ///     </para>
    /// </remarks>
    /// <exception cref="ArgumentOutOfRangeException">
    ///     If the <paramref name="index"/> is negative (less than 0).
    /// </exception>
    /// <exception cref="ArgumentOutOfRangeException">
    ///     If the <paramref name="index"/> is greater or equal to the <see cref="NumberOfChildren"/>.
    /// </exception>
    public INode GetChildAt(int index);
}