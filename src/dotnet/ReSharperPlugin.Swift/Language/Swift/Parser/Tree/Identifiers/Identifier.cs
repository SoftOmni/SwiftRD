using System;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.LeafNodes;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Identifiers;

public class Identifier : SwiftLeafNode<SwiftCompositeNode>
{
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
            if (character >= 128)
            {
                return false;
            }
        }

        return true;
    }
    
    // TODO: Add creation API with lexer based checking
    // TODO: Add changing API similar to comments
    // TODO: Add integration into renaming refactoring
}