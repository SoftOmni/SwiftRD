using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Literals;

public class StringLiteralToken : ObjectiveCLiteral
{
    internal StringLiteralToken()
        : base(ObjectiveCTokens.StringLiteralId, ObjectiveCTokens.StringLiteralIndex)
    { }

    public override string TokenRepresentation => ObjectiveCTokens.StringLiteralId;

    public override bool IsConstantLiteral => true;

    public override bool IsStringLiteral => true;

    public override LeafElementBase Create(IBuffer buffer, TreeOffset startOffset, TreeOffset endOffset)
    {
        throw new System.NotImplementedException();
    }
}

public class StringBackingLiteralToken(string valueOfContents, string value)
    : TokenLiteralBacker<string>(valueOfContents, value, ObjectiveCTokens.StringLiteralIndex);
    