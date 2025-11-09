using System.Collections;
using System.Collections.Generic;
using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Parser.Tree.Punctuators;
using ReSharperPlugin.Swift.Language.Semantics.Type;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.Literals.ComposedLiterals;

public class DictionaryLiteral : LiteralExpressionInternalNode, IList<DictionaryLiteralItem> /*,
    ILiteral<Dictionary, Dictionary<dynamic, dynamic>>*/ // TODO: Try to address
{
    public LeftSquareBracket? LeftSquareBracket { get; internal set; }
    
    private List<DictionaryLiteralItem> _dictionaryItems = [];
    
    public RightSquareBracket? RightSquareBracket { get; internal set; }
    
    public Colon? Colon { get; internal set; }

    public DictionaryLiteral(IEditableBuffer buffer, List<ISwiftNode> children)
        : base(buffer, children)
    { }

    public DictionaryLiteral(IEditableBuffer buffer, IEnumerable<ISwiftNode> children)
        : base(buffer, children)
    { }

    public DictionaryLiteral(ISwiftNode parent, IEditableBuffer buffer, List<ISwiftNode> nodes)
        : base(parent, buffer, nodes)
    { }

    public DictionaryLiteral(ISwiftNode parent, IEditableBuffer buffer, IEnumerable<ISwiftNode> nodes)
        : base(parent, buffer, nodes)
    { }

    public IReadOnlyList<DictionaryLiteralItem> Items => _dictionaryItems;


    public IEnumerator<DictionaryLiteralItem> GetEnumerator()
    {
        throw new System.NotImplementedException();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Add(DictionaryLiteralItem item)
    {
        throw new System.NotImplementedException();
    }

    public void Clear()
    {
        throw new System.NotImplementedException();
    }

    public bool Contains(DictionaryLiteralItem item)
    {
        throw new System.NotImplementedException();
    }

    public void CopyTo(DictionaryLiteralItem[] array, int arrayIndex)
    {
        throw new System.NotImplementedException();
    }

    public bool Remove(DictionaryLiteralItem item)
    {
        throw new System.NotImplementedException();
    }

    public int Count { get; }
    public bool IsReadOnly { get; }
    public int IndexOf(DictionaryLiteralItem item)
    {
        throw new System.NotImplementedException();
    }

    public void Insert(int index, DictionaryLiteralItem item)
    {
        throw new System.NotImplementedException();
    }

    public void RemoveAt(int index)
    {
        throw new System.NotImplementedException();
    }

    public DictionaryLiteralItem this[int index]
    {
        get => throw new System.NotImplementedException();
        set => throw new System.NotImplementedException();
    }
}