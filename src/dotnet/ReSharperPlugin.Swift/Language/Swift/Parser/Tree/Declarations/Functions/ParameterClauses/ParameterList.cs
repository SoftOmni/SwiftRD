using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Functions.ParameterClauses;

public class ParameterList : SwiftCompositeNode, IParameterList
{
    private readonly List<IParameter> _parameters;

    private readonly List<Comma> _parameterSeparators;

    internal ParameterList(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        List<IParameter> parameters, List<Comma> parameterSeparators)
        : base(buffer, children)
    {
        _parameters = parameters;
        _parameterSeparators = parameterSeparators;
    }

    public IReadOnlyList<IParameter> Parameters => _parameters;

    IReadOnlyList<IReadOnlyParameter> IReadOnlyParameterList.Parameters => Parameters;

    public IReadOnlyList<Comma> ParameterSeparators => _parameterSeparators;

    public int Count => _parameters.Count;

    public bool IsReadOnly => false;

    public new IParameter this[int index]
    {
        get => _parameters[index];
        set => throw new NotImplementedException();
    }

    IReadOnlyParameter IReadOnlyParameterList.this[int index] => _parameters[index];

    IReadOnlyParameter IReadOnlyList<IReadOnlyParameter>.this[int index] => _parameters[index];

    public IEnumerator<IParameter> GetEnumerator()
    {
        return _parameters.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    IEnumerator<IReadOnlyParameter> IEnumerable<IReadOnlyParameter>.GetEnumerator()
    {
        return GetEnumerator();
    }

    public bool Contains(IParameter item)
    {
        return _parameters.Contains(item);
    }

    public int IndexOf(IParameter item)
    {
        return _parameters.IndexOf(item);
    }

    public void CopyTo(IParameter[] array, int arrayIndex)
    {
        _parameters.CopyTo(array, arrayIndex);
    }

    public void Add(IParameter item)
    {
        throw new NotImplementedException();
    }

    public void Clear()
    {
        throw new NotImplementedException();
    }

    public bool Remove(IParameter item)
    {
        throw new NotImplementedException();
    }

    public void Insert(int index, IParameter item)
    {
        throw new NotImplementedException();
    }

    public void RemoveAt(int index)
    {
        throw new NotImplementedException();
    }
}
