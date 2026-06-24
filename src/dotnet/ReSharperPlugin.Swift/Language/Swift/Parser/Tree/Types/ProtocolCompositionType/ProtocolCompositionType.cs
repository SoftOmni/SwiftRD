using System.Collections;
using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.TypeIdentifiers;
using SoftOmni.SwiftRd.Technology;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.ProtocolCompositionType;

public class ProtocolCompositionType : SwiftCompositeNode, IProtocolCompositionType
{
    private readonly List<ITypeIdentifier> _typeIdentifiers = [];

    private readonly List<Ampersand> _ampersands = [];

    internal ProtocolCompositionType(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        List<ITypeIdentifier> typeIdentifiers, List<Ampersand> ampersands)
        : base(buffer, children)
    {
        _typeIdentifiers = typeIdentifiers;
        _ampersands = ampersands;
    }

    public IReadOnlyDeclaration? Declaration { get; internal set; } = null;
    
    public IReadOnlyType ActualType => this;
    
    public string TypeSignature => string.Join(" & ", _typeIdentifiers);

    public IReadOnlyType? SuperType => null;

    public IReadOnlyList<IReadOnlyList<IReadOnlyType>> SubTypeChains { get; } = [];
    
    public IReadOnlySet<IReadOnlyType> SubTypes { get; } = ModularVisibilityHashSet<IReadOnlyType>.Empty;
    
    public IReadOnlySet<string> SubTypeNames { get; } = ModularVisibilityHashSet<string>.Empty;

    public bool IsFromStandardLibrary { get; internal set; } = false;

    public int Size { get; }

    IEnumerator<ITypeIdentifier> IEnumerable<ITypeIdentifier>.GetEnumerator()
    {
        return _typeIdentifiers.GetEnumerator();
    }

    ITypeIdentifier IProtocolCompositionType.this[int index]
    {
        get => _typeIdentifiers[index];
        set => throw new System.NotImplementedException();
    }

    IEnumerator<IReadOnlyTypeIdentifier> IEnumerable<IReadOnlyTypeIdentifier>.GetEnumerator()
    {
        return _typeIdentifiers.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return _typeIdentifiers.GetEnumerator();
    }

    public void Add(ITypeIdentifier item)
    {
        throw new System.NotImplementedException();
    }

    public void Clear()
    {
        throw new System.NotImplementedException();
    }

    public bool Contains(ITypeIdentifier item)
    {
        return _typeIdentifiers.Contains(item);
    }

    public void CopyTo(ITypeIdentifier[] array, int arrayIndex)
    {
        _typeIdentifiers.CopyTo(array, arrayIndex);
    }

    public bool Remove(ITypeIdentifier item)
    {
        throw new System.NotImplementedException();
    }

    int IProtocolCompositionType.Count => _typeIdentifiers.Count;

    int ICollection<ITypeIdentifier>.Count => _typeIdentifiers.Count;

    int IReadOnlyCollection<IReadOnlyTypeIdentifier>.Count => _typeIdentifiers.Count;
    
    public bool IsReadOnly => false;

    public int IndexOf(ITypeIdentifier item)
    {
        return _typeIdentifiers.IndexOf(item);
    }

    public void Insert(int index, ITypeIdentifier item)
    {
        throw new System.NotImplementedException();
    }

    public void RemoveAt(int index)
    {
        throw new System.NotImplementedException();
    }

    IEnumerator<ITypeIdentifier> IProtocolCompositionType.GetEnumerator()
    {
        return _typeIdentifiers.GetEnumerator();
    }

    ITypeIdentifier IList<ITypeIdentifier>.this[int index]
    {
        get => _typeIdentifiers[index];
        set => throw new System.NotImplementedException();
    }

    IReadOnlyTypeIdentifier IReadOnlyList<IReadOnlyTypeIdentifier>.this[int index] => _typeIdentifiers[index];

    public IReadOnlyList<IReadOnlyTypeIdentifier> ProtocolComposition => _typeIdentifiers;
}