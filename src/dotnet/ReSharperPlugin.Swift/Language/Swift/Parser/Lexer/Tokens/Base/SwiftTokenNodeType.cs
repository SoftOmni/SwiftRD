using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.ReSharper.Psi.Parsing;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Exceptions;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Base;

public abstract class SwiftTokenNodeType : TokenNodeType
{
    public string Name { get; }
    
    protected SwiftTokenNodeType(string name, int index)
        : base(name, index)
    {
        Name = name;
        SwiftNodeTypeIndexer.Instance.Add(this, index);
    }

    public abstract override LeafElementBase Create(IBuffer buffer, TreeOffset startOffset, TreeOffset endOffset);

    public override bool IsWhitespace => false;

    public override bool IsComment => false;

    public override bool IsStringLiteral => false;

    public override bool IsConstantLiteral => false;

    public override bool IsIdentifier => false;

    public override bool IsKeyword => false;

    public virtual bool ExpressionAndTypeUsable => false;

    protected static void CheckAgainstValue(string expectedTokenValue, IBuffer buffer, string tokenId)
    {
        if (buffer.Length != expectedTokenValue.Length)
        {
            throw new InvalidLexicalBaseForElementException(tokenId, buffer, expectedTokenValue);
        }

        for (int i = 0; i < expectedTokenValue.Length; i++)
        {
            if (buffer[i] != expectedTokenValue[i])
            {
                throw new InvalidLexicalBaseForElementException(tokenId, buffer, expectedTokenValue);
            }
        }
    }
}
