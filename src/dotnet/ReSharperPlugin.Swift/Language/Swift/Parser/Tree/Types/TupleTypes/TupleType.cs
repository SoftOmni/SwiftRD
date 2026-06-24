using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;
using SoftOmni.SwiftRd.Technology;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.TupleTypes;

public class TupleType : SwiftCompositeNode, ITupleType
{
    public LeftParenthesis LeftParenthesis { get; }

    private readonly List<ITupleTypeElement> _tupleElements = [];
    
    private readonly List<Comma> _commas = [];
    
    public RightParenthesis RightParenthesis { get; }

    internal TupleType(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        LeftParenthesis leftParenthesis, List<ITupleTypeElement> tupleElements, List<Comma> commas,
        RightParenthesis rightParenthesis)
        : base(buffer, children)
    {
        LeftParenthesis = leftParenthesis;
        _tupleElements = tupleElements;
        _commas = commas;
        RightParenthesis = rightParenthesis;
    }

    public IReadOnlyDeclaration? Declaration { get; internal set; } = null;
    
    public IReadOnlyType ActualType => this;
    
    public string TypeSignature =>
        $"{LeftParenthesis.AsString}{string.Join(", ", _tupleElements)}{RightParenthesis.AsString}";

    public IReadOnlyType? SuperType => null;

    public IReadOnlyList<IReadOnlyList<IReadOnlyType>> SubTypeChains { get; } = [];
    
    public IReadOnlySet<IReadOnlyType> SubTypes { get; } = ModularVisibilityHashSet<IReadOnlyType>.Empty;

    public IReadOnlySet<string> SubTypeNames { get; } = ModularVisibilityHashSet<string>.Empty;
    
    public bool IsFromStandardLibrary { get; internal set; } = false;

    public int Size { get; }

    public IReadOnlyList<IReadOnlyTupleTypeElement> Elements => _tupleElements;

    public IReadOnlyList<Comma> Commas => _commas;

    public static TupleType CreateEmpty()
    {
        throw new NotImplementedException();
    }

    IEnumerator<IReadOnlyTupleTypeElement> IEnumerable<IReadOnlyTupleTypeElement>.GetEnumerator()
    {
        return GetEnumerator();
    }

    IReadOnlyTupleTypeElement IReadOnlyList<IReadOnlyTupleTypeElement>.this[int index] => _tupleElements[index];

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public IEnumerator<ITupleTypeElement> GetEnumerator()
    {
        throw new NotImplementedException();
    }

    public void Add(ITupleTypeElement item)
    {
        throw new NotImplementedException();
    }

    public void Clear()
    {
        throw new NotImplementedException();
    }

    public bool Contains(ITupleTypeElement item)
    {
        throw new NotImplementedException();
    }

    public void CopyTo(ITupleTypeElement[] array, int arrayIndex)
    {
        throw new NotImplementedException();
    }

    public bool Remove(ITupleTypeElement item)
    {
        throw new NotImplementedException();
    }

    public int Count { get; }
    public bool IsReadOnly { get; }
    public int IndexOf(ITupleTypeElement item)
    {
        throw new NotImplementedException();
    }

    public void Insert(int index, ITupleTypeElement item)
    {
        throw new NotImplementedException();
    }

    public void RemoveAt(int index)
    {
        throw new NotImplementedException();
    }

    public ITupleTypeElement this[int index]
    {
        get => throw new NotImplementedException();
        set => throw new NotImplementedException();
    }
}