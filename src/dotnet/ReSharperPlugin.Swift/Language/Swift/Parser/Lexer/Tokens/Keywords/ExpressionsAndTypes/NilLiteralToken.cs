using SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Literals;
using SoftOmni.SwiftRd.Language.Semantics.Type.BuiltinTypes;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.ExpressionsAndTypes;

public class NilLiteralToken() : SwiftLiteral(SwiftTokens.NilId, SwiftTokens.NilIndex)
{
    public override bool IsConstantLiteral => true;

    public override bool ExpressionAndTypeUsable => true;

    public override string TokenRepresentation => SwiftTokens.NilId;
}

public class NilBackingLiteralToken()
    : TokenLiteralBacker<Nil, object?>(Nil.Instance, null, Keyword, SwiftTokens.FalseIndex)
{
    public const string Keyword = "nil";
}
