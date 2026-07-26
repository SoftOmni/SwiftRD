using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Attributes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Identifiers;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Imports;

public class ImportDeclaration : SwiftCompositeNode, IImportDeclaration
{
    public IAttributeGroup? Attributes { get; }

    public Import Import { get; }

    public IImportKind? ImportKind { get; }

    public IImportPath ImportPath { get; }

    internal ImportDeclaration(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        Import import, IImportPath importPath)
        : base(buffer, children)
    {
        Import = import;
        ImportPath = importPath;
    }

    internal ImportDeclaration(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        Import import, IImportKind importKind, IImportPath importPath)
        : base(buffer, children)
    {
        Import = import;
        ImportKind = importKind;
        ImportPath = importPath;
    }

    internal ImportDeclaration(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        IAttributeGroup attributes, Import import, IImportPath importPath)
        : base(buffer, children)
    {
        Attributes = attributes;
        Import = import;
        ImportPath = importPath;
    }

    internal ImportDeclaration(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        IAttributeGroup attributes, Import import, IImportKind importKind, IImportPath importPath)
        : base(buffer, children)
    {
        Attributes = attributes;
        Import = import;
        ImportKind = importKind;
        ImportPath = importPath;
    }

    IReadOnlyAttributeGroup? IReadOnlyImportDeclaration.Attributes => Attributes;
    
    IReadOnlyImportKind? IReadOnlyImportDeclaration.ImportKind => ImportKind;
    
    IReadOnlyImportPath IReadOnlyImportDeclaration.ImportPath => ImportPath;
    
    public IReadOnlyList<IIdentifier> PathComponents => ImportPath.Components;

    IReadOnlyList<IReadOnlyIdentifier> IReadOnlyImportDeclaration.PathComponents => PathComponents;

    public int Count => ImportPath.Count;

    public bool IsReadOnly => ImportPath.IsReadOnly;

    public IEnumerator<IIdentifier> GetEnumerator()
    {
        return ImportPath.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    IEnumerator<IReadOnlyIdentifier> IEnumerable<IReadOnlyIdentifier>.GetEnumerator()
    {
        return GetEnumerator();
    }

    public new IIdentifier this[int index]
    {
        get => ImportPath[index];
        set => ImportPath[index] = value;
    }

    IReadOnlyIdentifier IReadOnlyList<IReadOnlyIdentifier>.this[int index]
        => ImportPath[index];

    public bool Contains(IIdentifier item)
    {
        return ImportPath.Contains(item);
    }

    public int IndexOf(IIdentifier item)
    {
        return ImportPath.IndexOf(item);
    }

    public void CopyTo(IIdentifier[] array, int arrayIndex)
    {
        ImportPath.CopyTo(array, arrayIndex);
    }

    public void Add(IIdentifier item)
    {
        ImportPath.Add(item);
    }

    public void Insert(int index, IIdentifier item)
    {
        ImportPath.Insert(index, item);
    }

    public void Clear()
    {
        ImportPath.Clear();
    }

    public bool Remove(IIdentifier item)
    {
        return ImportPath.Remove(item);
    }

    public void RemoveAt(int index)
    {
        ImportPath.RemoveAt(index);
    }

    public void SetAttributesTo(IAttributeGroup? attributeGroupToSet)
    {
        throw new NotImplementedException();
    }

    public void RemoveAttributes()
    {
        throw new NotImplementedException();
    }

    public void SetImportKindTo(IImportKind? importKindToSet)
    {
        throw new NotImplementedException();
    }

    public void RemoveImportKind()
    {
        throw new NotImplementedException();
    }

    public void ChangeImportPath(IImportPath newImportPath)
    {
        throw new NotImplementedException();
    }
}
