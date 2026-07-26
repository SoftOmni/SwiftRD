using System.Collections;
using System.Collections.Generic;
using JetBrains.Application.UI.Icons.CompiledIcons;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Identifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;
using SoftOmni.SwiftRd.Resources.Icons.Language;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.PrecedenceGroups;

public class PrecedenceGroupDeclaration : SwiftCompositeNode, IPrecedenceGroupDeclaration
{
    public PrecedenceGroupKeyword PrecedenceGroupKeyword { get; }

    public IIdentifier Name { get; }

    public LeftCurlyBrace AttributesStart { get; }

    private readonly List<IPrecedenceGroupAttribute> _attributes;

    public RightCurlyBrace AttributesEnd { get; }

    internal PrecedenceGroupDeclaration(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        PrecedenceGroupKeyword precedenceGroupKeyword, IIdentifier name, LeftCurlyBrace attributesStart,
        List<IPrecedenceGroupAttribute> attributes, RightCurlyBrace attributesEnd)
        : base(buffer, children)
    {
        PrecedenceGroupKeyword = precedenceGroupKeyword;
        Name = name;
        AttributesStart = attributesStart;
        _attributes = attributes;
        AttributesEnd = attributesEnd;

        Icon = SwiftIcons.ConstantIcon;
    }

    public AnyCompiledIconClass Icon { get; }

    IReadOnlyIdentifier IReadOnlyPrecedenceGroupDeclaration.Name => Name;

    public IReadOnlyList<IPrecedenceGroupAttribute> PrecedenceGroupAttributes => _attributes;

    IReadOnlyList<IReadOnlyPrecedenceGroupAttribute> IReadOnlyPrecedenceGroupDeclaration.PrecedenceGroupAttributes =>
        PrecedenceGroupAttributes;

    public int Count => _attributes.Count;

    public bool IsReadOnly => false;

    public new IPrecedenceGroupAttribute this[int index]
    {
        get => _attributes[index];
        set => throw new System.NotImplementedException();
    }

    IReadOnlyPrecedenceGroupAttribute IReadOnlyPrecedenceGroupDeclaration.this[int index]
        => _attributes[index];

    IReadOnlyPrecedenceGroupAttribute IReadOnlyList<IReadOnlyPrecedenceGroupAttribute>.this[int index]
        => _attributes[index];

    public IEnumerator<IPrecedenceGroupAttribute> GetEnumerator()
    {
        return _attributes.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    IEnumerator<IReadOnlyPrecedenceGroupAttribute> IEnumerable<IReadOnlyPrecedenceGroupAttribute>.GetEnumerator()
    {
        return GetEnumerator();
    }

    public bool Contains(IPrecedenceGroupAttribute item)
    {
        return _attributes.Contains(item);
    }

    public void CopyTo(IPrecedenceGroupAttribute[] array, int arrayIndex)
    {
        _attributes.CopyTo(array, arrayIndex);
    }

    public int IndexOf(IPrecedenceGroupAttribute item)
    {
        return _attributes.IndexOf(item);
    }

    public void Add(IPrecedenceGroupAttribute item)
    {
        throw new System.NotImplementedException();
    }

    public void Clear()
    {
        throw new System.NotImplementedException();
    }

    public bool Remove(IPrecedenceGroupAttribute item)
    {
        throw new System.NotImplementedException();
    }

    public void Insert(int index, IPrecedenceGroupAttribute item)
    {
        throw new System.NotImplementedException();
    }

    public void RemoveAt(int index)
    {
        throw new System.NotImplementedException();
    }
}
