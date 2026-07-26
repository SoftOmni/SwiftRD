using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.CompilerControlStatements.AvailabilityConditions.AvailabilityArguments;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.CompilerControlStatements.AvailabilityConditions;

public class AvailableAvailabilityCondition : SwiftCompositeNode, IAvailableAvailabilityCondition
{
    public ReservedAvailableKeyword ReservedAvailableKeyword { get; }

    public LeftParenthesis ArgumentsStart { get; }

    public IAvailabilityArgumentsList ArgumentsList { get; }

    public RightParenthesis ArgumentsEnd { get; }

    internal AvailableAvailabilityCondition(IEditableBuffer buffer,
        IEnumerable<ISwiftNode<SwiftCompositeNode>> children, ReservedAvailableKeyword availableKeyword,
        LeftParenthesis argumentsStart, IAvailabilityArgumentsList argumentsList, RightParenthesis argumentsEnd)
        : base(buffer, children)
    {
        ReservedAvailableKeyword = availableKeyword;
        ArgumentsStart = argumentsStart;
        ArgumentsList = argumentsList;
        ArgumentsEnd = argumentsEnd;
    }

    IReadOnlyAvailabilityArgumentsList IReadOnlyAvailabilityCondition.ArgumentsList => ArgumentsList;

    public IReadOnlyList<IAvailabilityArgument> Arguments => ArgumentsList.Arguments;

    IReadOnlyList<IReadOnlyAvailabilityArgument> IReadOnlyAvailabilityCondition.Arguments => Arguments;

    public int Count => ArgumentsList.Count;

    public bool IsReadOnly => ArgumentsList.IsReadOnly;

    public IEnumerator<IAvailabilityArgument> GetEnumerator()
    {
        return ArgumentsList.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    IEnumerator<IReadOnlyAvailabilityArgument> IEnumerable<IReadOnlyAvailabilityArgument>.GetEnumerator()
    {
        return GetEnumerator();
    }

    public new IAvailabilityArgument this[int index]
    {
        get => ArgumentsList[index];
        set => ArgumentsList[index] = value;
    }

    IReadOnlyAvailabilityArgument IReadOnlyList<IReadOnlyAvailabilityArgument>.this[int index] =>
        ArgumentsList[index];

    public bool Contains(IAvailabilityArgument item)
    {
        return ArgumentsList.Contains(item);
    }

    public int IndexOf(IAvailabilityArgument item)
    {
        return ArgumentsList.IndexOf(item);
    }

    public void CopyTo(IAvailabilityArgument[] array, int arrayIndex)
    {
        ArgumentsList.CopyTo(array, arrayIndex);
    }

    public void Add(IAvailabilityArgument item)
    {
        ArgumentsList.Add(item);
    }

    public void Clear()
    {
        ArgumentsList.Clear();
    }

    public bool Remove(IAvailabilityArgument item)
    {
        return ArgumentsList.Remove(item);
    }

    public void Insert(int index, IAvailabilityArgument item)
    {
        ArgumentsList.Insert(index, item);
    }

    public void RemoveAt(int index)
    {
        ArgumentsList.RemoveAt(index);
    }

    public void ChangeArgumentsList(IAvailabilityArgumentsList newArgumentsList)
    {
        throw new NotImplementedException();
    }
}