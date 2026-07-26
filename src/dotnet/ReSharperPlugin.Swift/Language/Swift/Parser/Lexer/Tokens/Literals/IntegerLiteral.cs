using System;
using System.Numerics;
using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using Type = SoftOmni.SwiftRd.Language.Semantics.Type.Type;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Literals;

public class IntegerLiteralToken : SwiftLiteral
{
    internal IntegerLiteralToken()
        : base(SwiftTokens.IntegerLiteralId, SwiftTokens.IntegerLiteralIndex)
    { }

    public override bool IsConstantLiteral => true;

    public override string TokenRepresentation => SwiftTokens.IntegerLiteralId;

    public override LeafElementBase Create(IBuffer buffer, TreeOffset startOffset, TreeOffset endOffset)
    {
        throw new NotImplementedException();
    }
}

public class IntegerBackingLiteralToken<TType>(TType type, BigInteger valueOfContents, string value, IntegerRepresentation representation = IntegerRepresentation.Decimal)
    : TokenLiteralBacker<TType, BigInteger>(type, valueOfContents, value, SwiftTokens.FalseIndex) where TType : Type
{
    public IntegerRepresentation Representation { get; } = representation;
}

public enum IntegerRepresentation
{
    Decimal,
    Hexadecimal,
    Binary
}