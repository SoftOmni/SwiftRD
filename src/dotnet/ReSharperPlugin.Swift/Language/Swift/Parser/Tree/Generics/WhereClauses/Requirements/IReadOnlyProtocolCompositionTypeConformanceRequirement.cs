using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.ProtocolCompositionType;

namespace SoftOmni.SwiftRd.Rider.Language.Swift.Parser.Tree.Generics.WhereClauses.Requirements;

public interface IReadOnlyProtocolCompositionTypeConformanceRequirement :
    IReadOnlyConformanceRequirement
{
    IReadOnlyProtocolCompositionType ProtocolCompositionType { get; }
}
