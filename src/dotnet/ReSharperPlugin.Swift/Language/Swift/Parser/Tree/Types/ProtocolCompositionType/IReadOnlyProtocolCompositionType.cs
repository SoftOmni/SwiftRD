using System.Collections.Generic;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.TypeIdentifiers;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.ProtocolCompositionType;

public interface IReadOnlyProtocolCompositionType : IReadOnlyType, IReadOnlyList<IReadOnlyTypeIdentifier>
{
    IReadOnlyList<IReadOnlyTypeIdentifier> ProtocolComposition { get; }
}
