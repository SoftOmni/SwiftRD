
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers.DeclarationModifiers;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Declarations;

public class ClassKeywordToken : DeclarationUsableKeywordToken<Class>
{
    internal ClassKeywordToken()
        : base(Class.Keyword, SwiftTokens.ClassId, SwiftTokens.ClassIndex)
    { }
}
