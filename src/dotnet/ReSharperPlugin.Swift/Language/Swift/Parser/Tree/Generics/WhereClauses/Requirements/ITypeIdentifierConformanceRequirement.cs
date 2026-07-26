using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.TypeIdentifiers;

namespace SoftOmni.SwiftRd.Rider.Language.Swift.Parser.Tree.Generics.WhereClauses.Requirements;

public interface ITypeIdentifierConformanceRequirement :
    IReadOnlyTypeIdentifierConformanceRequirement,
    IConformanceRequirement
{
    new ITypeIdentifier TargetConformanceType { get; }

    void ChangeTargetConformanceType(ITypeIdentifier newTargetConformanceType);
}
