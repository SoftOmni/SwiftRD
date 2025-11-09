using JetBrains.Text;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Identifiers;

public class Identifier : SwiftLeafNode
{
    public bool IsOnlyAscii { get; private set; }

    public Identifier(IEditableBuffer buffer)
        : base(buffer, NodeTypes.NodeTypes.Identifier)
    {
        IsOnlyAscii = IsMadeUpOfAscii();
    }

    public Identifier(ISwiftNode parent, IEditableBuffer buffer)
        : base(parent, buffer, NodeTypes.NodeTypes.Identifier)
    {
        IsOnlyAscii = IsMadeUpOfAscii();
    }

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
}