using System.Collections;
using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Attributes.BalancedBracketBalancedTokens;

public class SquareBracketBracketBalancedToken : SwiftCompositeNode,
    ISquareBracketBracketBalancedToken

{
    public LeftSquareBracket BalancedTokensStart { get; }

    private readonly List<IBalancedToken> _balancedTokens;

    public RightSquareBracket BalancedTokenEnd { get; }

    internal SquareBracketBracketBalancedToken(IEditableBuffer buffer,
        IEnumerable<ISwiftNode<SwiftCompositeNode>> children, LeftSquareBracket balancedTokensStart,
        List<IBalancedToken> balancedTokens, RightSquareBracket balancedTokenEnd)
        : base(buffer, children)
    {
        BalancedTokensStart = balancedTokensStart;
        _balancedTokens = balancedTokens;
        BalancedTokenEnd = balancedTokenEnd;
    }

    public IReadOnlyList<IBalancedToken> BalancedTokens => _balancedTokens;

    IReadOnlyList<IReadOnlyBalancedToken> IReadOnlyBracketBalancedToken.BalancedTokens => BalancedTokens;

    public int Count => BalancedTokens.Count;

    public bool IsReadOnly => false;

    public IEnumerator<IBalancedToken> GetEnumerator()
    {
        return _balancedTokens.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    IEnumerator<IReadOnlyBalancedToken> IEnumerable<IReadOnlyBalancedToken>.GetEnumerator()
    {
        return GetEnumerator();
    }

    public new IBalancedToken this[int index]
    {
        get => _balancedTokens[index];
        set => throw new System.NotImplementedException();
    }

    IReadOnlyBalancedToken IReadOnlyList<IReadOnlyBalancedToken>.this[int index]
        => _balancedTokens[index];

    public bool Contains(IBalancedToken item)
    {
        return _balancedTokens.Contains(item);
    }

    public int IndexOf(IBalancedToken item)
    {
        return _balancedTokens.IndexOf(item);
    }

    public void CopyTo(IBalancedToken[] array, int arrayIndex)
    {
        _balancedTokens.CopyTo(array, arrayIndex);
    }

    public void Add(IBalancedToken item)
    {
        throw new System.NotImplementedException();
    }

    public void Clear()
    {
        throw new System.NotImplementedException();
    }

    public bool Remove(IBalancedToken item)
    {
        throw new System.NotImplementedException();
    }

    public void Insert(int index, IBalancedToken item)
    {
        throw new System.NotImplementedException();
    }

    public void RemoveAt(int index)
    {
        throw new System.NotImplementedException();
    }
}