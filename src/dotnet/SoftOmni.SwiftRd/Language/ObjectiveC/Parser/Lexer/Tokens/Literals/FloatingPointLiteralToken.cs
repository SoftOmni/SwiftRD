using ExtendedNumerics;
using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Literals;

public sealed class FloatingPointLiteralToken()
    : ObjectiveCLiteral(ObjectiveCTokens.FloatingPointLiteralId, ObjectiveCTokens.FloatingPointLiteralIndex)
{
    public override bool IsConstantLiteral => true;

    public override string TokenRepresentation { get; } = ObjectiveCTokens.FloatingPointLiteralId;

    public override LeafElementBase Create(IBuffer buffer, TreeOffset startOffset, TreeOffset endOffset)
    {
        throw new System.NotImplementedException();
    }
}

public class FloatingPointLiteralTokenBaker(
    BigDecimal valueOfContents,
    string value,
    FloatingPointRepresentation representation = FloatingPointRepresentation.Decimal) :
    TokenLiteralBacker<BigDecimal>(valueOfContents, value, ObjectiveCTokens.FloatingPointLiteralIndex)
{
    public FloatingPointRepresentation Representation { get; internal set; } = representation;
}

public enum FloatingPointRepresentation
{
    Decimal,
    Hexadecimal
}
