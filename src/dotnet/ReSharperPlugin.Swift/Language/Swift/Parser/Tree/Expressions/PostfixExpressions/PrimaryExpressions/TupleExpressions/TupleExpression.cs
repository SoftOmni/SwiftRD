using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.TupleExpressions;

public class TupleExpression : SwiftCompositeNode, ITupleExpression
{
    public LeftParenthesis LeftParenthesis { get; }

    private readonly List<ITupleExpressionElement> _tupleElements;

    private readonly List<Comma> _commas;
    
    public RightParenthesis RightParenthesis { get; }

    internal TupleExpression(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        LeftParenthesis leftParenthesis, List<ITupleExpressionElement> tupleElements, List<Comma> commas,
        RightParenthesis rightParenthesis)
        : base(buffer, children)
    {
        _tupleElements = tupleElements;
        _commas = commas;
        LeftParenthesis = leftParenthesis;
        RightParenthesis = rightParenthesis;

        ReturnType = UnknownType.Instance; // TODO: Reconsider
    }

    public IReadOnlyList<ITupleExpressionElement> Elements => _tupleElements;

    IReadOnlyList<IReadOnlyTupleExpressionElement> IReadOnlyTupleExpression.Elements => Elements;

    public int NumberOfElements => Elements.Count;

    public IReadOnlyList<Comma> Commas => _commas;

    public int NumberOfCommas => Commas.Count;

    public bool IsVoid => NumberOfElements == 0; // TODO: Consider making me set by the semantic analyzer

    public IType ReturnType { get; }

    IReadOnlyType IReadOnlyBaseExpression.ReturnType => ReturnType;

    public IEnumerator<ITupleExpressionElement> GetEnumerator()
    {
        return _tupleElements.GetEnumerator();
    }

    IEnumerator<IReadOnlyTupleExpressionElement> IEnumerable<IReadOnlyTupleExpressionElement>.GetEnumerator()
    {
        return GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Add(ITupleExpressionElement item)
    {
        Insert(NumberOfElements, item);
    }

    public void Clear()
    {
        foreach (ITupleExpressionElement element in _tupleElements)
        {
            element.DetachFromParent();
        }
        
        _tupleElements.Clear();
        foreach (Comma comma in _commas)
        {
            comma.DetachFromParent();
        }
    }

    public bool Contains(ITupleExpressionElement item)
    {
        return _tupleElements.Contains(item);
    }

    public void CopyTo(ITupleExpressionElement[] array, int arrayIndex)
    {
        _tupleElements.CopyTo(array, arrayIndex);
    }

    public bool Remove(ITupleExpressionElement item)
    {
        int indexOfElement = IndexOf(item);
        if (indexOfElement == -1)
        {
            return false;
        }
        
        RemoveAtCore(indexOfElement, item);
        return true;
    }

    public int Count => NumberOfElements;

    public bool IsReadOnly => false;
    
    public int IndexOf(ITupleExpressionElement item)
    {
        return _tupleElements.IndexOf(item);
    }

    public void Insert(int index, ITupleExpressionElement item)
    {
        throw new NotImplementedException();
    }

    public void RemoveAt(int index)
    {
        if (index < 0 || index > NumberOfElements)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        RemoveAtCore(index, _tupleElements[index]);
    }

    private void RemoveAtCore(int index, ITupleExpressionElement element)
    {
        element.DetachFromParent();
        _tupleElements.RemoveAt(index);

        if (_commas.Count <= index)
        {
            return;
        }

        _commas[index].DetachFromParent();
        _commas.RemoveAt(index);
    }

    public new ITupleExpressionElement this[int index]
    {
        get => _tupleElements[index];
        set => throw new NotImplementedException();
    }

    IReadOnlyTupleExpressionElement IReadOnlyList<IReadOnlyTupleExpressionElement>.this[int index]
        => this[index];
}