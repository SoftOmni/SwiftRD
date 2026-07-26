using System;
using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Semantics.Type.BuiltinTypes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Literals;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.ExpressionsAndTypes;

public class TrueLiteralToken : SwiftLiteral
{
    public TrueLiteralToken()
        : base(SwiftTokens.TrueId, SwiftTokens.TrueIndex)
    { }

    public override LeafElementBase Create(IBuffer buffer, TreeOffset startOffset, TreeOffset endOffset)
    {
        throw new NotImplementedException();
    }

    public override bool IsConstantLiteral => true;

    public override bool ExpressionAndTypeUsable => true;

    public override string TokenRepresentation { get; } = SwiftTokens.TrueId;
}

public class TrueBackingLiteralToken : TokenLiteralBacker<Bool, bool>
{
    public TrueBackingLiteralToken()
        : base(Bool.Instance, true, Keyword, SwiftTokens.FalseIndex)
    { }

    public const string Keyword = "true";
}