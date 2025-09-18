using ReSharperPlugin.Swift.Language.Parser.Lexer.Tokens.Literals;
using ReSharperPlugin.Swift.Language.Semantics.Type.BuiltinTypes;

namespace ReSharperPlugin.Swift.Language.Parser.Lexer.Tokens.ExpressionsAndTypes;

public class FalseLiteralToken() : SwiftLiteral(SwiftTokens.FalseId, SwiftTokens.FalseIndex)
{
    public override bool IsConstantLiteral => true;

    public override bool ExpressionAndTypeUsable => true;

    public override string TokenRepresentation => SwiftTokens.FalseId;
}

public class FalseBackingLiteralToken()
    : TokenLiteralBacker<Bool, bool>(Bool.Instance, false, Keyword, SwiftTokens.FalseIndex)
{
    public const string Keyword = "false";
}
