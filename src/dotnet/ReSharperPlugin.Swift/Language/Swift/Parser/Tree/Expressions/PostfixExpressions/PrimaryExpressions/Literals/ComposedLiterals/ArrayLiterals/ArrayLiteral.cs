using System.Collections;
using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types;
using SoftOmni.SwiftRd.Language.Swift.Semantics.PrimitiveLiterals;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.Literals.ComposedLiterals.ArrayLiterals;

public class ArrayLiteral : SwiftCompositeNode, IArrayLiteral
{
    public LeftSquareBracket LeftSquareBracket { get; }

    private readonly List<IExpression> _expressions;

    private readonly List<Comma> _commas;
    
    public RightSquareBracket RightSquareBracket { get; }

    private IPrimitiveLiteralTypeResolutionContext _primitiveLiteralTypeResolutionContext;

    internal ArrayLiteral(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        LeftSquareBracket leftSquareBracket, List<IExpression> expressions, List<Comma> commas,
        RightSquareBracket rightSquareBracket, IPrimitiveLiteralTypeResolutionContext primitiveLiteralTypeResolutionContext)
        : base(buffer, children)
    {
        LeftSquareBracket = leftSquareBracket;
        _expressions = expressions;
        _commas = commas;
        RightSquareBracket = rightSquareBracket;

        _primitiveLiteralTypeResolutionContext = primitiveLiteralTypeResolutionContext;
    }

    public IReadOnlyList<IReadOnlyExpression> Expressions => _expressions;

    public IReadOnlyList<Comma> Commas => _commas;

    public int Count => _expressions.Count;

    public bool IsReadOnly => false;

    public IExpression[] Value
    {
        get
        {
            var value = new IExpression[Count];
            for (int index = 0; index < _expressions.Count; index++)
            {
                value[index] = _expressions[index];
            }

            return value;
        }
    }

    IReadOnlyExpression[] IReadOnlyLiteral<IReadOnlyExpression[]>.Value
    {
        get
        {
            var value = new IReadOnlyExpression[Count];
            for (int index = 0; index < _expressions.Count; index++)
            {
                value[index] = _expressions[index];
            }

            return value;
        }
    }
    
    public IType ReturnType { get; }
    

    IReadOnlyType IReadOnlyBaseExpression.ReturnType => ReturnType;

    public IReadOnlyPrimitiveLiteralTypeResolutionContext PrimitiveLiteralTypeResolutionContext =>
        _primitiveLiteralTypeResolutionContext;

    IReadOnlyExpression IReadOnlyList<IReadOnlyExpression>.this[int index] => _expressions[index];

    IExpression IList<IExpression>.this[int index]
    {
        get => _expressions[index];
        set => throw new System.NotImplementedException();
    }

    IExpression IArrayLiteral.this[int index] => _expressions[index];

    IEnumerator IEnumerable.GetEnumerator()
    {
        return _expressions.GetEnumerator();
    }

    IEnumerator<IReadOnlyExpression> IEnumerable<IReadOnlyExpression>.GetEnumerator()
    {
        return _expressions.GetEnumerator();
    }

    IEnumerator<IExpression> IEnumerable<IExpression>.GetEnumerator()
    {
        return _expressions.GetEnumerator();
    }

    IEnumerator<IExpression> IArrayLiteral.GetEnumerator()
    {
        return _expressions.GetEnumerator();
    }

    public IExpression[] GetValueCopy()
    {
        throw new System.NotImplementedException();
    }

    IReadOnlyExpression[] IReadOnlyLiteral<IReadOnlyExpression[]>.GetValueCopy()
    {
        throw new System.NotImplementedException();
    }

    IExpression[] IReadOnlyLiteral<IExpression[]>.GetValueCopy()
    {
        throw new System.NotImplementedException();
    }

    public void SetValue(IExpression[] newValue)
    {
        throw new System.NotImplementedException();
    }

    public bool Contains(IExpression item)
    {
        return _expressions.Contains(item);
    }

    public int IndexOf(IExpression item)
    {
        return _expressions.IndexOf(item);
    }

    public void CopyTo(IExpression[] array, int arrayIndex)
    {
        _expressions.CopyTo(array, arrayIndex);
    }

    public void Add(IExpression item)
    {
        throw new System.NotImplementedException();
    }

    public void Clear()
    {
        throw new System.NotImplementedException();
    }

    public bool Remove(IExpression item)
    {
        throw new System.NotImplementedException();
    }

    public void Insert(int index, IExpression item)
    {
        throw new System.NotImplementedException();
    }

    public void RemoveAt(int index)
    {
        throw new System.NotImplementedException();
    }

    public void ChangeLiteralContext(IReadOnlyPrimitiveLiteralTypeResolutionContext newContext)
    {
        throw new System.NotImplementedException();
    }
}
