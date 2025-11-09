using System.Collections;
using System.Collections.Generic;
using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Parser.Tree.Identifiers;
using ReSharperPlugin.Swift.Language.Parser.Tree.Punctuators;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Attributes;

public abstract class Attribute : SwiftInternalNode, IList<BalancedToken>
{
    public At At { get; internal set; }

    public Identifier? Identifier { get; internal set; }

    public LeftParenthesis? LeftParenthesis { get; internal set; }

    public BalancedTokenGroup? BalancedTokenGroup { get; internal set; }

    public RightParenthesis? RightParenthesis { get; internal set; }

    protected Attribute(IEditableBuffer buffer, List<ISwiftNode> children) 
        : base(buffer, children)
    { }

    protected Attribute(IEditableBuffer buffer, IEnumerable<ISwiftNode> children) 
        : base(buffer, children)
    { }

    protected Attribute(ISwiftNode parent, IEditableBuffer buffer, List<ISwiftNode> nodes) 
        : base(parent, buffer, nodes)
    { }

    protected Attribute(ISwiftNode parent, IEditableBuffer buffer, IEnumerable<ISwiftNode> nodes) 
        : base(parent, buffer, nodes)
    { }

    public IReadOnlyList<BalancedToken> BalancedTokens => BalancedTokenGroup?.BalancedTokens ?? [];

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