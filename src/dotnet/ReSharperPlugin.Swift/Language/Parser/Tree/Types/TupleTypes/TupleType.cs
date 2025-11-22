using System.Collections;
using System.Collections.Generic;
using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Parser.Tree.Punctuators;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Types.TupleTypes;

public class TupleType : TypeInternalNode, IList<ITupleTypeElement>
{
    public LeftParenthesis? LeftParenthesis { get; internal set; }

    private List<ITupleTypeElement> _tupleElements = [];
    
    public RightParenthesis? RightParenthesis { get; internal set; }

    public TupleType(IEditableBuffer buffer, List<ISwiftNode> children) 
        : base(buffer, children)
    { }

    public TupleType(IEditableBuffer buffer, IEnumerable<ISwiftNode> children) 
        : base(buffer, children)
    { }

    public TupleType(SwiftInternalNode parent, IEditableBuffer buffer, List<ISwiftNode> nodes) 
        : base(parent, buffer, nodes)
    { }

    public TupleType(SwiftInternalNode parent, IEditableBuffer buffer, IEnumerable<ISwiftNode> nodes) 
        : base(parent, buffer, nodes)
    { }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public IEnumerator<ITupleTypeElement> GetEnumerator()
    {
        throw new System.NotImplementedException();
    }

    public void Add(ITupleTypeElement item)
    {
        throw new System.NotImplementedException();
    }

    public void Clear()
    {
        throw new System.NotImplementedException();
    }

    public bool Contains(ITupleTypeElement item)
    {
        throw new System.NotImplementedException();
    }

    public void CopyTo(ITupleTypeElement[] array, int arrayIndex)
    {
        throw new System.NotImplementedException();
    }

    public bool Remove(ITupleTypeElement item)
    {
        throw new System.NotImplementedException();
    }

    public int Count { get; }
    public bool IsReadOnly { get; }
    public int IndexOf(ITupleTypeElement item)
    {
        throw new System.NotImplementedException();
    }

    public void Insert(int index, ITupleTypeElement item)
    {
        throw new System.NotImplementedException();
    }

    public void RemoveAt(int index)
    {
        throw new System.NotImplementedException();
    }

    public ITupleTypeElement this[int index]
    {
        get => throw new System.NotImplementedException();
        set => throw new System.NotImplementedException();
    }
}