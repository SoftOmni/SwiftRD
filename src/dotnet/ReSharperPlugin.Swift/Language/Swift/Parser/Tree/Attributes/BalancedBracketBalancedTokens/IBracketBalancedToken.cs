using System.Collections.Generic;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Attributes.BalancedBracketBalancedTokens;

public interface IBracketBalancedToken : IReadOnlyBracketBalancedToken,
    IList<IBalancedToken>
{
    new IReadOnlyList<IBalancedToken> BalancedTokens { get; }
    
    new int Count { get; }

    new IEnumerator<IBalancedToken> GetEnumerator();
    
    new IBalancedToken this[int index] { get; }
}