using System.Collections;
using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Identifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Attributes;

public class Attribute : SwiftCompositeNode, IAttribute
{
    public At AttributeIntroducer { get; }

    public IIdentifier Name { get; }

    public LeftParenthesis ParametersStart { get; }

    private readonly List<IBalancedToken> _balancedTokens;

    public RightParenthesis ParametersEnd { get; }

    internal Attribute(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        At attributeIntroducer, IIdentifier name, LeftParenthesis parametersStart, List<IBalancedToken> balancedTokens,
        RightParenthesis parametersEnd)
        : base(buffer, children)
    {
        AttributeIntroducer = attributeIntroducer;
        Name = name;
        ParametersStart = parametersStart;
        _balancedTokens = balancedTokens;
        ParametersEnd = parametersEnd;
    }

    IReadOnlyIdentifier IReadOnlyAttribute.Name => Name;

    public IReadOnlyList<IBalancedToken> BalancedTokens => _balancedTokens;

    IReadOnlyList<IReadOnlyBalancedToken> IReadOnlyAttribute.BalancedTokens => BalancedTokens;

    public int Count => _balancedTokens.Count;

    public bool IsReadOnly => false;

    public new IBalancedToken this[int index]
    {
        get => _balancedTokens[index];
        set => throw new System.NotImplementedException();
    }

    IReadOnlyBalancedToken IReadOnlyList<IReadOnlyBalancedToken>.this[int index]
        => _balancedTokens[index];

    IReadOnlyBalancedToken IReadOnlyAttribute.this[int index]
        => _balancedTokens[index];

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
