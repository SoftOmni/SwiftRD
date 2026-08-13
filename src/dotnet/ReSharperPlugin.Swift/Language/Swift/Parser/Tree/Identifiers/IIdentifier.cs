using System.Collections.Generic;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Identifiers;

public interface IIdentifier : IReadOnlyIdentifier, IList<char>
{
    new int Count { get; }
    
    new char this[int index] { get; }

    bool IsEmpty();
}
