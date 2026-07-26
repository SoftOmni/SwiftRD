using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;
using SoftOmni.SwiftRd.Technology;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.TypeIdentifiers;

public class TypeIdentifier : SwiftCompositeNode, ITypeIdentifier
{
    private readonly List<ITypeIdentifierComponent> _components;
    
    private readonly List<Period> _periods;
    
    private readonly List<List<IType>> _subTypeChains = [];

    private readonly ModularVisibilityHashSet<IReadOnlyType> _subTypesReadonly = [];
    
    private readonly ModularVisibilityHashSet<IType> _subTypes = [];
    
    private readonly ModularVisibilityHashSet<string> _subTypeNames = [];

    public TypeIdentifier(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        List<ITypeIdentifierComponent> components, List<Period> periods)
        : base(buffer, children)
    {
        _components = components;
        _periods = periods;

        ActualType = this;
    }

    public IReadOnlyDeclaration? Declaration { get; internal set; } = null;
    
    public IReadOnlyType ActualType { get; internal set; }
    
    public string TypeSignature => string.Join(".", _components);
    
    public IReadOnlyType? SuperType { get; internal set; } = null;
    
    public IReadOnlyList<IReadOnlyList<IReadOnlyType>> SubTypeChains => _subTypeChains;
    
    public IReadOnlySet<IReadOnlyType> SubTypes => _subTypesReadonly;
    
    public IReadOnlySet<string> SubTypeNames => _subTypeNames;
    
    public bool IsFromStandardLibrary { get; internal set; } = false;

    public int Size { get; }

    IEnumerator<ITypeIdentifierComponent> IEnumerable<ITypeIdentifierComponent>.GetEnumerator()
    {
        return _components.GetEnumerator();
    }

    ITypeIdentifierComponent ITypeIdentifier.this[int index]
    {
        get => _components[index];
        set => throw new NotImplementedException();
    }

    IEnumerator<IReadOnlyTypeIdentifierComponent> IEnumerable<IReadOnlyTypeIdentifierComponent>.GetEnumerator()
    {
        return _components.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return _components.GetEnumerator();
    }

    public void Add(ITypeIdentifierComponent item)
    {
        throw new NotImplementedException();
    }

    public void Clear()
    {
        throw new NotImplementedException();
    }

    public bool Contains(ITypeIdentifierComponent item)
    {
        return _components.Contains(item);
    }

    public void CopyTo(ITypeIdentifierComponent[] array, int arrayIndex)
    {
        _components.CopyTo(array, arrayIndex);
    }

    public bool Remove(ITypeIdentifierComponent item)
    {
        throw new NotImplementedException();
    }

    int ITypeIdentifier.Count => _components.Count;

    int ICollection<ITypeIdentifierComponent>.Count => _components.Count;

    public bool IsReadOnly => false;

    int IReadOnlyCollection<IReadOnlyTypeIdentifierComponent>.Count => _components.Count;

    public int IndexOf(ITypeIdentifierComponent item)
    {
        return _components.IndexOf(item);
    }

    public void Insert(int index, ITypeIdentifierComponent item)
    {
        throw new NotImplementedException();
    }

    public void RemoveAt(int index)
    {
        throw new NotImplementedException();
    }

    IEnumerator<ITypeIdentifierComponent> ITypeIdentifier.GetEnumerator()
    {
        return _components.GetEnumerator();
    }

    ITypeIdentifierComponent IList<ITypeIdentifierComponent>.this[int index]
    {
        get => _components[index];
        set => throw new NotImplementedException();
    }

    IReadOnlyTypeIdentifierComponent IReadOnlyList<IReadOnlyTypeIdentifierComponent>.this[int index] => _components[index];

    public IReadOnlyList<IReadOnlyTypeIdentifierComponent> Identifiers => _components;

    public IReadOnlyList<Period> Periods => _periods;
}