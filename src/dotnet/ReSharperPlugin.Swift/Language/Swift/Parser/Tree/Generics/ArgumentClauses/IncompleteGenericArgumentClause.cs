using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.ErrorNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Generics.ArgumentClauses;

public class IncompleteGenericArgumentClause : SwiftErrorCompositeNode, IGenericArgumentClause
{
    public LeftAngleBracket? LeftAngleBracket { get; internal set; }
    
    public IGenericArgumentGroup? GenericArgumentGroup { get; internal set; }
    
    IReadOnlyGenericArgumentGroup? IReadOnlyGenericArgumentClause.GenericArgumentGroup => GenericArgumentGroup;

    public RightAngleBracket? RightAngleBracket { get; internal set; }

    internal IncompleteGenericArgumentClause(IEditableBuffer buffer, string message,
        LeftAngleBracket? leftAngleBracket = null, IGenericArgumentGroup? genericArgumentGroup = null, 
        RightAngleBracket? rightAngleBracket = null) 
        : base(buffer, [leftAngleBracket, genericArgumentGroup, rightAngleBracket], message)
    {
        
    }

    public void Add(IType item)
    {
        throw new NotImplementedException();
    }

    public void Add(IGenericArgument item)
    {
        throw new NotImplementedException();
    }

    public void Clear()
    {
        throw new NotImplementedException();
    }

    public bool Contains(IType item)
    {
        return GenericArgumentGroup?.Contains(item) ?? false;
    }

    public bool Contains(IGenericArgument item)
    {
        return GenericArgumentGroup?.Contains(item) ?? false;
    }

    public void CopyTo(IType[] array, int arrayIndex)
    {
        GenericArgumentGroup?.CopyTo(array, arrayIndex);
    }

    public void CopyTo(IGenericArgument[] array, int arrayIndex)
    {
        GenericArgumentGroup?.CopyTo(array, arrayIndex);
    }

    public bool Remove(IType item)
    {
        throw new NotImplementedException();
    }

    public bool Remove(IGenericArgument item)
    {
        throw new NotImplementedException();
    }

    public int Count => ((IReadOnlyCollection<IType>?)GenericArgumentGroup)?.Count ?? 0;

    public bool IsReadOnly => false;

    public int IndexOf(IType item)
    {
        return GenericArgumentGroup?.IndexOf(item) ?? -1;
    }

    public int IndexOf(IGenericArgument item)
    {
        return GenericArgumentGroup?.IndexOf(item) ?? -1;
    }

    public void Insert(int index, IType item)
    {
        throw new NotImplementedException();
    }

    public void Insert(int index, IGenericArgument item)
    {
        throw new NotImplementedException();
    }

    void IList<IType>.RemoveAt(int index)
    {
        throw new NotImplementedException();
    }

    public void RemoveAt(int index)
    {
        throw new NotImplementedException();
    }

    public bool CanBeConvertedIntoCorrectGenericArgumentClause => GenericArgumentGroup is not null;

    public bool ConvertToGenericArgumentClause()
    {
        throw new NotImplementedException();
    }

    public IEnumerator<IType> GetEnumerator()
    {
        if (GenericArgumentGroup is not null)
        {
            return ((IEnumerable<IType>)GenericArgumentGroup).GetEnumerator();
        }

        return Enumerable.Empty<IType>().GetEnumerator();
    }

    IEnumerator<IGenericArgument> IEnumerable<IGenericArgument>.GetEnumerator()
    {
        throw new NotImplementedException();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    IType IList<IType>.this[int index]
    {
        get =>
            GenericArgumentGroup is not null
                ? ((IReadOnlyList<IType>)GenericArgumentGroup)[index]
                : throw new ArgumentOutOfRangeException(nameof(index), "Index is out of range for the generic argument group.");
        set => throw new NotImplementedException();
    }

    public new IGenericArgument this[int index]
    {
        get => GenericArgumentGroup is not null 
                    ? ((IReadOnlyList<IGenericArgument>)GenericArgumentGroup)[index] 
                    : throw new ArgumentOutOfRangeException(nameof(index), "Index is out of range for the generic argument group.");
        set => throw new NotImplementedException();
    }

    IType IReadOnlyList<IType>.this[int index] => 
        GenericArgumentGroup is not null
            ? ((IReadOnlyList<IType>)GenericArgumentGroup)[index]
            : throw new ArgumentOutOfRangeException(nameof(index), "Index is out of range for the generic argument group.");

    public const string MissingArgumentsErrorMessage =
        "Missing types from generic argument clause. There are no types within the angle brackets";
}