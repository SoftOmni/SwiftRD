using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.ClosureExpressions.CaptureLists;

public class CaptureList : SwiftCompositeNode, ICaptureList
{
    public LeftSquareBracket LeftSquareBracket { get; }

    private readonly List<Comma> _commas;

    private readonly List<ICaptureListItem> _items;
    
    public RightSquareBracket RightSquareBracket { get; }

    internal CaptureList(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        LeftSquareBracket leftSquareBracket, List<ICaptureListItem> items, List<Comma> commas,
        RightSquareBracket rightSquareBracket)
        : base(buffer, children)
    {
        _commas = commas;
        _items = items;
        LeftSquareBracket = leftSquareBracket;
        RightSquareBracket = rightSquareBracket;
    }

    public IReadOnlyList<ICaptureListItem> Items => _items;

    IReadOnlyList<IReadOnlyCaptureListItem> IReadOnlyCaptureList.Items => Items;

    public IReadOnlyList<Comma> Commas => _commas;

    public int Count => _items.Count;

    public bool IsReadOnly => false;

    public new ICaptureListItem this[int index]
    {
        get => _items[index];
        set => throw new NotImplementedException();
    }

    IReadOnlyCaptureListItem IReadOnlyList<IReadOnlyCaptureListItem>.this[int index] => _items[index];

    IReadOnlyCaptureListItem IReadOnlyCaptureList.this[int index] => _items[index];

    public IEnumerator<ICaptureListItem> GetEnumerator()
    {
        return _items.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    IEnumerator<IReadOnlyCaptureListItem> IEnumerable<IReadOnlyCaptureListItem>.GetEnumerator()
    {
        return GetEnumerator();
    }

    public bool Contains(ICaptureListItem item)
    {
        return _items.Contains(item);
    }

    public int IndexOf(ICaptureListItem item)
    {
        return _items.IndexOf(item);
    }

    public void CopyTo(ICaptureListItem[] array, int arrayIndex)
    {
        _items.CopyTo(array, arrayIndex);
    }

    public void Add(ICaptureListItem item)
    {
        throw new NotImplementedException();
    }

    public void Clear()
    {
        throw new NotImplementedException();
    }

    public bool Remove(ICaptureListItem item)
    {
        throw new NotImplementedException();
    }

    public void Insert(int index, ICaptureListItem item)
    {
        throw new NotImplementedException();
    }

    public void RemoveAt(int index)
    {
        throw new NotImplementedException();
    }
}
