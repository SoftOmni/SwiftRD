using System.Collections;
using System.Collections.Generic;
using JetBrains.Text;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Statements.BranchStatements.Switches.SwitchCases;

public class SwitchCaseGroup : SwiftInternalNode, IList<SwitchCase>
{
    private List<SwitchCase> _cases = [];
    
    public SwitchCaseGroup(IEditableBuffer buffer, List<ISwiftNode> children)
        : base(buffer, children)
    { }

    public SwitchCaseGroup(IEditableBuffer buffer, IEnumerable<ISwiftNode> children)
        : base(buffer, children)
    { }

    public SwitchCaseGroup(ISwiftNode parent, IEditableBuffer buffer, List<ISwiftNode> nodes)
        : base(parent, buffer, nodes)
    { }

    public SwitchCaseGroup(ISwiftNode parent, IEditableBuffer buffer, IEnumerable<ISwiftNode> nodes)
        : base(parent, buffer, nodes)
    { }

    public IReadOnlyList<SwitchCase> Cases => _cases;

    public IEnumerator<SwitchCase> GetEnumerator()
    {
        throw new System.NotImplementedException();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Add(SwitchCase item)
    {
        throw new System.NotImplementedException();
    }

    public void Clear()
    {
        throw new System.NotImplementedException();
    }

    public bool Contains(SwitchCase item)
    {
        throw new System.NotImplementedException();
    }

    public void CopyTo(SwitchCase[] array, int arrayIndex)
    {
        throw new System.NotImplementedException();
    }

    public bool Remove(SwitchCase item)
    {
        throw new System.NotImplementedException();
    }

    public int Count { get; }
    public bool IsReadOnly { get; }
    public int IndexOf(SwitchCase item)
    {
        throw new System.NotImplementedException();
    }

    public void Insert(int index, SwitchCase item)
    {
        throw new System.NotImplementedException();
    }

    public void RemoveAt(int index)
    {
        throw new System.NotImplementedException();
    }

    public SwitchCase this[int index]
    {
        get => throw new System.NotImplementedException();
        set => throw new System.NotImplementedException();
    }
}