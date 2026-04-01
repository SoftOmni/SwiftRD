using System;
using System.Collections;
using System.Collections.Generic;

namespace SoftOmni.SwiftRd.Technology;

public class ModularVisibilityHashSet<T> : ISet<T>, IReadOnlySet<T>
{
    private readonly HashSet<T> _hashSet;

    public ModularVisibilityHashSet()
    {
        _hashSet = [];
    }
    
    public ModularVisibilityHashSet(IEnumerable<T> collection)
    {
        _hashSet = new HashSet<T>(collection);
    }

    public ModularVisibilityHashSet(IEnumerable<T> collection, IEqualityComparer<T> comparer)
    {
        _hashSet = new HashSet<T>(collection, comparer);
    }
    
    public bool Contains(T item)
    {
        return _hashSet.Contains(item);
    }

    public IEnumerator<T> GetEnumerator()
    {
        return _hashSet.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    void ICollection<T>.Add(T item)
    {
        Add(item);
    }

    public void UnionWith(IEnumerable<T> other)
    {
        _hashSet.UnionWith(other);
    }

    public void IntersectWith(IEnumerable<T> other)
    {
        _hashSet.IntersectWith(other);
    }

    public void ExceptWith(IEnumerable<T> other)
    {
        _hashSet.ExceptWith(other);
    }

    public void SymmetricExceptWith(IEnumerable<T> other)
    {
        _hashSet.SymmetricExceptWith(other);
    }

    public bool IsSubsetOf(IEnumerable<T> other)
    {
        return _hashSet.IsSubsetOf(other);
    }

    public bool IsSupersetOf(IEnumerable<T> other)
    {
        return _hashSet.IsSupersetOf(other);
    }

    public bool IsProperSupersetOf(IEnumerable<T> other)
    {
        return _hashSet.IsProperSupersetOf(other);
    }

    public bool IsProperSubsetOf(IEnumerable<T> other)
    {
        return _hashSet.IsProperSubsetOf(other);
    }

    public bool Overlaps(IEnumerable<T> other)
    {
        return _hashSet.Overlaps(other);
    }

    public bool SetEquals(IEnumerable<T> other)
    {
        return _hashSet.SetEquals(other);
    }

    public bool Add(T item)
    {
        return _hashSet.Add(item);
    }

    public void Clear()
    {
        _hashSet.Clear();
    }

    public void CopyTo(T[] array)
    {
        CopyTo(array, 0);
    }

    public void CopyTo(T[] array, int arrayIndex)
    {
        CopyTo(array, arrayIndex, Count);
    }

    public void CopyTo(T[] array, int arrayIndex, int count)
    {
        _hashSet.CopyTo(array, arrayIndex, count);
    }

    public bool Remove(T item)
    {
        return _hashSet.Remove(item);
    }

    public int RemoveWhere(Predicate<T> match)
    {
        return _hashSet.RemoveWhere(match);
    }

    public int Count => _hashSet.Count;

    public bool IsReadOnly => false;
    
    public IEqualityComparer<T> Comparer => _hashSet.Comparer;
    
    public void TrimExcess()
    {
        _hashSet.TrimExcess();
    }
}