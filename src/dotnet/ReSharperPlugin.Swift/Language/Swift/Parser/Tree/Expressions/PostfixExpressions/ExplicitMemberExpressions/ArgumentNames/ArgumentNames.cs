using System.Collections;
using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Identifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.ExplicitMemberExpressions.ArgumentNames;

public class ArgumentNames : SwiftCompositeNode, IArgumentNames
{
    private List<IIdentifier> _argumentNames;
    
    private List<Colon> _colons;

    internal ArgumentNames(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        List<IIdentifier> argumentNames, List<Colon> colons)
        : base(buffer, children)
    {
        _argumentNames = argumentNames;
        _colons = colons;
    }

    public IReadOnlyList<IReadOnlyIdentifier> Names => _argumentNames;

    public IReadOnlyList<Colon> Colons => _colons;
    
    public int Count => _argumentNames.Count;
    
    public bool IsReadOnly => false;

    public new IIdentifier this[int index]
    {
        get => _argumentNames[index];
        set => throw new System.NotImplementedException();
    }

    IReadOnlyIdentifier IReadOnlyList<IReadOnlyIdentifier>.this[int index] => _argumentNames[index];

    IEnumerator IEnumerable.GetEnumerator()
    {
        return _argumentNames.GetEnumerator();
    }

    IEnumerator<IReadOnlyIdentifier> IEnumerable<IReadOnlyIdentifier>.GetEnumerator()
    {
        return _argumentNames.GetEnumerator();
    }

    IEnumerator<IIdentifier> IEnumerable<IIdentifier>.GetEnumerator()
    {
        return _argumentNames.GetEnumerator();
    }

    IEnumerator<IIdentifier> IArgumentNames.GetEnumerator()
    {
        return _argumentNames.GetEnumerator();
    }

    public bool Contains(IIdentifier item)
    {
        return _argumentNames.Contains(item);
    }

    public int IndexOf(IIdentifier item)
    {
        return _argumentNames.IndexOf(item);
    }

    public void CopyTo(IIdentifier[] array, int arrayIndex)
    {
        _argumentNames.CopyTo(array, arrayIndex);
    }

    public void Add(IIdentifier item)
    {
        throw new System.NotImplementedException();
    }

    public void Clear()
    {
        throw new System.NotImplementedException();
    }

    public bool Remove(IIdentifier item)
    {
        throw new System.NotImplementedException();
    }

    public void Insert(int index, IIdentifier item)
    {
        throw new System.NotImplementedException();
    }

    public void RemoveAt(int index)
    {
        throw new System.NotImplementedException();
    }
}
