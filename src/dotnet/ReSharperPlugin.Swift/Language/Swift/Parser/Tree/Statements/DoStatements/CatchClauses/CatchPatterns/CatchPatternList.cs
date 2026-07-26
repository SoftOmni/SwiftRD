using System.Collections;
using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.DoStatements.CatchClauses;

public class CatchPatternList : SwiftCompositeNode, ICatchPatternList
{
    private readonly List<ICatchPattern> _catchPatterns;

    private readonly List<Comma> _separators;

    internal CatchPatternList(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children, 
        List<ICatchPattern> catchPatterns, List<Comma> separators)
        : base(buffer, children)
    {
        _catchPatterns = catchPatterns;
        _separators = separators;
    }

    public IReadOnlyList<ICatchPattern> CatchPatterns => _catchPatterns;

    IReadOnlyList<IReadOnlyCatchPattern> IReadOnlyCatchPatternList.CatchPatterns => 
        CatchPatterns;

    public IReadOnlyList<Comma> Commas => _separators;

    public int Count => _catchPatterns.Count;

    public bool IsReadOnly => false;

    public new ICatchPattern this[int index]
    {
        get => _catchPatterns[index];
        set => throw new System.NotImplementedException();
    }

    IReadOnlyCatchPattern IReadOnlyList<IReadOnlyCatchPattern>.this[int index]
        => _catchPatterns[index];

    IReadOnlyCatchPattern IReadOnlyCatchPatternList.this[int index]
        => _catchPatterns[index];

    public IEnumerator<ICatchPattern> GetEnumerator()
    {
        return _catchPatterns.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    IEnumerator<IReadOnlyCatchPattern> IEnumerable<IReadOnlyCatchPattern>.GetEnumerator()
    {
        return GetEnumerator();
    }

    public bool Contains(ICatchPattern item)
    {
        return _catchPatterns.Contains(item);
    }

    public int IndexOf(ICatchPattern item)
    {
        return _catchPatterns.IndexOf(item);
    }

    public void CopyTo(ICatchPattern[] array, int arrayIndex)
    {
        _catchPatterns.CopyTo(array, arrayIndex);
    }

    public void Add(ICatchPattern item)
    {
        throw new System.NotImplementedException();
    }

    public void Clear()
    {
        throw new System.NotImplementedException();
    }

    public bool Remove(ICatchPattern item)
    {
        throw new System.NotImplementedException();
    }

    public void Insert(int index, ICatchPattern item)
    {
        throw new System.NotImplementedException();
    }

    public void RemoveAt(int index)
    {
        throw new System.NotImplementedException();
    }
}
