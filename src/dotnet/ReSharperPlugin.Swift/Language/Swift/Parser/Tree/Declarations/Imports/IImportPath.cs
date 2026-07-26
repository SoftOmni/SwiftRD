using System.Collections.Generic;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Identifiers;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Imports;

public interface IImportPath : IReadOnlyImportPath,
    IList<IIdentifier>
{
    new IReadOnlyList<IIdentifier> Components { get; }
    
    new int Count { get; }

    new IEnumerator<IIdentifier> GetEnumerator();
    
    new IIdentifier this[int index] { get; set; }
}
