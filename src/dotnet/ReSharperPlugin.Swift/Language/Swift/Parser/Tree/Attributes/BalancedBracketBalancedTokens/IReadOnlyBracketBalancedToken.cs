using System.Collections.Generic;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Attributes.BalancedBracketBalancedTokens;

public interface IReadOnlyBracketBalancedToken : IReadOnlyBalancedToken,
    IReadOnlyList<IReadOnlyBalancedToken>
{
    IReadOnlyList<IReadOnlyBalancedToken> BalancedTokens { get; }
}
