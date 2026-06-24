using System.Collections.Generic;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.TypeIdentifiers;

public interface IReadOnlyTypeIdentifier : IReadOnlyType, IReadOnlyList<IReadOnlyTypeIdentifierComponent>
{
    IReadOnlyList<IReadOnlyTypeIdentifierComponent> Identifiers { get; }
    
    IReadOnlyList<Period> Periods { get; }
}
