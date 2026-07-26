using System.Collections;
using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Generics.GenericWhereClauseClauses;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Generics.WhereClauses;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;
using SoftOmni.SwiftRd.Rider.Language.Swift.Parser.Tree.Generics.WhereClauses.Requirements;

namespace SoftOmni.SwiftRd.Rider.Language.Swift.Parser.Tree.Generics.WhereClauses;

public class GenericWhereClause : SwiftCompositeNode, IGenericWhereClause
{
    public Where WhereKeyword { get; }

    private List<IRequirement> _requirements;

    private List<Comma> _requirementSeparators;

    internal GenericWhereClause(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        Where whereKeyword, List<IRequirement> requirements, List<Comma> requirementSeparators)
        : base(buffer, children)
    {
        _requirements = requirements;
        _requirementSeparators = requirementSeparators;
        WhereKeyword = whereKeyword;
    }

    public IReadOnlyList<IRequirement> Requirements => _requirements;

    IReadOnlyList<IReadOnlyRequirement> IReadOnlyGenericWhereClause.Requirements => Requirements;

    public IReadOnlyList<Comma> RequirementSeparators => _requirementSeparators;

    public int Count => _requirements.Count;

    public bool IsReadOnly => false;

    public new IRequirement this[int index]
    {
        get => _requirements[index];
        set => throw new System.NotImplementedException();
    }

    IReadOnlyRequirement IReadOnlyList<IReadOnlyRequirement>.this[int index]
        => _requirements[index];

    IReadOnlyRequirement IReadOnlyGenericWhereClause.this[int index]
        => _requirements[index];

    public IEnumerator<IRequirement> GetEnumerator()
    {
        return _requirements.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    IEnumerator<IReadOnlyRequirement> IEnumerable<IReadOnlyRequirement>.GetEnumerator()
    {
        return GetEnumerator();
    }

    public bool Contains(IRequirement item)
    {
        return _requirements.Contains(item);
    }

    public int IndexOf(IRequirement item)
    {
        return _requirements.IndexOf(item);
    }

    public void CopyTo(IRequirement[] array, int arrayIndex)
    {
        _requirements.CopyTo(array, arrayIndex);
    }

    public void Add(IRequirement item)
    {
        throw new System.NotImplementedException();
    }

    public void Clear()
    {
        throw new System.NotImplementedException();
    }

    public bool Remove(IRequirement item)
    {
        throw new System.NotImplementedException();
    }

    public void Insert(int index, IRequirement item)
    {
        throw new System.NotImplementedException();
    }

    public void RemoveAt(int index)
    {
        throw new System.NotImplementedException();
    }
}
