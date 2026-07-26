using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.TypeIdentifiers;

namespace SoftOmni.SwiftRd.Rider.Language.Swift.Parser.Tree.Generics.WhereClauses.Requirements;

public interface ISameTypeRequirement : IReadOnlySameTypeRequirement, IRequirement
{
    new ITypeIdentifier TargetType { get; }

    void ChangeTargetType(ITypeIdentifier newTargetType);
}
