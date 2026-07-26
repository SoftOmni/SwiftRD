using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types;

namespace SoftOmni.SwiftRd.Rider.Language.Swift.Parser.Tree.Generics.WhereClauses.Requirements;

public interface IReadOnlyTypeSameTypeRequirement : IReadOnlySameTypeRequirement
{
    IReadOnlyType SameTypeTargetType { get; }
}
