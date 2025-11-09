using System.Collections;
using System.Collections.Generic;
using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.ClosureExpressions;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Expressions.PostfixExpressions.FunctionCallExpressions.Closures;

public class TrailingClosures : SwiftInternalNode, IList<LabeledTrailingClosure>
{
    public ClosureExpression? ClosureExpression { get; internal set; }

    private List<LabeledTrailingClosure> _trailingClosures = [];
    
    public TrailingClosures(IEditableBuffer buffer, List<ISwiftNode> children)
        : base(buffer, children)
    { }

    public TrailingClosures(IEditableBuffer buffer, IEnumerable<ISwiftNode> children)
        : base(buffer, children)
    { }

    public TrailingClosures(ISwiftNode parent, IEditableBuffer buffer, List<ISwiftNode> nodes)
        : base(parent, buffer, nodes)
    { }

    public TrailingClosures(ISwiftNode parent, IEditableBuffer buffer, IEnumerable<ISwiftNode> nodes)
        : base(parent, buffer, nodes)
    { }

    public IReadOnlyList<LabeledTrailingClosure> LabeledTrailingClosures => _trailingClosures;

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public IEnumerator<LabeledTrailingClosure> GetEnumerator()
    {
        throw new System.NotImplementedException();
    }

    public void Add(LabeledTrailingClosure item)
    {
        throw new System.NotImplementedException();
    }

    public void Clear()
    {
        throw new System.NotImplementedException();
    }

    public bool Contains(LabeledTrailingClosure item)
    {
        throw new System.NotImplementedException();
    }

    public void CopyTo(LabeledTrailingClosure[] array, int arrayIndex)
    {
        throw new System.NotImplementedException();
    }

    public bool Remove(LabeledTrailingClosure item)
    {
        throw new System.NotImplementedException();
    }

    public int Count { get; }
    public bool IsReadOnly { get; }
    public int IndexOf(LabeledTrailingClosure item)
    {
        throw new System.NotImplementedException();
    }

    public void Insert(int index, LabeledTrailingClosure item)
    {
        throw new System.NotImplementedException();
    }

    public void RemoveAt(int index)
    {
        throw new System.NotImplementedException();
    }

    public LabeledTrailingClosure this[int index]
    {
        get => throw new System.NotImplementedException();
        set => throw new System.NotImplementedException();
    }
}