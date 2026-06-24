using System.Collections;
using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types;
using SoftOmni.SwiftRd.Language.Swift.Semantics.PrimitiveLiterals;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.Literals.ComposedLiterals.DictionaryLiterals;

public class DictionaryLiteral : SwiftCompositeNode, IDictionaryLiteral
{
    public LeftSquareBracket LeftSquareBracket { get; }

    private readonly List<IDictionaryLiteralElement> _elements;

    private readonly List<Comma> _commas;
    
    public RightSquareBracket RightSquareBracket { get; }

    private readonly IPrimitiveLiteralTypeResolutionContext _primitiveLiteralTypeResolutionContext;

    internal DictionaryLiteral(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        LeftSquareBracket leftSquareBracket, List<IDictionaryLiteralElement> elements, List<Comma> commas,
        RightSquareBracket rightSquareBracket, IPrimitiveLiteralTypeResolutionContext primitiveLiteralTypeResolutionContext)
        : base(buffer, children)
    {
        LeftSquareBracket = leftSquareBracket;
        _elements = elements;
        _commas = commas;
        RightSquareBracket = rightSquareBracket;
        
        _primitiveLiteralTypeResolutionContext = primitiveLiteralTypeResolutionContext;

        ReturnType = UnknownType.Instance;
    }

    public IReadOnlyList<IReadOnlyDictionaryLiteralElement> DictionaryLiteralElements =>
        _elements;

    public IReadOnlyList<Comma> Commas =>
        _commas;

    public IReadOnlyPrimitiveLiteralTypeResolutionContext PrimitiveLiteralTypeResolutionContext =>
        _primitiveLiteralTypeResolutionContext;

    public IDictionary<IExpression, IExpression> Value
    {
        get
        {
            Dictionary<IExpression, IExpression> value = [];

            foreach (IDictionaryLiteralElement element in _elements)
            {
                value.Add(element.KeyExpression, element.ValueExpression);
            }

            return value;
        }
    }

    IDictionary<IReadOnlyExpression, IReadOnlyExpression> IReadOnlyLiteral<IDictionary<IReadOnlyExpression, IReadOnlyExpression>>.Value
    {
        get
        {
            Dictionary<IReadOnlyExpression, IReadOnlyExpression> value = [];

            foreach (IDictionaryLiteralElement element in _elements)
            {
                value.Add(element.KeyExpression, element.ValueExpression);
            }
            
            return value;
        }
    }

    public IType ReturnType { get; }

    IReadOnlyType IReadOnlyBaseExpression.ReturnType => ReturnType;

    public int Count => _elements.Count;

    public bool IsReadOnly => false;

    public IDictionary<IExpression, IExpression> GetValueCopy()
    {
        return Value;
    }

    IDictionary<IReadOnlyExpression, IReadOnlyExpression> IReadOnlyLiteral<IDictionary<IReadOnlyExpression, IReadOnlyExpression>>.GetValueCopy()
    {
        return ((IReadOnlyDictionaryLiteral)this).Value;
    }

    public void SetValue(IDictionary<IExpression, IExpression> newValue)
    {
        throw new System.NotImplementedException();
    }

    public new IDictionaryLiteralElement this[int index]
    {
        get => _elements[index];
        set => throw new System.NotImplementedException();
    }

    IReadOnlyDictionaryLiteralElement IReadOnlyList<IReadOnlyDictionaryLiteralElement>.this[int index]
        => _elements[index];

    public IEnumerator<IDictionaryLiteralElement> GetEnumerator()
    {
        return _elements.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return _elements.GetEnumerator();
    }

    IEnumerator<IReadOnlyDictionaryLiteralElement> IEnumerable<IReadOnlyDictionaryLiteralElement>.GetEnumerator()
    {
        return _elements.GetEnumerator();
    }

    IEnumerator<IDictionaryLiteralElement> IEnumerable<IDictionaryLiteralElement>.GetEnumerator()
    {
        return _elements.GetEnumerator();
    }

    public bool Contains(IDictionaryLiteralElement item)
    {
        return _elements.Contains(item);
    }

    public int IndexOf(IDictionaryLiteralElement item)
    {
        return _elements.IndexOf(item);
    }

    public void CopyTo(IDictionaryLiteralElement[] array, int arrayIndex)
    {
        _elements.CopyTo(array, arrayIndex);
    }

    public void Add(IDictionaryLiteralElement item)
    {
        throw new System.NotImplementedException();
    }

    public void Clear()
    {
        throw new System.NotImplementedException();
    }

    public bool Remove(IDictionaryLiteralElement item)
    {
        throw new System.NotImplementedException();
    }

    public void Insert(int index, IDictionaryLiteralElement item)
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
