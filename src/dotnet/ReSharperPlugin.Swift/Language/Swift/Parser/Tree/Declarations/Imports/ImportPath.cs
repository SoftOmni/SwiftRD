using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Identifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Imports;

public class ImportPath : SwiftCompositeNode, IImportPath
{
    private readonly List<IIdentifier> _components;

    private readonly List<Period> _componentSeparators;

    internal ImportPath(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        List<IIdentifier> components, List<Period> componentSeparators)
        : base(buffer, children)
    {
        _components = components;
        _componentSeparators = componentSeparators;
    }

    public IReadOnlyList<IIdentifier> Components => _components;

    IReadOnlyList<IReadOnlyIdentifier> IReadOnlyImportPath.Components => Components;

    public IReadOnlyList<Period> ComponentSeparators => _componentSeparators;

    public int Count => _components.Count;

    public bool IsReadOnly => false;

    public new IIdentifier this[int index]
    {
        get => _components[index];
        set => throw new NotImplementedException();
    }

    IReadOnlyIdentifier IReadOnlyList<IReadOnlyIdentifier>.this[int index]
        => _components[index];

    IReadOnlyIdentifier IReadOnlyImportPath.this[int index]
        => _components[index];

    public IEnumerator<IIdentifier> GetEnumerator()
    {
        return _components.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    IEnumerator<IReadOnlyIdentifier> IEnumerable<IReadOnlyIdentifier>.GetEnumerator()
    {
        return GetEnumerator();
    }

    public bool Contains(IIdentifier item)
    {
        return _components.Contains(item);
    }

    public int IndexOf(IIdentifier item)
    {
        return _components.IndexOf(item);
    }

    public void CopyTo(IIdentifier[] array, int arrayIndex)
    {
        _components.CopyTo(array, arrayIndex);
    }

    public void Add(IIdentifier item)
    {
        throw new NotImplementedException();
    }

    public void Clear()
    {
        throw new NotImplementedException();
    }

    public bool Remove(IIdentifier item)
    {
        throw new NotImplementedException();
    }

    public void Insert(int index, IIdentifier item)
    {
        throw new NotImplementedException();
    }

    public void RemoveAt(int index)
    {
        throw new NotImplementedException();
    }
}
