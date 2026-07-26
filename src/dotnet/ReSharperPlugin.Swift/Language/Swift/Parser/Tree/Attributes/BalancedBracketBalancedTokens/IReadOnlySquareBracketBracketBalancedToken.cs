using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Attributes.BalancedBracketBalancedTokens;

public interface IReadOnlySquareBracketBracketBalancedToken :
    IReadOnlyBracketBalancedToken
{
    LeftSquareBracket BalancedTokensStart { get; }

    RightSquareBracket BalancedTokenEnd { get; }
}
