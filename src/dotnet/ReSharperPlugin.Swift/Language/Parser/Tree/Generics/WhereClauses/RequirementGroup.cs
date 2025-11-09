using System.Collections;
using System.Collections.Generic;
using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Parser.Tree;
using ReSharperPlugin.Swift.Language.Parser.Tree.Generics.WhereClauses;

namespace ReSharperPlugin.Swift.Rider.Language.Parser.Tree.Generics.WhereClauses;

public class RequirementGroup : SwiftInternalNode, IList<Requirement>
{
    public GenericWhereClause? GenericWhereClause { get; internal set; }
    
    private List<Requirement> _requirements = [];
    
    public RequirementGroup(IEditableBuffer buffer, List<ISwiftNode> children) 
        : base(buffer, children)
    { }

    public RequirementGroup(IEditableBuffer buffer, IEnumerable<ISwiftNode> children) 
        : base(buffer, children)
    { }

    public RequirementGroup(ISwiftNode parent, IEditableBuffer buffer, List<ISwiftNode> nodes) 
        : base(parent, buffer, nodes)
    { }

    public RequirementGroup(ISwiftNode parent, IEditableBuffer buffer, IEnumerable<ISwiftNode> nodes) 
        : base(parent, buffer, nodes)
    { }

    public IReadOnlyList<Requirement> Requirements => _requirements;

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public IEnumerator<Requirement> GetEnumerator()
    {
        throw new System.NotImplementedException();
    }

    public void Add(Requirement item)
    {
        throw new System.NotImplementedException();
    }

    public void Clear()
    {
        throw new System.NotImplementedException();
    }

    public bool Contains(Requirement item)
    {
        throw new System.NotImplementedException();
    }

    public void CopyTo(Requirement[] array, int arrayIndex)
    {
        throw new System.NotImplementedException();
    }

    public bool Remove(Requirement item)
    {
        throw new System.NotImplementedException();
    }

    public int Count { get; }
    public bool IsReadOnly { get; }
    public int IndexOf(Requirement item)
    {
        throw new System.NotImplementedException();
    }

    public void Insert(int index, Requirement item)
    {
        throw new System.NotImplementedException();
    }

    public void RemoveAt(int index)
    {
        throw new System.NotImplementedException();
    }

    public Requirement this[int index]
    {
        get => throw new System.NotImplementedException();
        set => throw new System.NotImplementedException();
    }
}