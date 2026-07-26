using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.Literals.Literals.IntegerLiterals;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.CompilerControlStatements.ConditionalCompilationBlock.CompilationConditions.PlatformConditions;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.CompilerControlStatements.ConditionalCompilationBlock.
    CompilationConditions;

public class SwiftVersion : SwiftCompositeNode, ISwiftVersion
{
    private readonly List<IIntegerLiteral> _values;

    private readonly List<Period> _valueSeparators;

    internal SwiftVersion(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        List<IIntegerLiteral> values, List<Period> valueSeparators)
        : base(buffer, children)
    {
        _values = values;
        _valueSeparators = valueSeparators;
    }

    public IReadOnlyList<IIntegerLiteral> Values => _values;

    public IReadOnlyList<Period> ValueSeparators => _valueSeparators;

    IReadOnlyList<IReadOnlyIntegerLiteral> IReadOnlySwiftVersion.Values => Values;

    public int Count => _values.Count;

    public bool IsReadOnly => false;

    public new IIntegerLiteral this[int index]
    {
        get => _values[index];
        set => throw new NotImplementedException();
    }

    IReadOnlyIntegerLiteral IReadOnlyList<IReadOnlyIntegerLiteral>.this[int index]
        => _values[index];

    IReadOnlyIntegerLiteral IReadOnlySwiftVersion.this[int index]
        => _values[index];

    public IEnumerator<IIntegerLiteral> GetEnumerator()
    {
        return _values.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    IEnumerator<IReadOnlyIntegerLiteral> IEnumerable<IReadOnlyIntegerLiteral>.GetEnumerator()
    {
        return GetEnumerator();
    }

    public bool Contains(IIntegerLiteral item)
    {
        return _values.Contains(item);
    }

    public int IndexOf(IIntegerLiteral item)
    {
        return _values.IndexOf(item);
    }

    public void CopyTo(IIntegerLiteral[] array, int arrayIndex)
    {
        _values.CopyTo(array, arrayIndex);
    }

    public void Add(IIntegerLiteral item)
    {
        throw new NotImplementedException();
    }

    public void Clear()
    {
        throw new NotImplementedException();
    }

    public bool Remove(IIntegerLiteral item)
    {
        throw new NotImplementedException();
    }

    public void Insert(int index, IIntegerLiteral item)
    {
        throw new NotImplementedException();
    }

    public void RemoveAt(int index)
    {
        throw new NotImplementedException();
    }

    public static SwiftVersion FromVersion(Version version)
    {
        throw new NotImplementedException();
    }
}
