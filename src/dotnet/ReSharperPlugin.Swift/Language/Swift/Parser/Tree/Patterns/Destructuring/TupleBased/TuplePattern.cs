using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Patterns.Destructuring.TupleBased;

public class TuplePattern : SwiftCompositeNode, ITuplePattern
{
    public LeftParenthesis LeftParenthesis { get; }
    
    private readonly List<Comma> _commas;

    private readonly List<ITuplePatternElement> _elements;

    public RightParenthesis RightParenthesis { get; }

    internal TuplePattern(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        LeftParenthesis leftParenthesis,
        List<Comma> commas, List<ITuplePatternElement> elements, RightParenthesis rightParenthesis) : base(buffer,
        children)
    {
        LeftParenthesis = leftParenthesis;
        _commas = commas;
        _elements = elements;
        RightParenthesis = rightParenthesis;
    }

    public int Count => _elements.Count;
    
    public IReadOnlyList<Comma> Commas => _commas;

    public IReadOnlyList<ITuplePatternElement> Elements => _elements;

    IReadOnlyList<IReadOnlyTuplePatternElement> IReadOnlyTuplePattern.Elements => _elements;

    public bool IsReadOnly => false;

    public new ITuplePatternElement this[int index]
    {
        get => Elements[index];
        set => throw new NotImplementedException();
    }

    IReadOnlyTuplePatternElement IReadOnlyList<IReadOnlyTuplePatternElement>.this[int index] => Elements[index];

    public IEnumerator<ITuplePatternElement> GetEnumerator()
    {
        return Elements.GetEnumerator();
    }

    IEnumerator<IReadOnlyTuplePatternElement> IEnumerable<IReadOnlyTuplePatternElement>.GetEnumerator()
    {
        return GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Add(ITuplePatternElement item)
    {
        throw new NotImplementedException();
    }

    public void Insert(int index, ITuplePatternElement item)
    {
        throw new NotImplementedException();
    }

    public void Clear()
    {
        throw new NotImplementedException();
    }

    public int IndexOf(IReadOnlyTuplePatternElement item)
    {
        for (int index = 0; index < _elements.Count; index++)
        {
            ITuplePatternElement element = _elements[index];
            if (element == item)
            {
                return index;
            }
        }

        return -1;
    }

    public int IndexOf(ITuplePatternElement item)
    {
        return _elements.IndexOf(item);
    }

    public bool Contains(IReadOnlyTuplePatternElement item)
    {
        foreach (ITuplePatternElement element in _elements)
        {
            if (element == item)
            {
                return true;
            }
        }

        return false;
    }

    public bool Contains(ITuplePatternElement item)
    {
        return _elements.Contains(item);
    }

    public void CopyTo(IReadOnlyTuplePatternElement[] array, int arrayIndex)
    {
        throw new NotImplementedException();
    }

    public void CopyTo(ITuplePatternElement[] array, int arrayIndex)
    {
        _elements.CopyTo(array, arrayIndex);
    }

    public bool Remove(ITuplePatternElement item)
    {
        throw new NotImplementedException();
    }

    public void RemoveAt(int index)
    {
        throw new NotImplementedException();
    }
}