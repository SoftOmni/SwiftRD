using System.Collections.Generic;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Identifiers;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Attributes;

public interface IAttribute : IReadOnlyAttribute, IList<IBalancedToken>
{
    new IIdentifier Name { get; }
    
    new IReadOnlyList<IBalancedToken> BalancedTokens { get; }
    
    new int Count { get; }

    new IEnumerator<IBalancedToken> GetEnumerator();
    
    new IBalancedToken this[int index] { get; set; }
}
