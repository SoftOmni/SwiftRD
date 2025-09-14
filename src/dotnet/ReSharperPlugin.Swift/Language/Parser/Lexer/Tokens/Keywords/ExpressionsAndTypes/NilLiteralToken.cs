using ReSharperPlugin.Swift.Language.Parser.Lexer.Tokens.Literals;
using ReSharperPlugin.Swift.Language.Semantics.Type.BuiltinTypes;

namespace ReSharperPlugin.Swift.Language.Parser.Lexer.Tokens.ExpressionsAndTypes;

public class NilLiteralToken() : SwiftLiteral<Nil, object?>(Nil.Instance, null, Keyword, SwiftTokens.NilIndex)
{
    public const string Keyword = "nil";
    
    public override bool IsConstantLiteral => true;

    public override bool ExpressionAndTypeUsable => true;

    public override string TokenRepresentation => Keyword;
}
