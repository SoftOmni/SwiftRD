using System.Collections.Generic;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Identifiers;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.PrecedenceGroups.Relations;

public interface IPrecedenceGroupRelation : IReadOnlyPrecedenceGroupRelation,
    IPrecedenceGroupAttribute, IList<IIdentifier>
{
    new IReadOnlyList<IIdentifier> PrecedenceGroupNames { get; }
    
    new int Count { get; }

    new IEnumerator<IIdentifier> GetEnumerator();
    
    new IIdentifier this[int index] { get; set; }
}
