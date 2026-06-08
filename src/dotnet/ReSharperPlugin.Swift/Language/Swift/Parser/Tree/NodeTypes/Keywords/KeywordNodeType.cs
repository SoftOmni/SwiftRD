using JetBrains.Text;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.NodeTypes.Keywords;

public abstract class KeywordNodeType(string id, int index) : SwiftNodeType(id, index)
{
    public override bool IsWhitespace => false;

    public override bool IsComment => false;

    public override bool IsStringLiteral => false;

    public override bool IsConstantLiteral => false;

    public override bool IsIdentifier => false;

    public override bool IsKeyword => true;

    public override bool IsFiltered => false;

    protected static void CheckAgainstValue(string keywordValue, IEditableBuffer buffer, string tokenId)
    {
        if (buffer.Length != keywordValue.Length)
        {
            throw new InvalidLexicalBaseForElement(tokenId, buffer);
        }

        for (int i = 0; i < keywordValue.Length; i++)
        {
            if (buffer[i] != keywordValue[i])
            {
                throw new InvalidLexicalBaseForElement(tokenId, buffer);
            }
        }
    }
}