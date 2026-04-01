using System.Collections;
using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.InternalNode;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Generics.ParameterClauses;

public class GenericParameterGroup : SwiftInternalNode, IList<GenericParameter>
{
    public GenericParameterClause? GenericParameterClause { get; internal set; }
    
    private List<GenericParameter> _genericParameters = [];
    
    public GenericParameterGroup(IEditableBuffer buffer, List<ISwiftNode> children) 
        : base(buffer, children)
    { }

    public GenericParameterGroup(IEditableBuffer buffer, IEnumerable<ISwiftNode> children) 
        : base(buffer, children)
    { }

    public GenericParameterGroup(SwiftInternalNode parent, IEditableBuffer buffer, List<ISwiftNode> nodes) 
        : base(parent, buffer, nodes)
    { }

    public GenericParameterGroup(SwiftInternalNode parent, IEditableBuffer buffer, IEnumerable<ISwiftNode> nodes) 
        : base(parent, buffer, nodes)
    { }

    public IReadOnlyList<GenericParameter> GenericParameters => _genericParameters;

    public IEnumerator<GenericParameter> GetEnumerator()
    {
        throw new System.NotImplementedException();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Add(GenericParameter item)
    {
        throw new System.NotImplementedException();
    }

    public void Clear()
    {
        throw new System.NotImplementedException();
    }

    public bool Contains(GenericParameter item)
    {
        throw new System.NotImplementedException();
    }

    public void CopyTo(GenericParameter[] array, int arrayIndex)
    {
        throw new System.NotImplementedException();
    }

    public bool Remove(GenericParameter item)
    {
        throw new System.NotImplementedException();
    }

    public int Count { get; }
    public bool IsReadOnly { get; }
    public int IndexOf(GenericParameter item)
    {
        throw new System.NotImplementedException();
    }

    public void Insert(int index, GenericParameter item)
    {
        throw new System.NotImplementedException();
    }

    public void RemoveAt(int index)
    {
        throw new System.NotImplementedException();
    }

    public GenericParameter this[int index]
    {
        get => throw new System.NotImplementedException();
        set => throw new System.NotImplementedException();
    }
}