using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Literals;

public sealed class CharacterLiteralToken : ObjectiveCLiteral
{
    internal CharacterLiteralToken()
        : base(ObjectiveCTokens.CharacterLiteralId, ObjectiveCTokens.CharacterLiteralIndex)
    { }

    public override string TokenRepresentation => ObjectiveCTokens.CharacterLiteralId;

    public override bool IsConstantLiteral => true;

    public override LeafElementBase Create(IBuffer buffer, TreeOffset startOffset, TreeOffset endOffset)
    {
        throw new System.NotImplementedException();
    }
}

public class CharacterBackingLiteralToken(string intermediateValueOfContents, string value)
    : TokenLiteralBacker<string>(intermediateValueOfContents, value, ObjectiveCTokens.CharacterLiteralIndex);
    