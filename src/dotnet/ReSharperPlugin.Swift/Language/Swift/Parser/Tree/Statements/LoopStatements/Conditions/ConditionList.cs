using System.Collections;
using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.LoopStatements.Conditions;

public class ConditionList : StatementInternalNode, IList<ICondition>
{
    private List<ICondition> _conditions = [];

    private List<Comma> _commas = [];
    
    public ConditionList(IEditableBuffer buffer, List<ISwiftNode> children)
        : base(buffer, children)
    { }

    public ConditionList(IEditableBuffer buffer, IEnumerable<ISwiftNode> children)
        : base(buffer, children)
    { }

    public ConditionList(SwiftInternalNode parent, IEditableBuffer buffer, List<ISwiftNode> nodes)
        : base(parent, buffer, nodes)
    { }

    public ConditionList(SwiftInternalNode parent, IEditableBuffer buffer, IEnumerable<ISwiftNode> nodes)
        : base(parent, buffer, nodes)
    { }

    public IReadOnlyList<ICondition> Conditions => _conditions;

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public IEnumerator<ICondition> GetEnumerator()
    {
        throw new System.NotImplementedException();
    }

    public void Add(ICondition item)
    {
        throw new System.NotImplementedException();
    }

    public void Clear()
    {
        throw new System.NotImplementedException();
    }

    public bool Contains(ICondition item)
    {
        throw new System.NotImplementedException();
    }

    public void CopyTo(ICondition[] array, int arrayIndex)
    {
        throw new System.NotImplementedException();
    }

    public bool Remove(ICondition item)
    {
        throw new System.NotImplementedException();
    }

    public int Count { get; }
    public bool IsReadOnly { get; }
    public int IndexOf(ICondition item)
    {
        throw new System.NotImplementedException();
    }

    public void Insert(int index, ICondition item)
    {
        throw new System.NotImplementedException();
    }

    public void RemoveAt(int index)
    {
        throw new System.NotImplementedException();
    }

    public ICondition this[int index]
    {
        get => throw new System.NotImplementedException();
        set => throw new System.NotImplementedException();
    }
}