using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.ErrorNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Generics.ArgumentClauses;

public class IncompleteGenericArgumentGroup : SwiftErrorCompositeNode, IGenericArgumentGroup
{
    public IGenericArgumentClause? EditableGenericArgumentClause { get; private set; }

    public IReadOnlyGenericArgumentClause? GenericArgumentClause { get; private set; }
    
    private readonly List<IType> _genericArgumentTypes;

    private readonly List<IGenericArgument> _genericArguments;

    private readonly List<Comma> _commas;

    internal IncompleteGenericArgumentGroup(
        IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>?> children,
        List<IGenericArgument> genericArguments, List<IType> genericArgumentTypes, List<Comma> commas, string message
    )
        : base(buffer, children, message)
    {
        _genericArguments = genericArguments;
        _genericArgumentTypes = genericArgumentTypes;
        _commas = commas;
    }

    protected override void UpdateParentRelatedNodeConfiguration()
    {
        switch (Parent)
        {
            case IGenericArgumentClause genericArgumentClause:
                EditableGenericArgumentClause = genericArgumentClause;
                GenericArgumentClause = genericArgumentClause;
                break;
            case IReadOnlyGenericArgumentClause readOnlyGenericArgumentClause:
                GenericArgumentClause = readOnlyGenericArgumentClause;
                break;
        }
    }

    public IReadOnlyList<IGenericArgument> GenericArguments => _genericArguments;

    public IReadOnlyList<IType> GenericArgumentTypes => _genericArgumentTypes;

    public IReadOnlyList<Comma> Commas => _commas;


    public IEnumerator<IGenericArgument> GetEnumerator()
    {
        return GenericArguments.GetEnumerator();
    }
    
    IEnumerator<IType> IEnumerable<IType>.GetEnumerator()
    {
        return GenericArgumentTypes.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
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
        throw new NotImplementedException();
    }

    public bool Contains(IGenericArgument item)
    {
        throw new NotImplementedException();
    }

    public void CopyTo(IType[] array, int arrayIndex)
    {
        throw new NotImplementedException();
    }

    public void CopyTo(IGenericArgument[] array, int arrayIndex)
    {
        throw new NotImplementedException();
    }

    public bool Remove(IType item)
    {
        throw new NotImplementedException();
    }

    public bool Remove(IGenericArgument item)
    {
        throw new NotImplementedException();
    }

    public int Count => GenericArguments.Count;

    public bool IsReadOnly => false;

    public int IndexOf(IType item)
    {
        throw new NotImplementedException();
    }

    public int IndexOf(IGenericArgument item)
    {
        throw new NotImplementedException();
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

    IType IList<IType>.this[int index]
    {
        get => GenericArgumentTypes[index];
        set => throw new NotImplementedException();
    }

    IType IReadOnlyList<IType>.this[int index] => GenericArgumentTypes[index];

    public new IGenericArgument this[int index]
    {
        get => GenericArguments[index];
        set => throw new NotImplementedException();
    }
}