using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Constants;

public class PatternInitializerList : SwiftCompositeNode, IPatternInitializerList
{
    private readonly List<IPatternInitializer> _patternInitializers;

    private readonly List<Comma> _patternInitializerSeparators;

    internal PatternInitializerList(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        List<IPatternInitializer> patternInitializers, List<Comma> patternInitializerSeparators)
        : base(buffer, children)
    {
        _patternInitializers = patternInitializers;
        _patternInitializerSeparators = patternInitializerSeparators;
    }

    public IReadOnlyList<IPatternInitializer> PatternInitializers => _patternInitializers;

    IReadOnlyList<IReadOnlyPatternInitializer> IReadOnlyPatternInitializerList.PatternInitializers =>
        PatternInitializers;

    public IReadOnlyList<Comma> PatternInitializerSeparators => _patternInitializerSeparators;

    public int Count => _patternInitializers.Count;

    public bool IsReadOnly => false;

    public new IPatternInitializer this[int index]
    {
        get => _patternInitializers[index];
        set => throw new NotImplementedException();
    }

    IReadOnlyPatternInitializer IReadOnlyList<IReadOnlyPatternInitializer>.this[int index]
        => _patternInitializers[index];

    IReadOnlyPatternInitializer IReadOnlyPatternInitializerList.this[int index] 
        => _patternInitializers[index];

    public IEnumerator<IPatternInitializer> GetEnumerator()
    {
        return _patternInitializers.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    IEnumerator<IReadOnlyPatternInitializer> IEnumerable<IReadOnlyPatternInitializer>.GetEnumerator()
    {
        return GetEnumerator();
    }

    public bool Contains(IPatternInitializer item)
    {
        return _patternInitializers.Contains(item);
    }

    public int IndexOf(IPatternInitializer item)
    {
        return _patternInitializers.IndexOf(item);
    }

    public void CopyTo(IPatternInitializer[] array, int arrayIndex)
    {
        _patternInitializers.CopyTo(array, arrayIndex);
    }

    public void Add(IPatternInitializer item)
    {
        throw new NotImplementedException();
    }

    public void Clear()
    {
        throw new NotImplementedException();
    }

    public bool Remove(IPatternInitializer item)
    {
        throw new NotImplementedException();
    }

    public void Insert(int index, IPatternInitializer item)
    {
        throw new NotImplementedException();
    }

    public void RemoveAt(int index)
    {
        throw new NotImplementedException();
    }
}
