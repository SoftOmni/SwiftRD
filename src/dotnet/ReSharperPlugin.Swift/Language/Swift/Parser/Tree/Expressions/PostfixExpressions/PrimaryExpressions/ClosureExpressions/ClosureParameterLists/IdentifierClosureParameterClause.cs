using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Collections;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.InternalNode;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Identifiers;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.ClosureExpressions.
    ClojureParameterLists;

public class IdentifierClosureParameterClause : ClosureParameterClause, IList<Identifier>
{
    public IdentifierList? IdentifierList { get; internal set; }

    public IdentifierClosureParameterClause(IEditableBuffer buffer, List<ISwiftNode> children)
        : base(buffer, children)
    { }

    public IdentifierClosureParameterClause(IEditableBuffer buffer, IEnumerable<ISwiftNode> children)
        : base(buffer, children)
    { }

    public IdentifierClosureParameterClause(SwiftInternalNode parent, IEditableBuffer buffer, List<ISwiftNode> nodes)
        : base(parent, buffer, nodes)
    { }

    public IdentifierClosureParameterClause(SwiftInternalNode parent, IEditableBuffer buffer, IEnumerable<ISwiftNode> nodes)
        : base(parent, buffer, nodes)
    { }

    public IEnumerator<Identifier> GetEnumerator()
    {
        return IdentifierList?.GetEnumerator() ?? new EmptyEnumerator<Identifier>();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Add(Identifier item)
    {
        IdentifierList?.Add(item);
    }

    public void Clear()
    {
        IdentifierList?.Clear();
    }

    public bool Contains(Identifier item)
    {
        return IdentifierList?.Contains(item) ?? false;
    }

    public void CopyTo(Identifier[] array, int arrayIndex)
    {
        if (IdentifierList is null)
        {
            return;
        }
        
        IdentifierList.CopyTo(array, arrayIndex);
    }

    public bool Remove(Identifier item)
    {
        return IdentifierList?.Remove(item) ?? false;
    }

    public int Count => IdentifierList?.Count ?? 0;

    public bool IsReadOnly => IdentifierList?.IsReadOnly ?? true;
    public int IndexOf(Identifier item)
    {
        if (IdentifierList is null)
        {
            return -1;
        }

        return IdentifierList.IndexOf(item);
    }

    public void Insert(int index, Identifier item)
    {
        if (IdentifierList is null)
        {
            return;
        }
        
        IdentifierList.Insert(index, item);
    }

    public void RemoveAt(int index)
    {
        IdentifierList?.RemoveAt(index);
    }

    Identifier IList<Identifier>.this[int index]
    {
        get => GetIdentifierAt(index)!;
        set => SetIdentifierAt(value, index);
    }

    public Identifier GetIdentifierAt(int index)
    {
        if (IdentifierList is null)
        {
            throw new ArgumentNullException(nameof(IdentifierList));
        }

        return IdentifierList[index];
    }

    public void SetIdentifierAt(Identifier newIdentifier, int index)
    {
        if (IdentifierList is null)
        {
            throw new ArgumentNullException(nameof(IdentifierList));
        }

        IdentifierList[index] = newIdentifier;
    }
}