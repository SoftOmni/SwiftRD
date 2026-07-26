using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Functions.ParameterClauses;

public class ParameterClause : SwiftCompositeNode, IParameterClause
{
    public LeftParenthesis ParametersStart { get; }

    public IParameterList ParameterList { get; }

    public RightParenthesis ParametersEnd { get; }

    internal ParameterClause(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        LeftParenthesis parametersStart, IParameterList parameterList, RightParenthesis parametersEnd)
        : base(buffer, children)
    {
        ParametersStart = parametersStart;
        ParameterList = parameterList;
        ParametersEnd = parametersEnd;
    }

    IReadOnlyParameterList IReadOnlyParameterClause.ParameterList => ParameterList;

    public IReadOnlyList<IParameter> Parameters => ParameterList.Parameters;

    IReadOnlyList<IReadOnlyParameter> IReadOnlyParameterClause.Parameters => Parameters;

    public int Count => ParameterList.Count;

    public bool IsReadOnly => ParameterList.IsReadOnly;

    public new IParameter this[int index]
    {
        get => ParameterList[index];
        set => ParameterList[index] = value;
    }

    IReadOnlyParameter IReadOnlyList<IReadOnlyParameter>.this[int index]
        => ParameterList[index];

    IReadOnlyParameter IReadOnlyParameterClause.this[int index] 
        => ParameterList[index];

    public IEnumerator<IParameter> GetEnumerator()
    {
        return ParameterList.GetEnumerator();
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
        return ParameterList.Contains(item);
    }

    public void CopyTo(IParameter[] array, int arrayIndex)
    {
        ParameterList.CopyTo(array, arrayIndex);
    }

    public int IndexOf(IParameter item)
    {
        return ParameterList.IndexOf(item);
    }

    public void Add(IParameter item)
    {
        ParameterList.Add(item);
    }

    public void Clear()
    {
        ParameterList.Clear();
    }

    public bool Remove(IParameter item)
    {
        return ParameterList.Remove(item);
    }

    public void Insert(int index, IParameter item)
    {
        ParameterList.Insert(index, item);
    }

    public void RemoveAt(int index)
    {
        ParameterList.RemoveAt(index);
    }

    public void ChangeParameterList(IParameterList newParameterList)
    {
        throw new NotImplementedException();
    }
}
