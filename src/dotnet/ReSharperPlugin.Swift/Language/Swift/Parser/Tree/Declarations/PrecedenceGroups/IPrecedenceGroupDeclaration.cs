using System.Collections.Generic;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Identifiers;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.PrecedenceGroups;

public interface IPrecedenceGroupDeclaration : IReadOnlyPrecedenceGroupDeclaration,
    IList<IPrecedenceGroupAttribute>
{
    new IIdentifier Name { get; }
    
    new IReadOnlyList<IPrecedenceGroupAttribute> PrecedenceGroupAttributes { get; }
    
    new int Count { get; }

    new IEnumerator<IPrecedenceGroupAttribute> GetEnumerator();
    
    new IPrecedenceGroupAttribute this[int index] { get; set; }
}
