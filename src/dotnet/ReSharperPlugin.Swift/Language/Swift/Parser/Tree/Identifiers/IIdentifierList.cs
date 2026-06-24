using System.Collections.Generic;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Identifiers;

public interface IIdentifierList : IReadOnlyIdentifierList, IList<IIdentifier>
{
    new int Count { get; }

    new IEnumerator<IIdentifier> GetEnumerator();
    
    new IIdentifier this[int index] { get; }
}
