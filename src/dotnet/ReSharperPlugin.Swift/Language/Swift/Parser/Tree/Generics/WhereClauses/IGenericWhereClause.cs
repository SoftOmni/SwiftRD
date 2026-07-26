using System.Collections.Generic;
using SoftOmni.SwiftRd.Rider.Language.Swift.Parser.Tree.Generics.WhereClauses.Requirements;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Generics.WhereClauses;

public interface IGenericWhereClause : IReadOnlyGenericWhereClause,
    IList<IRequirement>
{
    new IReadOnlyList<IRequirement> Requirements { get; }
    
    new int Count { get; }

    new IEnumerator<IRequirement> GetEnumerator();
    
    new IRequirement this[int index] { get; set; }
}
