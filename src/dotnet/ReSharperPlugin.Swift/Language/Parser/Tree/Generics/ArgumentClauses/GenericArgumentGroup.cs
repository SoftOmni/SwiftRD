using System.Collections;
using System.Collections.Generic;
using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Parser.Tree.Punctuators;
using ReSharperPlugin.Swift.Language.Parser.Tree.Types;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Generics.ArgumentClauses;

public class GenericArgumentGroup : SwiftInternalNode, IList<IType>
{
    public GenericArgumentClause? GenericArgumentClause { get; internal set; }
    
    private List<IType> _genericArguments = [];

    private List<Comma> _commas = [];

    public GenericArgumentGroup(IEditableBuffer buffer, List<ISwiftNode> children) 
        : base(buffer, children)
    { }

    public GenericArgumentGroup(IEditableBuffer buffer, IEnumerable<ISwiftNode> children) 
        : base(buffer, children)
    { }

    public GenericArgumentGroup(SwiftInternalNode parent, IEditableBuffer buffer, List<ISwiftNode> nodes) 
        : base(parent, buffer, nodes)
    { }

    public GenericArgumentGroup(SwiftInternalNode parent, IEditableBuffer buffer, IEnumerable<ISwiftNode> nodes) 
        : base(parent, buffer, nodes)
    { }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public IEnumerator<IType> GetEnumerator()
    {
        throw new System.NotImplementedException();
    }

    public void Add(IType item)
    {
        throw new System.NotImplementedException();
    }

    public void Clear()
    {
        throw new System.NotImplementedException();
    }

    public bool Contains(IType item)
    {
        throw new System.NotImplementedException();
    }

    public void CopyTo(IType[] array, int arrayIndex)
    {
        throw new System.NotImplementedException();
    }

    public bool Remove(IType item)
    {
        throw new System.NotImplementedException();
    }

    public int Count { get; }
    public bool IsReadOnly { get; }
    public int IndexOf(IType item)
    {
        throw new System.NotImplementedException();
    }

    public void Insert(int index, IType item)
    {
        throw new System.NotImplementedException();
    }

    public void RemoveAt(int index)
    {
        throw new System.NotImplementedException();
    }

    public IType this[int index]
    {
        get => throw new System.NotImplementedException();
        set => throw new System.NotImplementedException();
    }
}