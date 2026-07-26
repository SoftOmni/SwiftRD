using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Variables.GetterSetterBlocks;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.ContextSensitive;

public class GetKeywordToken : ContextSensitiveKeywordToken<Get>
{
    internal GetKeywordToken()
        : base(Get.Keyword, SwiftTokens.GetId, SwiftTokens.GetIndex)
    { }
}
