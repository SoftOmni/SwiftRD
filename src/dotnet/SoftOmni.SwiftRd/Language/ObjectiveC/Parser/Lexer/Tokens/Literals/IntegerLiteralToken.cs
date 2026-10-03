using System.Numerics;
using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Literals;

public sealed class IntegerLiteralToken : ObjectiveCLiteral
{
    internal IntegerLiteralToken()
        : base(ObjectiveCTokens.IntegerLiteralId, ObjectiveCTokens.IntegerLiteralIndex)
    { }

    public override bool IsConstantLiteral => true;

    public override string TokenRepresentation => ObjectiveCTokens.IntegerLiteralId;

    public override LeafElementBase Create(IBuffer buffer, TreeOffset startOffset, TreeOffset endOffset)
    {
        throw new System.NotImplementedException();
    }
}

public class IntegerBackingLiteralToken(BigInteger valueOfContents, string value, IntegerRepresentation representation = IntegerRepresentation.Decimal)
    : TokenLiteralBacker<BigInteger>(valueOfContents, value, ObjectiveCTokens.IntegerLiteralIndex)
{
    public IntegerRepresentation Representation { get; internal set; } = representation;
}

public enum IntegerRepresentation
{
    Decimal,
    Hexadecimal,
    Binary,
    Octal
}
