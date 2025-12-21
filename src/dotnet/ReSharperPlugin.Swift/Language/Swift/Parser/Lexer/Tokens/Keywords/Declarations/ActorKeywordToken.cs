using ReSharperPlugin.Swift.Language.Parser.Tree.Declarations.Actors;

namespace ReSharperPlugin.Swift.Language.Parser.Lexer.Tokens.Declarations;

public class ActorKeywordToken : DeclarationUsableKeywordToken
{
    internal ActorKeywordToken()
        : base(ActorKeyword.Keyword, SwiftTokens.ActorId, SwiftTokens.ActorIndex)
    { }
}