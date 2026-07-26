using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Attributes.BalancedBracketBalancedTokens;

public interface IReadOnlyCurlyBraceBracketBalancedToken :
    IReadOnlyBracketBalancedToken
{
    LeftCurlyBrace BalancedTokensStart { get; }
    
    RightCurlyBrace BalancedTokenEnd { get; }
}
