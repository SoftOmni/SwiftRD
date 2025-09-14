using ReSharperPlugin.Swift.Language.Parser.Lexer.Tokens.Literals;
using ReSharperPlugin.Swift.Language.Semantics.Type.BuiltinTypes;

namespace ReSharperPlugin.Swift.Language.Parser.Lexer.Tokens.ExpressionsAndTypes;

public class TrueLiteralToken() : SwiftLiteral<Bool, object?>(Bool.Instance, null, Keyword, SwiftTokens.TrueIndex)
{
    public const string Keyword = "true";
    
    public override bool IsConstantLiteral => true;

    public override bool ExpressionAndTypeUsable => true;

    public override string TokenRepresentation => Keyword;
}