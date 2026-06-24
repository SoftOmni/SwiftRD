using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.LeafNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.NodeTypes;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Identifiers;

public class Identifier : SwiftLeafNode<SwiftCompositeNode>, IIdentifier
{
    private int _count;
    private int _count1;
    private int _count2;
    public bool IsOnlyAscii { get; private set; }

    internal Identifier(IEditableBuffer buffer)
        : base(buffer)
    {
        IsOnlyAscii = IsMadeUpOfAscii();
    }

    internal Identifier(IEditableBuffer buffer, SwiftCompositeNode parentNode, int parentIndex, int parentTextIndex)
        : base(buffer, parentNode, parentIndex, parentTextIndex)
    {
        IsOnlyAscii = IsMadeUpOfAscii();
    }

    public override NodeType NodeType => SwiftNodeTypes.Identifier;

    public string GetIdentifierAsString()
    {
        return GetText();
    }

    private bool IsMadeUpOfAscii()
    {
        for (int i = 0; i < Buffer.Length; i++)
        {
            char character = Buffer[i];
            if (character >= 127)
            {
                return false;
            }
        }

        return true;
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public IEnumerator<char> GetEnumerator()
    {
        throw new NotImplementedException();
    }

    int IReadOnlyCollection<char>.Count => _count;

    public char this[int index]
    {
        get => throw new NotImplementedException();
        set => throw new NotImplementedException();
    }

    public void Add(char item)
    {
        throw new NotImplementedException();
    }

    public void Clear()
    {
        throw new NotImplementedException();
    }

    public bool Contains(char item)
    {
        throw new NotImplementedException();
    }

    public void CopyTo(char[] array, int arrayIndex)
    {
        throw new NotImplementedException();
    }

    public bool Remove(char item)
    {
        throw new NotImplementedException();
    }

    int ICollection<char>.Count => _count1;

    public bool IsReadOnly { get; }
    public int IndexOf(char item)
    {
        throw new NotImplementedException();
    }

    public void Insert(int index, char item)
    {
        throw new NotImplementedException();
    }

    public void RemoveAt(int index)
    {
        throw new NotImplementedException();
    }

    int IIdentifier.Count => _count2;

    // TODO: Add creation API with lexer based checking
    // TODO: Add changing API similar to comments
    // TODO: Add integration into renaming refactoring
}