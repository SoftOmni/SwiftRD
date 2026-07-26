using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.ProtocolCompositionType;

namespace SoftOmni.SwiftRd.Rider.Language.Swift.Parser.Tree.Generics.WhereClauses.Requirements;

public interface IProtocolCompositionTypeConformanceRequirement :
    IReadOnlyProtocolCompositionTypeConformanceRequirement,
    IConformanceRequirement
{
    new IProtocolCompositionType ProtocolCompositionType { get; }

    void ChangeProtocolCompositionType(IProtocolCompositionType newProtocolCompositionType);
}
