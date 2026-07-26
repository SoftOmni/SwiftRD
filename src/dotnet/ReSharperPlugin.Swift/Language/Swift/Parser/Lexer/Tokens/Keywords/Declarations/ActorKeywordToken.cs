using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Actors;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Declarations;

public class ActorKeywordToken : DeclarationUsableKeywordToken<Actor>
{
    internal ActorKeywordToken()
        : base(Actor.Keyword, SwiftTokens.ActorId, SwiftTokens.ActorIndex)
    { }
}