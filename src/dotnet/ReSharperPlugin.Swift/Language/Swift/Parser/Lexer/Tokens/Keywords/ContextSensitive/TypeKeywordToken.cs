
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.MetaTypes;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.ContextSensitive;

public class TypeKeywordToken : ContextSensitiveKeywordToken<Type>
{
    internal TypeKeywordToken()
        : base(Type.Keyword, SwiftTokens.TypeId, SwiftTokens.TypeIndex)
    { }
}
