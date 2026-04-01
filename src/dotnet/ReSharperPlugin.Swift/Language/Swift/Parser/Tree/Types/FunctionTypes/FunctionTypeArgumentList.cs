using System.Collections;
using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.InternalNode;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.FunctionTypes;

public class FunctionTypeArgumentList : SwiftInternalNode, IList<FunctionTypeArgument>
{
    public FunctionType? FunctionType { get; internal set; }
    
    private List<FunctionTypeArgument> _arguments = [];

    public FunctionTypeArgumentList(IEditableBuffer buffer, List<ISwiftNode> children) 
        : base(buffer, children)
    { }

    public FunctionTypeArgumentList(IEditableBuffer buffer, IEnumerable<ISwiftNode> children) 
        : base(buffer, children)
    { }

    public FunctionTypeArgumentList(SwiftInternalNode parent, IEditableBuffer buffer, List<ISwiftNode> nodes) 
        : base(parent, buffer, nodes)
    { }

    public FunctionTypeArgumentList(SwiftInternalNode parent, IEditableBuffer buffer, IEnumerable<ISwiftNode> nodes) 
        : base(parent, buffer, nodes)
    { }

    public IReadOnlyList<FunctionTypeArgument> Arguments => _arguments;

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public IEnumerator<FunctionTypeArgument> GetEnumerator()
    {
        throw new System.NotImplementedException();
    }

    public void Add(FunctionTypeArgument item)
    {
        throw new System.NotImplementedException();
    }

    public void Clear()
    {
        throw new System.NotImplementedException();
    }

    public bool Contains(FunctionTypeArgument item)
    {
        throw new System.NotImplementedException();
    }

    public void CopyTo(FunctionTypeArgument[] array, int arrayIndex)
    {
        throw new System.NotImplementedException();
    }

    public bool Remove(FunctionTypeArgument item)
    {
        throw new System.NotImplementedException();
    }

    public int Count { get; }
    public bool IsReadOnly { get; }
    public int IndexOf(FunctionTypeArgument item)
    {
        throw new System.NotImplementedException();
    }

    public void Insert(int index, FunctionTypeArgument item)
    {
        throw new System.NotImplementedException();
    }

    public void RemoveAt(int index)
    {
        throw new System.NotImplementedException();
    }

    public FunctionTypeArgument this[int index]
    {
        get => throw new System.NotImplementedException();
        set => throw new System.NotImplementedException();
    }
}