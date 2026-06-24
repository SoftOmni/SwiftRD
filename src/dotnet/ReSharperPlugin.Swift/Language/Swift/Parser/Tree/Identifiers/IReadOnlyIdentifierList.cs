using System.Collections.Generic;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Identifiers;

public interface IReadOnlyIdentifierList : IReadOnlyList<IReadOnlyIdentifier>
{
    IReadOnlyList<IReadOnlyIdentifier> Identifiers { get; }
    
    IReadOnlyList<Comma> Commas { get; }
}
