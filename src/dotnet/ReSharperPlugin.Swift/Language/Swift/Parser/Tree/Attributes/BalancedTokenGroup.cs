using System.Collections;
using System.Collections.Generic;
using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Parser.Tree.Base.InternalNode;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Attributes;

public class BalancedTokenGroup : SwiftInternalNode, IList<BalancedToken>
{
    private List<BalancedToken> _balancedTokens = [];
    
    public BalancedTokenGroup(IEditableBuffer buffer, List<ISwiftNode> children)
        : base(buffer, children)
    { }

    public BalancedTokenGroup(IEditableBuffer buffer, IEnumerable<ISwiftNode> children)
        : base(buffer, children)
    { }

    public BalancedTokenGroup(SwiftInternalNode parent, IEditableBuffer buffer, List<ISwiftNode> nodes)
        : base(parent, buffer, nodes)
    { }

    public BalancedTokenGroup(SwiftInternalNode parent, IEditableBuffer buffer, IEnumerable<ISwiftNode> nodes)
        : base(parent, buffer, nodes)
    { }

    public IReadOnlyList<BalancedToken> BalancedTokens => _balancedTokens;

    public IEnumerator<BalancedToken> GetEnumerator()
    {
        throw new System.NotImplementedException();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Add(BalancedToken item)
    {
        throw new System.NotImplementedException();
    }

    public void Clear()
    {
        throw new System.NotImplementedException();
    }

    public bool Contains(BalancedToken item)
    {
        throw new System.NotImplementedException();
    }

    public void CopyTo(BalancedToken[] array, int arrayIndex)
    {
        throw new System.NotImplementedException();
    }

    public bool Remove(BalancedToken item)
    {
        throw new System.NotImplementedException();
    }

    public int Count { get; }
    public bool IsReadOnly { get; }
    public int IndexOf(BalancedToken item)
    {
        throw new System.NotImplementedException();
    }

    public void Insert(int index, BalancedToken item)
    {
        throw new System.NotImplementedException();
    }

    public void RemoveAt(int index)
    {
        throw new System.NotImplementedException();
    }

    public BalancedToken this[int index]
    {
        get => throw new System.NotImplementedException();
        set => throw new System.NotImplementedException();
    }
}