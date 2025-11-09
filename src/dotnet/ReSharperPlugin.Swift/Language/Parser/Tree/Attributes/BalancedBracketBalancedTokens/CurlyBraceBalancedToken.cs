using System.Collections;
using System.Collections.Generic;
using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Parser.Tree.Punctuators;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Attributes.BalancedBracketBalancedTokens;

public class CurlyBraceBalancedToken : BalancedToken, IList<BalancedToken>
{
    public LeftCurlyBrace? LeftCurlyBrace { get; internal set; }
    
    public AttributeGroup? AttributeGroup { get; internal set; }
    
    public RightCurlyBrace? RightCurlyBrace { get; internal set; }
    
    public CurlyBraceBalancedToken(IEditableBuffer buffer, List<ISwiftNode> children) 
        : base(buffer, children)
    { }

    public CurlyBraceBalancedToken(IEditableBuffer buffer, IEnumerable<ISwiftNode> children) 
        : base(buffer, children)
    { }

    public CurlyBraceBalancedToken(ISwiftNode parent, IEditableBuffer buffer, List<ISwiftNode> nodes) 
        : base(parent, buffer, nodes)
    { }

    public CurlyBraceBalancedToken(ISwiftNode parent, IEditableBuffer buffer, IEnumerable<ISwiftNode> nodes) 
        : base(parent, buffer, nodes)
    { }

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