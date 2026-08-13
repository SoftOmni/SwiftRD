using ExtendedNumerics;
using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Semantics.Type;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Literals;

public class FloatingPointLiteralToken()
    : SwiftLiteral(SwiftTokens.FloatingPointLiteralId, SwiftTokens.FloatingPointLiteralIndex)
{
    public override bool IsConstantLiteral => true;

    public override string TokenRepresentation { get; } = SwiftTokens.FloatingPointLiteralId;

    public override LeafElementBase Create(IBuffer buffer, TreeOffset startOffset, TreeOffset endOffset)
    {
        throw new System.NotImplementedException();
    }
}

public class FloatingPointLiteralTokenBaker<TType>(
    TType type,
    BigDecimal valueOfContents,
    string value,
    FloatingPointRepresentation representation = FloatingPointRepresentation.Decimal) :
    TokenLiteralBacker<TType, BigDecimal>(type, valueOfContents, value, SwiftTokens.FloatingPointLiteralIndex) where TType : Type
{
    public FloatingPointRepresentation Representation { get; } = representation;
}

public enum FloatingPointRepresentation
{
    Decimal,
    Hexadecimal
}
