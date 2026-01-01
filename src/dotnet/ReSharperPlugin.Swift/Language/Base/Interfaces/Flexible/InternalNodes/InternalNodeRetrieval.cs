using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using ReSharperPlugin.Swift.Language.Base.Interfaces.Flexible.Root;
using ReSharperPlugin.Swift.Technology.Exceptions;

namespace ReSharperPlugin.Swift.Language.Base.Interfaces.Flexible.InternalNodes;

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

    /// <summary>
    ///     <para>
    ///         Retrieve an <see cref="IEnumerator{INode}"/>
    ///         which enables iterating over all the children <see cref="INode"/>s in order of their indexes
    ///         from lowest to highest.
    ///     </para>
    ///     <para>
    ///         A call to <see cref="IEnumerator{INode}.MoveNext"/> must be performed before
    ///         being able to use the first <see cref="INode"/>, accessible with <see cref="IEnumerator{INode}.Current"/>.
    ///         This call must also be performed after a call to <see cref="IEnumerator{INode}.Reset"/>.
    ///         Failing to do so will result in an <see cref="EnumeratorInInitialPositionException"/>
    ///         being thrown.
    ///     </para>
    ///     <para>
    ///         This enumerator can be reset (by calling  <see cref="IEnumerator{INode}.Reset"/>) to before the first child safely.
    ///     </para>
    ///     <para>
    ///         This enumerator must be disposed of using <see cref="IEnumerator{INode}.Dispose"/>
    ///         when it is no longer needed.
    ///     </para>
    /// </summary>
    /// <returns>
    ///     The <see cref="IEnumerator{INode}"/> object which must be disposed of after it is done being used.
    /// </returns>
    [MustDisposeResource]
    public IEnumerator<INode> GetChildEnumerator();

    /// <summary>
    ///     <para>
    ///         Retrieve an <see cref="IEnumerator{INode}"/>
    ///         which enables iterating over all the children <see cref="INode"/>s in order of their indexes
    ///         from lowest to highest, starting at <paramref name="startIndex"/> included.
    ///     </para>
    ///     <para>
    ///         A call to <see cref="IEnumerator{INode}.MoveNext"/> must be performed before
    ///         being able to use the first <see cref="INode"/>, accessible with <see cref="IEnumerator{INode}.Current"/>.
    ///         This call must also be performed after a call to <see cref="IEnumerator{INode}.Reset"/>
    ///         Failing to do so will result in an <see cref="EnumeratorInInitialPositionException"/>
    ///         being thrown.
    ///     </para>
    ///     <para>
    ///         The first call to <see cref="IEnumerator.MoveNext"/> will result in
    ///         <see cref="IEnumerator{INode}.Current"/> being the child <see cref="INode"/>
    ///         at index <paramref name="startIndex"/>.
    ///     </para>
    ///     <para>
    ///         This enumerator can be reset (by calling  <see cref="IEnumerator{INode}.Reset"/>) to before the first child safely.    ///     </para>
    ///     <para>
    ///         This enumerator must be disposed of using <see cref="IEnumerator{INode}.Dispose"/>
    ///         when it is no longer needed.
    ///     </para>
    /// </summary>
    /// <param name="startIndex">
    ///     <para>
    ///         The index of the child <see cref="INode"/> which should be the first to appear in the
    ///         <see cref="IEnumerator{INode}"/> after calling <see cref="IEnumerator{INode}.MoveNext"/>
    ///         and retrieving the first child with <see cref="IEnumerator{INode}.Current"/>.
    ///     </para>
    ///     <para>
    ///         The enumerator will then proceed to go through all the child <see cref="INode"/>s with
    ///         an index greater than the <paramref name="startIndex"/>, from lowest index to highest index.
    ///     </para>
    ///     <para>
    ///         The index of the child <see cref="INode"/>which should be the first to appear in the
    ///         <see cref="IEnumerator{INode}"/> must be obtained after a call to <see cref="IEnumerator{INode}.MoveNext"/>
    ///         first. <see cref="IEnumerator{INode}.MoveNext"/> must also be called after <see cref="IEnumerator{INode}.Reset"/>
    ///         was called first before being able to access the <see cref="INode"/>s.
    ///         Failure to do so will result in an <see cref="EnumeratorInInitialPositionException"/>
    ///         being thrown.
    ///     </para>
    /// </param>
    /// <returns>
    ///     The <see cref="IEnumerator{INode}"/> object which must be disposed of after it is done being used.
    /// </returns>
    /// <exception cref="ArgumentOutOfRangeException">
    ///     The <paramref name="startIndex"/> is negative (less than 0).
    /// </exception>
    /// <exception cref="ArgumentOutOfRangeException">
    ///     The <paramref name="startIndex"/> is greater or equal to the <see cref="NumberOfChildren"/>.
    /// </exception>
    [MustDisposeResource]
    public IEnumerator<INode> GetChildEnumerator(int startIndex);

    /// <summary>
    ///     <para>
    ///         Retrieve an <see cref="IEnumerator{INode}"/>
    ///         which enables iterating over all the children <see cref="INode"/>s in order of their indexes
    ///         from lowest to highest, starting at <paramref name="startIndex"/> included and going for <paramref name="count"/>
    ///         children <see cref="INode"/>s in the <see cref="IInternalNode"/>.
    ///     </para>
    ///     <para>
    ///         A call to <see cref="IEnumerator{INode}.MoveNext"/> must be performed before
    ///         being able to use the first <see cref="INode"/>, accessible with <see cref="IEnumerator{INode}.Current"/>.
    ///         This call must also be performed after a call to <see cref="IEnumerator{INode}.Reset"/>
    ///         Failing to do so will result in an <see cref="EnumeratorInInitialPositionException"/>
    ///         being thrown.
    ///     </para>
    ///     <para>
    ///         The first call to <see cref="IEnumerator.MoveNext"/> will result in
    ///         <see cref="IEnumerator{INode}.Current"/> being the child <see cref="INode"/>
    ///         at index <paramref name="startIndex"/> or if <paramref name="count"/> is 0,
    ///         then there are no children <see cref="INode"/>s to go over // TODO finish this
    ///     </para>
    ///     <para>
    ///         This enumerator can be reset to before the child at index <paramref name="startIndex"/> safely.
    ///     </para>
    ///     <para>
    ///         This enumerator must be disposed of using <see cref="IEnumerator{INode}.Dispose"/>
    ///         when it is no longer needed.
    ///     </para>
    /// </summary>
    /// <param name="startIndex">
    ///     <para>
    ///         The index of the child <see cref="INode"/> which should be the first to appear in the
    ///         <see cref="IEnumerator{INode}"/>.
    ///     </para>
    ///     <para>
    ///         The enumerator will then proceed to go through <paramref name="count"/> child <see cref="INode"/>s
    ///         starting from the <paramref name="startIndex"/>, from lowest index to highest index.
    ///     </para>
    ///     <para>
    ///         The index of the child <see cref="INode"/> which should be the first to appear in the
    ///         <see cref="IEnumerator{INode}"/> must be obtained after a call to <see cref="IEnumerator{INode}.MoveNext"/>
    ///         first. <see cref="IEnumerator{INode}.MoveNext"/> must also be called after <see cref="IEnumerator{INode}.Reset"/>
    ///         was called first before being able to access the <see cref="INode"/>s.
    ///         Failure to do so will result in an <see cref="EnumeratorInInitialPositionException"/>
    ///         being thrown.
    ///     </para>
    /// </param>
    /// <param name="count">
    ///     <para>
    ///         The number of child <see cref="INode"/>s to iterate over.
    ///     </para>
    /// </param>
    /// <returns>
    ///     The <see cref="IEnumerator{INode}"/> object which must be disposed of after it is done being used.
    /// </returns>
    /// <exception cref="ArgumentOutOfRangeException">
    ///     The <paramref name="startIndex"/> is negative (less than 0).
    /// </exception>
    /// <exception cref="ArgumentOutOfRangeException">
    ///     The <paramref name="startIndex"/> is greater or equal to the <see cref="NumberOfChildren"/>.
    /// </exception>
    /// <exception cref="ArgumentOutOfRangeException">
    ///     The <paramref name="count"/> is negative (less than 0).
    /// </exception>
    /// <exception cref="ArgumentException">
    ///     The <paramref name="startIndex"/> plus <paramref name="count"/> is greater than the <see cref="NumberOfChildren"/>.
    /// </exception>
    [MustDisposeResource]
    public IEnumerator<INode> GetChildEnumerator(int startIndex, int count);

    /// <summary>
    ///     <para>
    ///         Retrieve an <see cref="IEnumerator{INode}"/>
    ///         which enables iterating over all the children <see cref="INode"/>s in order of their indexes
    ///         from lowest to highest, starting at <paramref name="startIndex"/> included and stopping before <paramref name="endIndex"/>.
    ///     </para>
    ///     <para>
    ///         A call to <see cref="IEnumerator{INode}.MoveNext"/> must be performed before
    ///         being able to use the first <see cref="INode"/>, accessible with <see cref="IEnumerator{INode}.Current"/>.
    ///         This call must also be performed after a call to <see cref="IEnumerator{INode}.Reset"/>
    ///         Failing to do so will result in an <see cref="EnumeratorInInitialPositionException"/>
    ///         being thrown.
    ///     </para>
    ///     <para>
    ///         The first call to <see cref="IEnumerator.MoveNext"/> will result in
    ///         <see cref="IEnumerator{INode}.Current"/> being the child <see cref="INode"/>
    ///         at index <paramref name="startIndex"/>.
    ///     </para>
    ///     <para>
    ///         This enumerator can be reset to before the child at index <paramref name="startIndex"/> safely.
    ///     </para>
    ///     <para>
    ///         This enumerator must be disposed of using <see cref="IEnumerator{INode}.Dispose"/>
    ///         when it is no longer needed.
    ///     </para>
    /// </summary>
    /// <param name="startIndex">
    ///     <para>
    ///         The index of the child <see cref="INode"/> which should be the first to appear in the
    ///         <see cref="IEnumerator{INode}"/>.
    ///     </para>
    ///     <para>
    ///         The enumerator will then proceed to go through all the child <see cref="INode"/>s
    ///         starting from the <paramref name="startIndex"/> up to, but not including, the <paramref name="endIndex"/>,
    ///         from lowest index to highest index.
    ///     </para>
    ///     <para>
    ///         The index of the child <see cref="INode"/> which should be the first to appear in the
    ///         <see cref="IEnumerator{INode}"/> must be obtained after a call to <see cref="IEnumerator{INode}.MoveNext"/>
    ///         first. <see cref="IEnumerator{INode}.MoveNext"/> must also be called after <see cref="IEnumerator{INode}.Reset"/>
    ///         was called first before being able to access the <see cref="INode"/>s.
    ///         Failure to do so will result in an <see cref="EnumeratorInInitialPositionException"/>
    ///         being thrown.
    ///     </para>
    /// </param>
    /// <param name="endIndex">
    ///     <para>
    ///         The exclusive upper bound of the range. The enumerator will stop before reaching this index.
    ///         The child <see cref="INode"/> at this index will not be included in the iteration.
    ///     </para>
    /// </param>
    /// <returns>
    ///     The <see cref="IEnumerator{INode}"/> object which must be disposed of after it is done being used.
    /// </returns>
    /// <exception cref="ArgumentOutOfRangeException">
    ///     The <paramref name="startIndex"/> is negative (less than 0).
    /// </exception>
    /// <exception cref="ArgumentOutOfRangeException">
    ///     The <paramref name="endIndex"/> is greater than the <see cref="NumberOfChildren"/>.
    /// </exception>
    /// <exception cref="ArgumentException">
    ///     The <paramref name="startIndex"/> is greater than the <paramref name="endIndex"/>.
    /// </exception>
    [MustDisposeResource]
    public IEnumerator<INode> GetChildEnumeratorOverRange(int startIndex, int endIndex);

    public IEnumerable<INode> GetChildNodesAsEnumerable();

    public IEnumerable<INode> GetChildNodesAsEnumerable(int startIndex);

    public IEnumerable<INode> GetChildNodesAsEnumerable(int startIndex, int count);

    public IEnumerable<INode> GetChildNodesAsEnumerableOverRange(int startIndex, int endIndex);

    public IReadOnlyList<INode> GetChildNodesAsGenericReadOnlyListType();

    public IReadOnlyList<INode> GetChildNodesAsGenericReadOnlyListType(int startIndex);

    public IReadOnlyList<INode> GetChildNodesAsGenericReadOnlyListType(int startIndex, int count);

    public IReadOnlyList<INode> GetChildNodesAsGenericReadOnlyListTypeOverRange(int startIndex, int endIndex);
    
    public IList<INode> GetChildNodesAsGenericListType();

    public IList<INode> GetChildNodesAsGenericListType(int startIndex);

    public IList<INode> GetChildNodesAsGenericListType(int startIndex, int count);

    public IList<INode> GetChildNodesAsGenericListTypeOverRange(int startIndex, int endIndex);

    public List<INode> GetChildNodesAsList();

    public List<INode> GetChildNodesAsList(int startIndex);

    public List<INode> GetChildNodesAsList(int startIndex, int count);

    public List<INode> GetChildNodesAsListOverRange(int startIndex, int endIndex);

    public TList GetChildNodesAsGenericListType<TList>()
        where TList : IList<INode>, new();

    public TList GetChildNodesAsGenericListType<TList>(int startIndex)
        where TList : IList<INode>, new();

    public TList GetChildNodesAsGenericListType<TList>(int startIndex, int count)
        where TList : IList<INode>, new();

    public TList GetChildNodesAsGenericListTypeOverRange<TList>(int startIndex, int endIndex)
        where TList : IList<INode>, new();

    public IEnumerator<INode> GetSelectiveNodesEnumerator(Func<INode, bool> predicate);

    public IEnumerator<INode> GetSelectiveNodesEnumerator(Func<INode, bool> predicate, int startIndex);

    public IEnumerator<INode> GetSelectiveNodesEnumerator(Func<INode, bool> predicate, int startIndex, int count);

    public IEnumerator<INode> GetSelectiveNodesEnumeratorOverRange(Func<INode, bool> predicate, int startIndex,
        int endIndex);

    public IEnumerable<INode> GetSelectiveNodesAsEnumerable(Func<INode, bool> predicate);

    public IEnumerable<INode> GetSelectiveNodesAsEnumerable(Func<INode, bool> predicate, int startIndex);

    public IEnumerable<INode> GetSelectiveNodesAsEnumerable(Func<INode, bool> predicate, int startIndex, int count);

    public IEnumerable<INode> GetSelectiveNodesAsEnumerableOverRange(Func<INode, bool> predicate, int startIndex, int endIndex);

    public IList<INode> GetSelectiveNodesAsGenericListType(Func<INode, bool> predicate);

    public IList<INode> GetSelectiveNodesAsGenericListType(Func<INode, bool> predicate, int startIndex);

    public IList<INode> GetSelectiveNodesAsGenericListType(Func<INode, bool> predicate, int startIndex, int count);

    public IList<INode> GetSelectiveNodesAsGenericListTypeOverRange(Func<INode, bool> predicate, int startIndex,
        int endIndex);

    public List<INode> GetSelectiveNodesAsList(Func<INode, bool> predicate);

    public List<INode> GetSelectiveNodesAsList(Func<INode, bool> predicate, int startIndex);

    public List<INode> GetSelectiveNodesAsList(Func<INode, bool> predicate, int startIndex, int count);

    public List<INode> GetSelectiveNodesAsListOverRange(Func<INode, bool> predicate, int startIndex, int endIndex);

    public TList GetSelectiveNodesAsGenericListType<TList>(Func<INode, bool> predicate)
        where TList : IList<INode>, new();

    public TList GetSelectiveNodesAsGenericListType<TList>(Func<INode, bool> predicate, int startIndex)
        where TList : IList<INode>, new();

    public TList GetSelectiveNodesAsGenericListType<TList>(Func<INode, bool> predicate,
        int startIndex, int count)
        where TList : IList<INode>, new();

    public TList GetSelectiveNodesAsGenericListTypeOverRange<TList>(Func<INode, bool> predicate,
        int startIndex, int endIndex)
        where TList : IList<INode>, new();
}