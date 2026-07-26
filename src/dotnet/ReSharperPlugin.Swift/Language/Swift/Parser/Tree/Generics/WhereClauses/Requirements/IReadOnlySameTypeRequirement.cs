using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Operators.Usages;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.TypeIdentifiers;

namespace SoftOmni.SwiftRd.Rider.Language.Swift.Parser.Tree.Generics.WhereClauses.Requirements;

public interface IReadOnlySameTypeRequirement : IReadOnlyRequirement
{
    IReadOnlyTypeIdentifier TargetType { get; }
    
    IReadOnlyOperator SameTypeTargetIntroducer { get; }
}
