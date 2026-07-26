using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.CompilerControlStatements.AvailabilityConditions.AvailabilityArguments;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.CompilerControlStatements.AvailabilityConditions;

public class AvailabilityArgumentsList : SwiftCompositeNode, IAvailabilityArgumentsList
{
    private readonly List<IAvailabilityArgument> _arguments;

    private readonly List<Comma> _argumentsSeparators;

    internal AvailabilityArgumentsList(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        List<IAvailabilityArgument> arguments, List<Comma> argumentsSeparators)
        : base(buffer, children)
    {
        _arguments = arguments;
        _argumentsSeparators = argumentsSeparators;
    }

    public IReadOnlyList<Comma> ArgumentSeparators => _argumentsSeparators;

    public IReadOnlyList<IAvailabilityArgument> Arguments => _arguments;

    IReadOnlyList<IReadOnlyAvailabilityArgument> IReadOnlyAvailabilityArgumentsList.Arguments => Arguments;

    public int Count => _arguments.Count;

    public bool IsReadOnly => false;

    public new IAvailabilityArgument this[int index]
    {
        get => _arguments[index];
        set => throw new NotImplementedException();
    }

    IReadOnlyAvailabilityArgument IReadOnlyList<IReadOnlyAvailabilityArgument>.this[int index]
        => _arguments[index];

    public IEnumerator<IAvailabilityArgument> GetEnumerator()
    {
        return _arguments.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    IEnumerator<IReadOnlyAvailabilityArgument> IEnumerable<IReadOnlyAvailabilityArgument>.GetEnumerator()
    {
        return GetEnumerator();
    }

    public bool Contains(IAvailabilityArgument item)
    {
        return _arguments.Contains(item);
    }

    public int IndexOf(IAvailabilityArgument item)
    {
        return _arguments.IndexOf(item);
    }

    public void CopyTo(IAvailabilityArgument[] array, int arrayIndex)
    {
        _arguments.CopyTo(array, arrayIndex);
    }

    public void Add(IAvailabilityArgument item)
    {
        throw new NotImplementedException();
    }

    public void Clear()
    {
        throw new NotImplementedException();
    }

    public bool Remove(IAvailabilityArgument item)
    {
        throw new NotImplementedException();
    }

    public void Insert(int index, IAvailabilityArgument item)
    {
        throw new NotImplementedException();
    }

    public void RemoveAt(int index)
    {
        throw new NotImplementedException();
    }
}
