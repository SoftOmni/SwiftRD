using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Identifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.PrecedenceGroups.Relations;

public class LowerThanPrecedenceGroupRelation : SwiftCompositeNode, ILowerThanPrecedenceGroupRelation
{
    public LowerThan LowerThanKeyword { get; }

    public Colon PrecedenceGroupNamesIntroducer { get; }

    private readonly List<IIdentifier> _precedenceGroupNames;

    private readonly List<Comma> _precedenceGroupNameSeparators;

    internal LowerThanPrecedenceGroupRelation(IEditableBuffer buffer,
        IEnumerable<ISwiftNode<SwiftCompositeNode>> children, LowerThan lowerThanKeyword,
        Colon precedenceGroupNamesIntroducer, List<IIdentifier> precedenceGroupNames,
        List<Comma> precedenceGroupNameSeparators)
        : base(buffer, children)
    {
        _precedenceGroupNames = precedenceGroupNames;
        _precedenceGroupNameSeparators = precedenceGroupNameSeparators;
        LowerThanKeyword = lowerThanKeyword;
        PrecedenceGroupNamesIntroducer = precedenceGroupNamesIntroducer;
    }

    public IReadOnlyList<IIdentifier> PrecedenceGroupNames => _precedenceGroupNames;

    IReadOnlyList<IReadOnlyIdentifier> IReadOnlyPrecedenceGroupRelation.PrecedenceGroupNames => PrecedenceGroupNames;

    public IReadOnlyList<Comma> PrecedenceGroupNameSeparators => _precedenceGroupNameSeparators;

    public int Count => _precedenceGroupNames.Count;

    public bool IsReadOnly => false;

    public new IIdentifier this[int index]
    {
        get => _precedenceGroupNames[index];
        set => throw new NotImplementedException();
    }

    IReadOnlyIdentifier IReadOnlyPrecedenceGroupRelation.this[int index]
        => _precedenceGroupNames[index];

    IReadOnlyIdentifier IReadOnlyList<IReadOnlyIdentifier>.this[int index]
        => _precedenceGroupNames[index];

    public IEnumerator<IIdentifier> GetEnumerator()
    {
        return _precedenceGroupNames.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    IEnumerator<IReadOnlyIdentifier> IEnumerable<IReadOnlyIdentifier>.GetEnumerator()
    {
        return GetEnumerator();
    }

    public bool Contains(IIdentifier item)
    {
        return _precedenceGroupNames.Contains(item);
    }

    public int IndexOf(IIdentifier item)
    {
        return _precedenceGroupNames.IndexOf(item);
    }

    public void CopyTo(IIdentifier[] array, int arrayIndex)
    {
        _precedenceGroupNames.CopyTo(array, arrayIndex);
    }

    public void Add(IIdentifier item)
    {
        throw new NotImplementedException();
    }

    public void Clear()
    {
        throw new NotImplementedException();
    }

    public bool Remove(IIdentifier item)
    {
        throw new NotImplementedException();
    }

    public void Insert(int index, IIdentifier item)
    {
        throw new NotImplementedException();
    }

    public void RemoveAt(int index)
    {
        throw new NotImplementedException();
    }
}
