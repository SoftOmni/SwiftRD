using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Generics.ArgumentClauses;

public class GenericArgumentClause : ReadOnlyGenericArgumentClause, IGenericArgumentClause
{
    public new IGenericArgumentGroup GenericArgumentGroup { get; }

    internal GenericArgumentClause(IEditableBuffer buffer, LeftAngleBracket leftAngleBracket,
        GenericArgumentGroup genericArgumentGroup, RightAngleBracket rightAngleBracket)
        : base(buffer, leftAngleBracket, genericArgumentGroup, rightAngleBracket)
    {
        GenericArgumentGroup = genericArgumentGroup;
    }

    IEnumerator<IType> IEnumerable<IType>.GetEnumerator()
    {
        return ((IEnumerable<IType>)GenericArgumentGroup).GetEnumerator();
    }

    public new IEnumerator<IGenericArgument> GetEnumerator()
    {
        return GenericArgumentGroup.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Add(IType item)
    {
        GenericArgumentGroup.Add(item);
    }

    public void Add(IGenericArgument item)
    {
        throw new NotImplementedException();
    }

    public void Clear()
    {
        DetachFromParent();
    }

    public bool Contains(IType item)
    {
        return GenericArgumentGroup.Contains(item);
    }

    public bool Contains(IGenericArgument item)
    {
        throw new NotImplementedException();
    }

    public void CopyTo(IType[] array, int arrayIndex)
    {
        GenericArgumentGroup.CopyTo(array, arrayIndex);
    }

    public void CopyTo(IGenericArgument[] array, int arrayIndex)
    {
        throw new NotImplementedException();
    }

    public bool Remove(IType item)
    {
        return GenericArgumentGroup.Remove(item);
    }

    public bool Remove(IGenericArgument item)
    {
        throw new NotImplementedException();
    }

    public bool IsReadOnly => ((IList<IType>)GenericArgumentGroup).IsReadOnly;

    public int IndexOf(IType item)
    {
        return GenericArgumentGroup.IndexOf(item);
    }

    public int IndexOf(IGenericArgument item)
    {
        throw new NotImplementedException();
    }

    public void Insert(int index, IType item)
    {
        GenericArgumentGroup.Insert(index, item);
    }

    public void Insert(int index, IGenericArgument item)
    {
        throw new NotImplementedException();
    }

    void IList<IType>.RemoveAt(int index)
    {
        ((IList<IType>)GenericArgumentGroup).RemoveAt(index);
    }

    public void RemoveAt(int index)
    {
        ((IList<IGenericArgument>)GenericArgumentGroup).RemoveAt(index);
    }

    IType IList<IType>.this[int index]
    {
        get => ((IReadOnlyList<IType>)GenericArgumentGroup)[index];
        set => ((IList<IType>)GenericArgumentGroup)[index] = value;
    }

    IType IReadOnlyList<IType>.this[int index] => ((IReadOnlyList<IType>)GenericArgumentGroup)[index];

    public new IGenericArgument this[int index]
    {
        get => throw new NotImplementedException();
        set => throw new NotImplementedException();
    }
}