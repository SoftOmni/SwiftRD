using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Identifiers;
using SoftOmni.SwiftRd.Rider.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.KeyPathExpressions.Components.KeyPathPostfixes;

namespace SoftOmni.SwiftRd.Rider.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.
    KeyPathExpressions.Components;

public class IdentifierKeyPathComponent : SwiftCompositeNode, IIdentifierKeyPathComponent
{
    public IIdentifier Identifier { get; }

    private readonly List<IKeyPathPostfix> _keyPathPostfixes;

    internal IdentifierKeyPathComponent(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        IIdentifier identifier,
        List<IKeyPathPostfix>? keyPathPostfixes = null)
        : base(buffer, children)
    {
        _keyPathPostfixes = keyPathPostfixes ?? [];
        Identifier = identifier;
    }

    IReadOnlyIdentifier IReadOnlyIdentifierKeyPathComponent.Identifier => Identifier;

    public IReadOnlyList<IKeyPathPostfix>? KeyPathPostfixes => _keyPathPostfixes.Count == 0 ? null : _keyPathPostfixes;

    IReadOnlyList<IReadOnlyKeyPathPostfix>? IReadOnlyIdentifierKeyPathComponent.KeyPathPostfixes => KeyPathPostfixes;

    public int Count => _keyPathPostfixes.Count;

    public bool IsReadOnly => false;

    public new IKeyPathPostfix this[int index]
    {
        get => _keyPathPostfixes[index];
        set => throw new NotImplementedException();
    }

    IReadOnlyKeyPathPostfix IReadOnlyIdentifierKeyPathComponent.this[int index] => _keyPathPostfixes[index];
    
    IReadOnlyKeyPathPostfix IReadOnlyList<IReadOnlyKeyPathPostfix>.this[int index] => _keyPathPostfixes[index];

    public void ChangeIdentifier(IIdentifier newIdentifier)
    {
        throw new NotImplementedException();
    }

    public IEnumerator<IKeyPathPostfix> GetEnumerator()
    {
        return _keyPathPostfixes.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    IEnumerator<IReadOnlyKeyPathPostfix> IEnumerable<IReadOnlyKeyPathPostfix>.GetEnumerator()
    {
        return GetEnumerator();
    }

    public bool Contains(IKeyPathPostfix item)
    {
        return _keyPathPostfixes.Contains(item);
    }

    public int IndexOf(IKeyPathPostfix item)
    {
        return _keyPathPostfixes.IndexOf(item);
    }

    public void CopyTo(IKeyPathPostfix[] array, int arrayIndex)
    {
        _keyPathPostfixes.CopyTo(array, arrayIndex);
    }

    public void Add(IKeyPathPostfix item)
    {
        throw new NotImplementedException();
    }

    public void Clear()
    {
        throw new NotImplementedException();
    }

    public bool Remove(IKeyPathPostfix item)
    {
        throw new NotImplementedException();
    }

    public void Insert(int index, IKeyPathPostfix item)
    {
        throw new NotImplementedException();
    }

    public void RemoveAt(int index)
    {
        throw new NotImplementedException();
    }
}
