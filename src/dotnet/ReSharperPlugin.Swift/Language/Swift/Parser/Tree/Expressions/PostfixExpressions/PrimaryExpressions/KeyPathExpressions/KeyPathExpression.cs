using System.Collections;
using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Operators;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types;
using SoftOmni.SwiftRd.Rider.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.KeyPathExpressions.Components;

namespace SoftOmni.SwiftRd.Rider.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.KeyPathExpressions;

public class KeyPathExpression : SwiftCompositeNode, IKeyPathExpression
{
    public IReadOnlyOperator Operator { get; }
    
    public IType? Type { get; }
    
    public Period TypeSeparator { get; }

    private readonly List<IKeyPathComponent> _keyPathComponents;

    private readonly List<Period> _keyPathComponentsSeparators;

    internal KeyPathExpression(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        IReadOnlyOperator @operator, IType? type, Period typeSeparator, List<IKeyPathComponent> keyPathComponents,
        List<Period> keyPathComponentsSeparators)
        : base(buffer, children)
    {
        _keyPathComponents = keyPathComponents;
        _keyPathComponentsSeparators = keyPathComponentsSeparators;
        Operator = @operator;
        Type = type;
        TypeSeparator = typeSeparator;

        ReturnType = UnknownType.Instance;
    }

    IReadOnlyType? IReadOnlyKeyPathExpression.Type => Type;

    public IReadOnlyList<IKeyPathComponent> KeyPathComponents => _keyPathComponents;

    IReadOnlyList<IReadOnlyKeyPathComponent> IReadOnlyKeyPathExpression.KeyPathComponents => KeyPathComponents;

    public IReadOnlyList<Period> KeyPathComponentsSeparators => _keyPathComponentsSeparators;

    public IType ReturnType { get; }

    IReadOnlyType IReadOnlyBaseExpression.ReturnType => ReturnType;

    public int Count => _keyPathComponents.Count;

    public bool IsReadOnly => false;

    public new IKeyPathComponent this[int index]
    {
        get => _keyPathComponents[index];
        set => throw new System.NotImplementedException();
    }

    IReadOnlyKeyPathComponent IReadOnlyList<IReadOnlyKeyPathComponent>.this[int index]
        => _keyPathComponents[index];

    public IEnumerator<IKeyPathComponent> GetEnumerator()
    {
        return _keyPathComponents.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    IEnumerator<IReadOnlyKeyPathComponent> IEnumerable<IReadOnlyKeyPathComponent>.GetEnumerator()
    {
        return GetEnumerator();
    }

    public bool Contains(IKeyPathComponent item)
    {
        return _keyPathComponents.Contains(item);
    }

    public int IndexOf(IKeyPathComponent item)
    {
        return _keyPathComponents.IndexOf(item);
    }

    public void CopyTo(IKeyPathComponent[] array, int arrayIndex)
    {
        _keyPathComponents.CopyTo(array, arrayIndex);
    }

    public void Add(IKeyPathComponent item)
    {
        throw new System.NotImplementedException();
    }

    public void Clear()
    {
        throw new System.NotImplementedException();
    }

    public bool Remove(IKeyPathComponent item)
    {
        throw new System.NotImplementedException();
    }

    public void Insert(int index, IKeyPathComponent item)
    {
        throw new System.NotImplementedException();
    }

    public void RemoveAt(int index)
    {
        throw new System.NotImplementedException();
    }
}
