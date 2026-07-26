using System.Collections;
using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Generics.ParameterClauses.Parameters;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Generics.ParameterClauses;

public class GenericParameterClause : SwiftCompositeNode, IGenericParameterClause
{
    public LeftAngleBracket ParameterClauseStart { get; }

    private readonly List<IGenericParameter> _genericParameters;

    private readonly List<Comma> _genericParameterSeparators;

    public RightAngleBracket ParameterClauseEnd { get; }

    internal GenericParameterClause(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        LeftAngleBracket parameterClauseStart, List<IGenericParameter> genericParameters,
        List<Comma> genericParameterSeparators, RightAngleBracket parameterClauseEnd)
        : base(buffer, children)
    {
        _genericParameters = genericParameters;
        _genericParameterSeparators = genericParameterSeparators;
        ParameterClauseStart = parameterClauseStart;
        ParameterClauseEnd = parameterClauseEnd;
    }

    public IReadOnlyList<IGenericParameter> GenericParameters => _genericParameters;

    IReadOnlyList<IReadOnlyGenericParameter> IReadOnlyGenericParameterClause.GenericParameters => GenericParameters;

    public IReadOnlyList<Comma> GenericParameterSeparators => _genericParameterSeparators;

    public int Count => _genericParameters.Count;

    public bool IsReadOnly => false;

    public new IGenericParameter this[int index]
    {
        get => _genericParameters[index];
        set => throw new System.NotImplementedException();
    }

    IReadOnlyGenericParameter IReadOnlyList<IReadOnlyGenericParameter>.this[int index]
        => _genericParameters[index];

    IReadOnlyGenericParameter IReadOnlyGenericParameterClause.this[int index]
        => _genericParameters[index];

    public IEnumerator<IGenericParameter> GetEnumerator()
    {
        return _genericParameters.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    IEnumerator<IReadOnlyGenericParameter> IEnumerable<IReadOnlyGenericParameter>.GetEnumerator()
    {
        return GetEnumerator();
    }

    public bool Contains(IGenericParameter item)
    {
        return _genericParameters.Contains(item);
    }

    public int IndexOf(IGenericParameter item)
    {
        return _genericParameters.IndexOf(item);
    }

    public void CopyTo(IGenericParameter[] array, int arrayIndex)
    {
        _genericParameters.CopyTo(array, arrayIndex);
    }

    public void Add(IGenericParameter item)
    {
        throw new System.NotImplementedException();
    }

    public void Clear()
    {
        throw new System.NotImplementedException();
    }

    public bool Remove(IGenericParameter item)
    {
        throw new System.NotImplementedException();
    }

    public void Insert(int index, IGenericParameter item)
    {
        throw new System.NotImplementedException();
    }

    public void RemoveAt(int index)
    {
        throw new System.NotImplementedException();
    }
}
