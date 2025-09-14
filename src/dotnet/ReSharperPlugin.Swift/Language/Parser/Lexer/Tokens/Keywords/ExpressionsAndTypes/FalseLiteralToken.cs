using ReSharperPlugin.Swift.Language.Parser.Lexer.Tokens.Literals;
using ReSharperPlugin.Swift.Language.Semantics.Type.BuiltinTypes;

namespace ReSharperPlugin.Swift.Language.Parser.Lexer.Tokens.ExpressionsAndTypes;

public class FalseLiteralToken() : SwiftLiteral<Bool, object?>(Bool.Instance, null, Keyword, SwiftTokens.FalseIndex)
{
    public const string Keyword = "false";
    
    public override bool IsConstantLiteral => true;

    public override bool ExpressionAndTypeUsable => true;

    public override string TokenRepresentation => Keyword;
}
