using System.Collections;
using System.Collections.Generic;
using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Parser.Tree.Punctuators;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Expressions.PostfixExpressions.FunctionCallExpressions.Arguments;

public class FunctionCallArgumentList : SwiftInternalNode, IList<CallArgument>
{
    private List<CallArgument> _arguments = [];

    private List<Comma> _commas = [];

    public FunctionCallArgumentList(IEditableBuffer buffer, List<ISwiftNode> children)
        : base(buffer, children)
    { }

    public FunctionCallArgumentList(IEditableBuffer buffer, IEnumerable<ISwiftNode> children)
        : base(buffer, children)
    { }

    public FunctionCallArgumentList(SwiftInternalNode parent, IEditableBuffer buffer, List<ISwiftNode> nodes)
        : base(parent, buffer, nodes)
    { }

    public FunctionCallArgumentList(SwiftInternalNode parent, IEditableBuffer buffer, IEnumerable<ISwiftNode> nodes)
        : base(parent, buffer, nodes)
    { }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public IEnumerator<CallArgument> GetEnumerator()
    {
        throw new System.NotImplementedException();
    }

    public void Add(CallArgument item)
    {
        throw new System.NotImplementedException();
    }

    public void Clear()
    {
        throw new System.NotImplementedException();
    }

    public bool Contains(CallArgument item)
    {
        throw new System.NotImplementedException();
    }

    public void CopyTo(CallArgument[] array, int arrayIndex)
    {
        throw new System.NotImplementedException();
    }

    public bool Remove(CallArgument item)
    {
        throw new System.NotImplementedException();
    }

    public int Count { get; }
    public bool IsReadOnly { get; }
    public int IndexOf(CallArgument item)
    {
        throw new System.NotImplementedException();
    }

    public void Insert(int index, CallArgument item)
    {
        throw new System.NotImplementedException();
    }

    public void RemoveAt(int index)
    {
        throw new System.NotImplementedException();
    }

    public CallArgument this[int index]
    {
        get => throw new System.NotImplementedException();
        set => throw new System.NotImplementedException();
    }
}