using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.LoopStatements.Conditions;

public class ConditionList : SwiftCompositeNode, IConditionList
{
    private readonly List<ICondition> _conditions;

    private readonly List<Comma> _commas;

    internal ConditionList(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        List<ICondition> conditions, List<Comma> commas)
        : base(buffer, children)
    {
        _conditions = conditions;
        _commas = commas;
    }

    public IReadOnlyList<ICondition> Conditions => _conditions;
    
    IReadOnlyList<IReadOnlyCondition> IReadOnlyConditionList.Conditions => Conditions;

    public IReadOnlyList<Comma> Commas => _commas;

    public int Count => _conditions.Count;

    public bool IsReadOnly => false;

    public new ICondition this[int index]
    {
        get => _conditions[index];
        set => throw new NotImplementedException();
    }

    IReadOnlyCondition IReadOnlyList<IReadOnlyCondition>.this[int index]
        => _conditions[index];

    IReadOnlyCondition IReadOnlyConditionList.this[int index]
        => _conditions[index];

    public IEnumerator<ICondition> GetEnumerator()
    {
        return _conditions.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    IEnumerator<IReadOnlyCondition> IEnumerable<IReadOnlyCondition>.GetEnumerator()
    {
        return GetEnumerator();
    }

    public bool Contains(ICondition item)
    {
        return _conditions.Contains(item);
    }

    public int IndexOf(ICondition item)
    {
        return _conditions.IndexOf(item);
    }

    public void CopyTo(ICondition[] array, int arrayIndex)
    {
        _conditions.CopyTo(array, arrayIndex);
    }

    public void Add(ICondition item)
    {
        throw new NotImplementedException();
    }

    public void Clear()
    {
        throw new NotImplementedException();
    }

    public bool Remove(ICondition item)
    {
        throw new NotImplementedException();
    }

    public void Insert(int index, ICondition item)
    {
        throw new NotImplementedException();
    }

    public void RemoveAt(int index)
    {
        throw new NotImplementedException();
    }
}
