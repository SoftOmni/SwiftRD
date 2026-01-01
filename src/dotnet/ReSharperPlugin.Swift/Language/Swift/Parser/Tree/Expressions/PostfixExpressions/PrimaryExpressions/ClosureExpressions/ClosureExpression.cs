using System.Collections;
using System.Collections.Generic;
using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Parser.Tree.Attributes;
using ReSharperPlugin.Swift.Language.Parser.Tree.Base.InternalNode;
using ReSharperPlugin.Swift.Language.Parser.Tree.Punctuators;
using ReSharperPlugin.Swift.Language.Parser.Tree.Statements;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.ClosureExpressions;

public class ClosureExpression : PrimaryExpressionInternalNode, IList<IStatement>
{
    public LeftCurlyBrace? LeftCurlyBrace { get; internal set; }
    
    public AttributeGroup? AttributeGroup { get; internal set; }
    
    public ClosureSignature? ClojureSignature { get; internal set; }

    private List<IStatement> _statements = [];
    
    public RightCurlyBrace? RightCurlyBrace { get; internal set; }
    
    public ClosureExpression(IEditableBuffer buffer, List<ISwiftNode> children)
        : base(buffer, children)
    { }

    public ClosureExpression(IEditableBuffer buffer, IEnumerable<ISwiftNode> children)
        : base(buffer, children)
    { }

    public ClosureExpression(SwiftInternalNode parent, IEditableBuffer buffer, List<ISwiftNode> nodes)
        : base(parent, buffer, nodes)
    { }

    public ClosureExpression(SwiftInternalNode parent, IEditableBuffer buffer, IEnumerable<ISwiftNode> nodes)
        : base(parent, buffer, nodes)
    { }

    public IReadOnlyList<IStatement> Statements => _statements;
    public IEnumerator<IStatement> GetEnumerator()
    {
        throw new System.NotImplementedException();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Add(IStatement item)
    {
        throw new System.NotImplementedException();
    }

    public void Clear()
    {
        throw new System.NotImplementedException();
    }

    public bool Contains(IStatement item)
    {
        throw new System.NotImplementedException();
    }

    public void CopyTo(IStatement[] array, int arrayIndex)
    {
        throw new System.NotImplementedException();
    }

    public bool Remove(IStatement item)
    {
        throw new System.NotImplementedException();
    }

    public int Count { get; }
    public bool IsReadOnly { get; }
    public int IndexOf(IStatement item)
    {
        throw new System.NotImplementedException();
    }

    public void Insert(int index, IStatement item)
    {
        throw new System.NotImplementedException();
    }

    public void RemoveAt(int index)
    {
        throw new System.NotImplementedException();
    }

    public IStatement this[int index]
    {
        get => throw new System.NotImplementedException();
        set => throw new System.NotImplementedException();
    }
}