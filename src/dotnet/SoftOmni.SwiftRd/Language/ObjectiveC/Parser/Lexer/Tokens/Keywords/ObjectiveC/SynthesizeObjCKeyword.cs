using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Keywords.ObjectiveC;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Keywords.ObjectiveC;

public sealed class SynthesizeObjCKeywordToken : ObjectiveCKeywordToken<SynthesizeObjCKeyword>
{
    internal SynthesizeObjCKeywordToken()
        : base(ObjectiveCTokens.SynthesizeObjCKeywordId, ObjectiveCTokens.SynthesizeObjCKeywordIndex)
    { }
}