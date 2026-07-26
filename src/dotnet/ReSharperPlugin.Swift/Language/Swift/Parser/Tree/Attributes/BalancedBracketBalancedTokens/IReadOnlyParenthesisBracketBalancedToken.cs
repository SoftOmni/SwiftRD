using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Attributes.BalancedBracketBalancedTokens;

public interface IReadOnlyParenthesisBracketBalancedToken
    : IReadOnlyBracketBalancedToken
{
    LeftParenthesis BalancedTokensStart { get; }

    RightParenthesis BalancedTokenEnd { get; }
}
