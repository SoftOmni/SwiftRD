using System.Collections;
using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Attributes;

public class AttributeGroup : SwiftCompositeNode, IAttributeGroup
{
    private readonly List<IAttribute> _attributes;

    internal AttributeGroup(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        List<IAttribute> attributes)
        : base(buffer, children)
    {
        _attributes = attributes;
    }

    public IReadOnlyList<IAttribute> Attributes => _attributes;

    IReadOnlyList<IReadOnlyAttribute> IReadOnlyAttributeGroup.Attributes => Attributes;

    public int Count => _attributes.Count;

    public bool IsReadOnly => false;

    public new IAttribute this[int index]
    {
        get => _attributes[index];
        set => throw new System.NotImplementedException();
    }

    IReadOnlyAttribute IReadOnlyList<IReadOnlyAttribute>.this[int index]
        => _attributes[index];

    public IEnumerator<IAttribute> GetEnumerator()
    {
        return _attributes.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    IEnumerator<IReadOnlyAttribute> IEnumerable<IReadOnlyAttribute>.GetEnumerator()
    {
        return GetEnumerator();
    }

    public bool Contains(IAttribute item)
    {
        return _attributes.Contains(item);
    }

    public int IndexOf(IAttribute item)
    {
        return _attributes.IndexOf(item);
    }

    public void CopyTo(IAttribute[] array, int arrayIndex)
    {
        _attributes.CopyTo(array, arrayIndex);
    }

    public void Add(IAttribute item)
    {
        throw new System.NotImplementedException();
    }

    public void Clear()
    {
        throw new System.NotImplementedException();
    }

    public bool Remove(IAttribute item)
    {
        throw new System.NotImplementedException();
    }

    public void Insert(int index, IAttribute item)
    {
        throw new System.NotImplementedException();
    }

    public void RemoveAt(int index)
    {
        throw new System.NotImplementedException();
    }
}
