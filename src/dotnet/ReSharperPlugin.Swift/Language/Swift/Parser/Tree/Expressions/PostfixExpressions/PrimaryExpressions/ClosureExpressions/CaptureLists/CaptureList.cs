using System.Collections;
using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.InternalNode;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.ClosureExpressions.CaptureLists;

public class CaptureList : SwiftInternalNode, IList<CaptureListItem>
{
    public LeftSquareBracket? LeftSquareBracket { get; internal set; }

    private List<CaptureListItem> _items = [];
    
    public RightSquareBracket? RightSquareBracket { get; internal set; }

    public CaptureList(IEditableBuffer buffer, List<ISwiftNode> children)
        : base(buffer, children)
    { }

    public CaptureList(IEditableBuffer buffer, IEnumerable<ISwiftNode> children)
        : base(buffer, children)
    { }

    public CaptureList(SwiftInternalNode parent, IEditableBuffer buffer, List<ISwiftNode> nodes)
        : base(parent, buffer, nodes)
    { }

    public CaptureList(SwiftInternalNode parent, IEditableBuffer buffer, IEnumerable<ISwiftNode> nodes)
        : base(parent, buffer, nodes)
    { }

    public IReadOnlyList<CaptureListItem> Items => _items;

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public IEnumerator<CaptureListItem> GetEnumerator()
    {
        throw new System.NotImplementedException();
    }

    public void Add(CaptureListItem item)
    {
        throw new System.NotImplementedException();
    }

    public void Clear()
    {
        throw new System.NotImplementedException();
    }

    public bool Contains(CaptureListItem item)
    {
        throw new System.NotImplementedException();
    }

    public void CopyTo(CaptureListItem[] array, int arrayIndex)
    {
        throw new System.NotImplementedException();
    }

    public bool Remove(CaptureListItem item)
    {
        throw new System.NotImplementedException();
    }

    public int Count { get; }
    public bool IsReadOnly { get; }
    public int IndexOf(CaptureListItem item)
    {
        throw new System.NotImplementedException();
    }

    public void Insert(int index, CaptureListItem item)
    {
        throw new System.NotImplementedException();
    }

    public void RemoveAt(int index)
    {
        throw new System.NotImplementedException();
    }

    public CaptureListItem this[int index]
    {
        get => throw new System.NotImplementedException();
        set => throw new System.NotImplementedException();
    }
}