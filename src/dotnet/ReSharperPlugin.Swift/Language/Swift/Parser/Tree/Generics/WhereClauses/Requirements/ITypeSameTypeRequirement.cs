using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types;

namespace SoftOmni.SwiftRd.Rider.Language.Swift.Parser.Tree.Generics.WhereClauses.Requirements;

public interface ITypeSameTypeRequirement :
    IReadOnlyTypeSameTypeRequirement,
    ISameTypeRequirement
{
    new IType SameTypeTargetType { get; }

    void ChangeSameTypeTargetType(IType newSameTypeTargetType);
}
