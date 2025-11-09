using System.Collections;
using System.Collections.Generic;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Statements.StatementGroups;

public class StatementGroup : IList<IStatement>
{
    public IEnumerator<IStatement> GetEnumerator()
    {
        throw new System.NotImplementedException();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Add(IStatement item)
    {
        throw new System.NotImplementedException();
    }

    public void Clear()
    {
        throw new System.NotImplementedException();
    }

    public bool Contains(IStatement item)
    {
        throw new System.NotImplementedException();
    }

    public void CopyTo(IStatement[] array, int arrayIndex)
    {
        throw new System.NotImplementedException();
    }

    public bool Remove(IStatement item)
    {
        throw new System.NotImplementedException();
    }

    public int Count { get; }
    public bool IsReadOnly { get; }
    public int IndexOf(IStatement item)
    {
        throw new System.NotImplementedException();
    }

    public void Insert(int index, IStatement item)
    {
        throw new System.NotImplementedException();
    }

    public void RemoveAt(int index)
    {
        throw new System.NotImplementedException();
    }

    public IStatement this[int index]
    {
        get => throw new System.NotImplementedException();
        set => throw new System.NotImplementedException();
    }
}