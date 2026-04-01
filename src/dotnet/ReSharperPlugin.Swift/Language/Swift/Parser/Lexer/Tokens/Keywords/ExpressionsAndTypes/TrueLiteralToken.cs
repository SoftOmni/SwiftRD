using SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Literals;
using SoftOmni.SwiftRd.Language.Semantics.Type.BuiltinTypes;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.ExpressionsAndTypes;

public class TrueLiteralToken() : SwiftLiteral(SwiftTokens.TrueId, SwiftTokens.TrueIndex)
{
    public override bool IsConstantLiteral => true;

    public override bool ExpressionAndTypeUsable => true;

    public override string TokenRepresentation { get; } = SwiftTokens.TrueId;
}

public class TrueBackingLiteralToken()
    : TokenLiteralBacker<Bool, bool>(Bool.Instance, true, Keyword, SwiftTokens.FalseIndex)
{
    public const string Keyword = "true";
}